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
    
    class IPClient
    {
        private Socket _clientSocket;
        public IPClient()
        {
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IncomingParams.voltage = 800;
        }
        public bool IsConnected { get; set; }
        public string IP { get; set; }
        public int PortNumber { get; set; }
        
        const int PORT = 100;
        const int BUFFER_SIZE = 1024;
        byte[] incomingBuffer = new byte[BUFFER_SIZE];
        public string OutputText { get; set; }    
        public string InputText { get; set; }
        public IncomingParameters IncomingParams;

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
                OutputText = "Couldn't  connect to the server (begin)";
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
                OutputText = "Cannot connect to the server (end, SocketException)";
                return;
            }
            catch(ArgumentException)
            {
                OutputText = "Cannot connect to the server(end, ArgumentException)";
                return;
            }
            if(_clientSocket.Connected)
            {
                IsConnected = true;
            }
            //ReceiveResponse();
            try
            {
                _clientSocket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), _clientSocket);
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
                OutputText = "Unable to send string (SocketException)";
                _clientSocket.Close();
                return;
            }
            catch(ObjectDisposedException)
            {
                OutputText = "Unable to send string (ObjectDisposedException)";
                CloseConnection();
                return;
            }
            
            //OutputText += " Message sent";
        }

       // public void ReceiveResponse()
       //{ 
       //     try
       //     {
       //         _clientSocket.BeginReceive(incomingBuffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveCallback), _clientSocket);
       //         Thread.Sleep(200);
       //     }
       //     catch (SocketException)
       //     {
       //         CloseConnection();
       //         InputText = "This error";
       //         OutputText = "This error";
       //         ConnectToServer();
       //         Thread.Sleep(3000);
       //         OutputText = "This error";
       //     }
       //     catch (Exception)
       //     {
       //         CloseConnection();
       //         OutputText = "Sudden connection lost";
       //     }
       // }

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
                OutputText = "Couldn't receive the message(SocketException)";
                _clientSocket.Close();
                return;
            }
            catch(ObjectDisposedException)
            {
                OutputText = "Couldn't receive the message(ObjDisposed)";
                CloseConnection();
                return;
            }
            
            //Console.WriteLine("Message received");
            byte[] tempBuffer = new byte[received];
            Array.Copy(incomingBuffer, tempBuffer, received);
            string text = Encoding.ASCII.GetString(tempBuffer);
            OutputText += ("R:" + text);
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
            _clientSocket.Close();
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public struct IncomingParameters
        {
            public int voltage;
            public DirectionData.RobotMode mode;
        }
    }
}
