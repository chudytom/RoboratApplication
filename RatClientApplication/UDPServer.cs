using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.IO;
using RatClientApplication;

namespace UDP
{
    class UDPServer
    {
        public bool IsConnected { get; set; }
        private Socket serverSocket;
        public int PortNumber { get; set; }
        public string OutputText { get; set; }
        public string InputText { get; private set; }
        private int bytesReceived { get; set; }
        private string ipAddress = "192.168.0.108";
        private readonly int bufferSize = 262144;
        //private readonly int bufferSize = 16384;
        private byte[] incomingBuffer;
        private EndPoint remoteEndPoint;
        public Bitmap ImageToDisplay { get; set; }
        private ImageDisplay displayObject;

        public UDPServer(ImageDisplay passedObject)
        {
            IsConnected = false;
            displayObject = passedObject;
        }

        public void Start()
        {
            InitializeSocket();
            StartReceiving();
        }

        private void InitializeSocket()
        {
            if(PortNumber==0)
                PortNumber = 200;
            incomingBuffer = new byte[bufferSize];
            byte[] buffer = new byte[1024];
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), PortNumber);
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

        private void StartReceiving()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Parse(ipAddress), PortNumber);
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
            //OutputText = String.Format("Message from {0}", remoteEndPoint.ToString());
            MemoryStream memoryStream = new MemoryStream(incomingBuffer);
            //Here an exception when to large an image received or the buffer is too small
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

            incomingBuffer = new byte[bufferSize];
            try
            {
                socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), serverSocket);
            }
            catch(ArgumentOutOfRangeException e)
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
            serverSocket.Close();
            if (startConnection)
                Start();
        }
    }
}
