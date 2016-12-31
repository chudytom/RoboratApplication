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
        private Socket serverSocket;
        public int PortNumber { get; set; }
        public string OutputText { get; set; }
        public string InputText { get; private set; }
        private int bytesReceived { get; set; }
        private string ipAddress = "192.168.0.108";
        //private int bufferSize = 16384;
        //private int bufferSize = 131072;
        private int bufferSize = 262144;
        private byte[] incomingBuffer;
        private EndPoint remoteEndPoint;
        public Bitmap ImageToDisplay { get; set; }
        private ImageDisplay displayObject;

        public UDPServer(ImageDisplay passedObject)
        {
            displayObject = passedObject;
        }

        //static void Main(string[] args)
        //{
        //    UDPServer server = new UDPServer();
        //    server.Start();
        //    System.Threading.Thread.Sleep(20000);
        //    server.CloseConnection();
        //}

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
            catch (Exception)
            {
                OutputText = "Wrong Bind";
                //Console.WriteLine("Wrong Bind");
                return;
            }
            //serverSocket.Connect(endPoint);
            OutputText = "Waiting for a client...";
            //Console.WriteLine("Waiting for a client...");
        }

        private void StartReceiving()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Parse(ipAddress), PortNumber);
            //serverSocket.Connect(sender);
            remoteEndPoint = (EndPoint)sender;
            try
            {
                serverSocket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), serverSocket);
                //serverSocket.BeginReceive(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), serverSocket);
            }
            catch (Exception)
            {
                OutputText = "Begin Receive Exception";
                //Console.WriteLine("Begin Receive Exception");
                CloseConnection();
            }
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            try
            {
                bytesReceived = socket.EndReceiveFrom(AR, ref remoteEndPoint);
                //bytesReceived = socket.EndReceive(AR);
            }
            catch (Exception)
            {
                //Console.WriteLine("End Receive Exception");
                OutputText = "End Receive Exception";
                CloseConnection();
            }
            //socket = (Socket)AR.AsyncState;
            OutputText = String.Format("Message from {0}", remoteEndPoint.ToString());
            MemoryStream memoryStream = new MemoryStream(incomingBuffer);
            //NetworkStream networkStream = new NetworkStream(socket);
            ImageToDisplay = new Bitmap(Image.FromStream(memoryStream));
            displayObject.OnImageReceived(EventArgs.Empty);
            //OutputText = String.Format(Encoding.ASCII.GetString(incomingBuffer, 0, bytesReceived));
            //Console.WriteLine("Message from {0}", remoteEndPoint.ToString());
            //Console.WriteLine(Encoding.ASCII.GetString(receivedData, 0, bytesReceived));

            //string welcome = "Welcome to my server!";
            //incomingBuffer = Encoding.ASCII.GetBytes(welcome);
            incomingBuffer = new byte[bufferSize];
            try
            {
                socket.BeginReceiveFrom(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(ReceiveCallback), serverSocket);
                //serverSocket.BeginReceive(incomingBuffer, 0, incomingBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), serverSocket);
            }
            catch(ArgumentOutOfRangeException e)
            {
                //Console.Beep();
                //Console.WriteLine("Begin Receive Exception - Repetition");
                //Console.WriteLine("Message: {0}", e.Message);
                OutputText = String.Format("Begin Receive Exception - Repetition");
                OutputText = String.Format("Message: {0}", e.Message);
                CloseConnection();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Begin Receive Exception - Repetition");
                //Console.WriteLine("Message {0}", e.Message);
                OutputText = String.Format("Begin Receive Exception - Repetition");
                OutputText = String.Format("Message: {0}", e.Message);
                CloseConnection();
            }
        }



        private void CloseConnection()
        {
            serverSocket.Close();
            //    serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Start();
        }
    }
}
