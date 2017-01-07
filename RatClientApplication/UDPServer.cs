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
        public bool IsConnected { get; set; }
        private Socket serverSocket;
        public int PortNumber { get; set; }
        public string OutputText { get; set; }
        public string InputText { get; private set; }
        private int bytesReceived { get; set; }
        public string IpAddress { get; set; }
        private readonly int bufferSize = UInt16.MaxValue;
        //private readonly int bufferSize = 262144;
        //private readonly int bufferSize = 16384;
        private byte[] incomingBuffer;
        private EndPoint remoteEndPoint;
        public Bitmap ImageToDisplay { get; set; }
        private ImageDisplay displayObject;
        private UInt16 totalPack = 1;
        private UInt16 remainingPackages = 1;
        private UInt16 packageSize = 4096;
        private byte[] longBuffer;
        bool isReadyToReceiveImage = false;

        public UDPServer(ImageDisplay passedObject)
        {
            IsConnected = false;
            displayObject = passedObject;
            //longBuffer = new byte[totalPack * packageSize];
            //longBuffer = new byte[262144];
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
            //byte[] buffer = new byte[1024];
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
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, PortNumber);
            remoteEndPoint = (EndPoint)sender;
            //BeginReceiving(serverSocket, remoteEndPoint);
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
                OutputText += String.Format("Received {0} bytes in {1}", bytesReceived, totalPack);
            }
            catch(SocketException)
            {
                string closeMessage = "The image received is incorrect. Try decresing its resolution and connect again";
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
            try
            {
                if (bytesReceived == 4)
                {
                    OutputText = "Single byte received";
                    totalPack = BitConverter.ToUInt16(incomingBuffer, 0);
                    remainingPackages = totalPack;
                    packageSize = BitConverter.ToUInt16(incomingBuffer, 2);
                    longBuffer = new byte[totalPack * packageSize];
                    isReadyToReceiveImage = true;
                }
                //else if (bytesReceived == 0)
                //{
                //    BeginReceiving(socket, remoteEndPoint);
                //    return;
                //}
                else if(isReadyToReceiveImage)
                {
                    int currentEndIndex = (totalPack - remainingPackages) * packageSize;
                    //incomingBuffer.CopyTo(longBuffer, currentEndIndex);
                    Array.Copy(incomingBuffer, 0, longBuffer, currentEndIndex, packageSize);
                    remainingPackages--;

                    if (remainingPackages == 0)
                    {
                        isReadyToReceiveImage = false;
                        TryDisplayImage();
                    }
                }
            }
            catch (Exception e)
            {
                CloseConnection(e.Message);
                return;
            }

            //BeginReceiving(socket, remoteEndPoint);

            //OutputText = String.Format("Message from {0}", remoteEndPoint.ToString());
            //MemoryStream memoryStream = new MemoryStream(incomingBuffer);
            ////Here an exception when to large an image received or the buffer is too small
            //try
            //{
            //    ImageToDisplay = new Bitmap(Image.FromStream(memoryStream));
            //}
            //catch (ArgumentException)
            //{
            //    string closeMessage = "The image received is incorrect. Try decresing its resolution and connect again";
            //    CloseConnection(closeMessage);
            //    return;
            //}
            //catch (OutOfMemoryException e)
            //{
            //    string txt = String.Format("Memory is full. Restart the application");
            //    CloseConnection(txt + e.Message);
            //    return;
            //}
            //catch (Exception e)
            //{
            //    CloseConnection(e.Message);
            //    return;
            //}
            //displayObject.OnImageReceived(EventArgs.Empty);

            incomingBuffer = new byte[bufferSize];
            socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
            //try
            //{
            //    socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
            //}
            //catch (SocketException e)
            //{
            //    string txt = String.Format("This socket exception");
            //    CloseConnection(txt + e.Message);
            //    return;
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    string txt = String.Format("Begin Receive Exception - Repetition");
            //    CloseConnection(txt + e.Message);
            //}
            //catch (OutOfMemoryException e)
            //{
            //    string txt = "Handled2 ";
            //    CloseConnection(txt + e.Message);
            //    return;
            //}
            //catch (Exception e)
            //{
            //    string txt = String.Format("Begin Receive Exception - Repetition");
            //    CloseConnection(txt + e.Message);
            //}
        }

        private void TryDisplayImage()
        {
            MemoryStream memoryStream = new MemoryStream(longBuffer);
            try
            {
                ImageToDisplay = new Bitmap(Image.FromStream(memoryStream));
            }
            catch (ArgumentException)
            {
                string closeMessage = "The image received is incorrect. Try decresing its resolution and connect again";
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
            displayObject.OnImageReceived(EventArgs.Empty);
        }

        private void BeginReceiving(Socket socket, EndPoint remoteEndPoint)
        {
            //incomingBuffer = new byte[bufferSize];
            //socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
            //try
            //{
            //    socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), socket);
            //}
            //catch (SocketException e)
            //{
            //    string txt = String.Format("This socket exception");
            //    CloseConnection(txt + e.Message);
            //    return;
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    string txt = String.Format("Begin Receive Exception - Repetition");
            //    CloseConnection(txt + e.Message);
            //}
            //catch (OutOfMemoryException e)
            //{
            //    string txt = "Handled2 ";
            //    CloseConnection(txt + e.Message);
            //    return;
            //}
            //catch (Exception e)
            //{
            //    string txt = String.Format("Begin Receive Exception - Repetition");
            //    CloseConnection(txt + e.Message);
            //}
        }

        private void CloseConnection(string reasonForClosure, bool startConnection = false)
        {
            OutputText = String.Format(" {0}", reasonForClosure);
            IsConnected = false;
            //serverSocket.Close();
            if (startConnection)
                Start();
        }
    }
}
