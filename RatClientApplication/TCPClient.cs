using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCP
{
    
    class TCPClient
    {
        public bool IsConnected { get; set; }
        public string IP { get; set; }
        public int PortNumber { get; set; }
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        const int PORT = 100;
        const int BUFFER_SIZE = 1024;
        byte[] incomingBuffer = new byte[BUFFER_SIZE];
        public string OutputText { get; set; }    
        public string InputText { get; set; }

        public void Start()
        {
            IsConnected = false;
            OutputText = "Nothing to display";
            ConnectToServer();
        }
        ///////////////////////////
        private void ConnectToServer()
        {   
            try
            {
                _clientSocket.BeginConnect(IPAddress.Parse(IP), PortNumber, new AsyncCallback(ConnectCallback), _clientSocket);
                //_clientSocket.BeginConnect(IPAddress.Parse(IP), PortNumber, new AsyncCallback(ConnectCallback), _clientSocket);
                //_clientSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
            }
            catch(Exception)
            {
                OutputText = "Couldn't  connect to the server";
                CloseConnection();
                return;
            }
            
            OutputText = "Client setup complete. Waiting for a server";
            //while (!_clientSocket.Connected)
            //{
            //    try
            //    {
            //        attemptsToConnect++;
            //        OutputText = " Connecting to server...";
            //        ////////////////////////////////////////////////////
            //        try
            //        {
            //            _clientSocket.Connect(IPAddress.Parse(IP), PortNumber ); 
            //        }
            //            catch(Exception)
            //        {
            //            OutputText = "Wrong IP number";
            //        }                     
            //        //_clientSocket.Connect(IPAddress.Loopback, PORT);
            //        /////////////////////////////////////////////////////
            //    }
            //    catch (SocketException)
            //    {
            //        OutputText = " Connection attempts: " + attemptsToConnect.ToString();
            //    }
            //    catch(InvalidOperationException)
            //    {
            //        OutputText = "Couldn't connect to the server";
            //        return;
            //    }
            //
            //}
            //IsConnected = true;
            //OutputText = "";
            ////ReceiveResponse();
            //OutputText += "ConnectedC ";
        }

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                _clientSocket.EndConnect(AR);
            }
            catch(SocketException)
            {
                OutputText = "Cannot connect to the server";
                return;
            }
            catch(ArgumentException)
            {
                OutputText = "Cannot connect to the server";
                return;
            }
            
            IsConnected = true;
            //ReceiveResponse();
            _clientSocket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), _clientSocket);
            OutputText = "ConnectedC";
        }

        public void SendString(string stringToSend)
        {
            byte[] outgoingBuffer = Encoding.ASCII.GetBytes(stringToSend);
            try
            {
                _clientSocket.Send(outgoingBuffer, 0, outgoingBuffer.Length, SocketFlags.None);
            }
            catch(SocketException)
            {
                //_clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();
                return;
            }
            catch(ObjectDisposedException)
            {
                CloseConnection();
                return;
            }
            
            //OutputText += " Message sent";
        }

        public void ReceiveResponse()
        {
            _clientSocket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), _clientSocket);    
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
                //_clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();
                return;
            }
            
            //Console.WriteLine("Message received");
            byte[] tempBuffer = new byte[received];
            Array.Copy(incomingBuffer, tempBuffer, received);
            string text = Encoding.ASCII.GetString(tempBuffer);
            OutputText += ("R:" + text);
            socket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        public static bool ValidateIPV4(string ipString)
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

            byte byteTester;
            return splitIP.All(splitNumber => byte.TryParse(splitNumber, out byteTester));
        }
        public void CloseConnection()
        {
            IsConnected = false;
            OutputText = "Connection lost";
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
