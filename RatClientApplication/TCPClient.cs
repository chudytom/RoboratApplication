using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace RatClientApplication
{
    class TCPlient
    {
        private Socket clientSocket;
        public TCPlient()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public bool IsConnected { get; set; }
        public string IP { get; set; }
        public int PortNumber { get; set; }
        public string OutputText { get; set; }
        public string IncomingText { get; set; }
        public string InputText { get; set; }
        
        //const int PORT = 100;
        const int BUFFER_SIZE = 1024;
        byte[] incomingBuffer = new byte[BUFFER_SIZE];

        public virtual void InvokeMessageReceived(EventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }

        public void Start()
        {
            IsConnected = false;
            OutputText = "Nothing to display";
            ConnectToServer();
        }

        private void ConnectToServer()
        {   
            try
            {
                clientSocket.BeginConnect(IPAddress.Parse(IP), PortNumber, new AsyncCallback(ConnectCallback), clientSocket);
                //_clientSocket.BeginConnect(IPAddress.Loopback, PortNumber, new AsyncCallback(ConnectCallback), _clientSocket);
            }
            catch(Exception)
            {
                OutputText = "Couldn't  connect to the server (begin)";
                CloseConnection();
                return;
            }
            
            OutputText = "Client setup complete. Waiting for a server";
        }

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
            }
            catch(SocketException)
            {
                OutputText = "Cannot connect to the server (end, SocketException)";
                return;
            }
            catch(ArgumentException)
            {
                OutputText = "Cannot connect to the server(end, ArgumentException)";
                return;
            }
            IsConnected = clientSocket.Connected;
            try
            {
                clientSocket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
                Thread.Sleep(200);
            }
            catch (SocketException)
            {
                CloseConnection();
                ConnectToServer();
                OutputText = "Sudden connection lost";
                Thread.Sleep(3000);
            }
            catch (Exception)
            {
                CloseConnection();
                OutputText = "Sudden connection lost";
            }
            OutputText = "ConnectedC";
        }

        public void SendString(string stringToSend)
        {
            byte[] outgoingBuffer = Encoding.ASCII.GetBytes(stringToSend);
            try
            {
                clientSocket.Send(outgoingBuffer, 0, outgoingBuffer.Length, SocketFlags.None);
            }
            catch(SocketException)
            {
                OutputText = "Unable to send string (SocketException)";
                clientSocket.Close();
                return;
            }
            catch(ObjectDisposedException)
            {
                OutputText = "Unable to send string (ObjectDisposedException)";
                CloseConnection();
                return;
            }
        }

        void ReceiveResponse()
        {
            try
            {
                clientSocket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
                Thread.Sleep(200);
            }
            catch (SocketException)
            {
                CloseConnection();
                InputText = "This error";
                OutputText = "This error";
                ConnectToServer();
                Thread.Sleep(3000);
                OutputText = "This error";
            }
            catch (Exception)
            {
                CloseConnection();
                OutputText = "Sudden connection lost";
            }
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = 0;
            try
            {
                received = socket.EndReceive(AR);
            }
            catch(SocketException)
            {
                OutputText = "Couldn't receive the message(SocketException)";
                clientSocket.Close();
                return;
            }
            catch(ObjectDisposedException)
            {
                OutputText = "Couldn't receive the message(ObjDisposed)";
                CloseConnection();
                return;
            }
            byte[] tempBuffer = new byte[received];
            Array.Copy(incomingBuffer, tempBuffer, received);
            string text = Encoding.ASCII.GetString(tempBuffer);
            IncomingText = text;
            InvokeMessageReceived(EventArgs.Empty);
            try
            { 
                socket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                Thread.Sleep(200);
            }
            catch(SocketException)
            {
                CloseConnection();
                InputText = "This error";
                OutputText = "This error";
                ConnectToServer();
                Thread.Sleep(3000);
                OutputText = "This error";
            }
            catch (Exception)
            {
                CloseConnection();
                OutputText = "Suddenly connection lost";
            }           
        }

        public static bool IsIPFormatCorrect(string ipString)
        {
            if(string.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }
            string[] splitIP = ipString.Split('.');
            if(splitIP.Length!=4)
            {
                return false;
            }
            return splitIP.All(splitNumber => byte.TryParse(splitNumber, out byte byteTester));
        }
        public void CloseConnection()
        {
            IsConnected = false;
            clientSocket.Close();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public event EventHandler MessageReceived;
    }
}
