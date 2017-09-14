using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.IO;
using RatClientApplication;

namespace RatClientApplication
{
    class UDPServer
    {
        public Bitmap ImageBitMap { get; set; }
        public byte[] JpegImageBytes { get; private set; }
        public bool ContinueSavingAndDisplayingImages { get; set; }
        public bool IsConnected { get; set; }
        public string OutputText { get; set; }
        public string InputText { get; private set; }
        public int PortNumber { get; set; }
        public string IpAddress { get; set; }

        private Socket serverSocket;
        private int bytesReceived;
        private readonly int bufferSize = UInt16.MaxValue;
        private byte[] incomingBuffer;
        private EndPoint remoteEndPoint;
        private ImageDisplay displayObject;
        private UInt16 totalPack = 1;
        private UInt16 remainingPackages = 1;
        private UInt16 packageSize = 4096;
        private byte[] longBuffer;
        private bool isReadyToReceiveImage = false;

        public UDPServer(ImageDisplay passedObject)
        {
            IsConnected = false;
            displayObject = passedObject;
            ContinueSavingAndDisplayingImages = true;
        }

        public void Start()
        {
            InitializeSocket();
            PrepareReceiving();
        }

        private void InitializeSocket()
        {
            if(PortNumber==0)
                PortNumber = 50100;
            incomingBuffer = new byte[bufferSize];
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, PortNumber);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                serverSocket.Bind(endPoint);
            }
            catch (Exception e)
            {
                string txt = "Wrong bind";
                CloseConnection(txt + e.Message);
                return;
            }
            IsConnected = true;
            OutputText = "Waiting for a client...";
        }

        private void PrepareReceiving()
        {
            ContinueSavingAndDisplayingImages = true;
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, PortNumber);
            remoteEndPoint = (EndPoint)sender;
            try
            {
                serverSocket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), serverSocket);
            }
            catch (OutOfMemoryException e)
            {
                string txt = "Handled4 ";
                CloseConnection(txt + e.Message);
                return;
            }
            catch (Exception e)
            {
                string txt = "Begin Receive Exception";
                CloseConnection(txt + e.Message);
                return;
            }
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            try
            {
                bytesReceived = socket.EndReceiveFrom(AR, ref remoteEndPoint);
            }
            catch(SocketException)
            {
                string closeMessage = "The image received is incorrect. Problems while receving images. Try decresing its resolution and connect again";
                CloseConnection(closeMessage);
                return;
            }
            catch(OutOfMemoryException e)
            {
                string txt = "Handled1 ";
                CloseConnection(txt + e.Message);
                return;
            }
            catch (Exception e)
            {
                string txt = "End Receive Exception";
                CloseConnection(txt + e.Message);
                return;
            }
                if (bytesReceived == 4 && !isReadyToReceiveImage)
                {
                    totalPack = BitConverter.ToUInt16(incomingBuffer, 0);
                    remainingPackages = totalPack;
                    packageSize = BitConverter.ToUInt16(incomingBuffer, 2);
                    longBuffer = new byte[totalPack * packageSize];
                    isReadyToReceiveImage = true;
                }
                else if(isReadyToReceiveImage)
                {
                    int currentEndIndex = (totalPack - remainingPackages) * packageSize;
                    Array.Copy(incomingBuffer, 0, longBuffer, currentEndIndex, packageSize);
                    remainingPackages--;

                    if (remainingPackages == 0)
                    {
                        isReadyToReceiveImage = false;
                        TryDisplayImage();
                    }
                }
            incomingBuffer = new byte[bufferSize];
            socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
        }

        private void TryDisplayImage()
        {
            JpegImageBytes = longBuffer;
            try
            {
                ImageBitMap = new Bitmap(Image.FromStream(new MemoryStream(JpegImageBytes)));
            }
            catch (ArgumentException)
            {
                string closeMessage = "The image received is incorrect. Problems while displaying. Try decresing its resolution and connect again";
                CloseConnection(closeMessage);
                return;
            }
            catch (OutOfMemoryException e)
            {
                string txt = String.Format("Memory is full. Restart the application");
                CloseConnection(txt + e.Message);
                return;
            }
            catch (Exception e)
            {
                CloseConnection(e.Message);
                return;
            }
            if(ContinueSavingAndDisplayingImages)
                displayObject.OnImageReceived(EventArgs.Empty);
        }

        private void BeginReceiving(Socket socket, EndPoint remoteEndPoint)
        {
            incomingBuffer = new byte[bufferSize];
            socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
            try
            {
                socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
            }
            catch (SocketException e)
            {
                string txt = String.Format("This socket exception");
                CloseConnection(txt + e.Message);
                return;
            }
            catch (ArgumentOutOfRangeException e)
            {
                string txt = String.Format("Begin Receive Exception - Repetition");
                CloseConnection(txt + e.Message);
            }
            catch (OutOfMemoryException e)
            {
                string txt = "Handled2 ";
                CloseConnection(txt + e.Message);
                return;
            }
            catch (Exception e)
            {
                string txt = String.Format("Begin Receive Exception - Repetition");
                CloseConnection(txt + e.Message);
            }
        }

        private void CloseConnection(string reasonForClosure, bool startConnection = false)
        {
            OutputText = String.Format(" {0}", reasonForClosure);
            IsConnected = false;
            if (startConnection)
                Start();
        }

        public void CloseConnection()
        {
            CloseConnection("Disconnect button clicked");
        }
    }
}
