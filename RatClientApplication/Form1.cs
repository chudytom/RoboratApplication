using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Directions;
using IP;
using UDP;
using Newtonsoft.Json;

namespace RatClientApplication
{
    public partial class Form1 : Form
    {
        private bool keyDownPressed = false;
        private bool keyUpPressed = false;
        private bool keyLeftPressed = false;
        private bool keyRightPressed = false;
        DirectionData directions = new DirectionData();
        // Interesting thing. When you connect UDP after TCP, TCP gets autoamtically connected with whatever
        IPClient tcpClient = new IPClient(IPClient.Protocol.TCP);
        ImageDisplay imageToDisplay = new ImageDisplay(300, 175);
        UDPServer udpServer;
        speed speedOfRat = new speed();
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            linearSpeedHScrollBar.Value = directions.LinearSpeed1 = 123;
            angularSpeedHScrollBar.Value = directions.AngularSpeed1 = 30;
            //ipTextBox.Text = "192.168.1.3";
            //portTextBox.Text = "50000"; 
            ipTextBox.Text = "192.168.0.108";
            portTextBox.Text = "100";
            imageToDisplay.ImageReceived += ImageToDisplay_ImageReceived;
            udpServer = new UDPServer(imageToDisplay);
            UpdateForm();
        }

        private void ImageToDisplay_ImageReceived(object sender, EventArgs e)
        {
            imageToDisplay.addImage(udpServer.ImageToDisplay);
            displayImage(udpServer.ImageToDisplay);
            udpServer.OutputText = String.Format("Images displayed: {0}", imageToDisplay.GetCountOfImages());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Up && !keyUpPressed)
            {
                keyUpPressed = true;
                upBox.BackColor = Color.Green;
                directions.LinearDirection = 1;
                UpdateForm();
                SendSpeed();
            }
            if (e.KeyData == Keys.Down && !keyDownPressed)
            {
                keyDownPressed = true;
                downBox.BackColor = Color.Green;
                directions.LinearDirection = -1;

                SendSpeed();
            }
            if (e.KeyData == Keys.Left && !keyLeftPressed)
            {
                keyLeftPressed = true;
                leftBox.BackColor = Color.Green;
                directions.RotationDirection = -1;
                if (directions.LinearDirection < 0)
                {
                    directions.RotationDirection *= -1;
                }
                SendSpeed();
            }
            if (e.KeyData == Keys.Right && !keyRightPressed)
            {
                keyRightPressed = true;
                rightBox.BackColor = Color.Green;
                directions.RotationDirection = 1;
                if (directions.LinearDirection < 0)
                {
                    directions.RotationDirection *= -1;
                }
                SendSpeed();
            }
            UpdateForm();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                keyUpPressed = false;
                upBox.BackColor = Color.Gray;
                directions.LinearDirection = 0;
                SendSpeed();
            }
            if (e.KeyData == Keys.Down)
            {
                keyDownPressed = false;
                downBox.BackColor = Color.Gray;
                directions.LinearDirection = 0;
                SendSpeed();
            }
            if (e.KeyData == Keys.Left)
            {
                keyLeftPressed = false;
                leftBox.BackColor = Color.Gray;
                directions.RotationDirection = 0;
                SendSpeed();
            }
            if (e.KeyData == Keys.Right)
            {
                keyRightPressed = false;
                rightBox.BackColor = Color.Gray;
                directions.RotationDirection = 0;
                SendSpeed();
            }
            UpdateForm();
            
        }

        private void speedHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            
            directions.LinearSpeed1 = linearSpeedHScrollBar.Value;
            UpdateForm();
        }

        private void angularSpeedHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            directions.AngularSpeed1 = angularSpeedHScrollBar.Value;
            UpdateForm();
        }

        private void speedHScrollBar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                e.IsInputKey = false;
            }
        }

        private void speedHScrollBar_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void angularSpeedHScrollBar_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void UpdateForm()
        {
            linearSpeedLabel2.Text = directions.LinearSpeed.ToString();
            angularSpeedLabel2.Text = directions.RotationSpeed.ToString();
            linearSpeedLabel1.Text = directions.LinearSpeed1.ToString();
            angularSpeedLabel1.Text = directions.AngularSpeed1.ToString();
            UpdateConnectionLabels();
        }

        private void UpdateConnectionLabels()
        {
            if (tcpClient.IsConnected)
            {
                tcpConnectionLabel.BackColor = Color.Green;
                tcpConnectionLabel.Text = "ON";
            }
            else
            {
                tcpConnectionLabel.BackColor = Color.Red;
                tcpConnectionLabel.Text = "OFF";
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            tcpClient.Start();
            if (!udpServer.IsConnected)
            {
                udpServer.Start();
            }
            timer100.Enabled = true;
            timer3000.Enabled = true;
            UpdateForm();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (tcpClient.IsConnected)
            {
                tcpClient.SendString(inputTextBox.Text);
            }

            else
            {
                outputTCPTextBox.Text = "You must be connected to send text";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTCPTextBox.Clear();
        }
        
        private void SendSpeed()
        {
            speedOfRat.linear = directions.LinearSpeed;
            speedOfRat.angular = directions.RotationSpeed;
            if(tcpClient.IsConnected)
            {
                string jsonSpeed = JsonConvert.SerializeObject(speedOfRat);
                //client.SendString(String.Format("{0} {1}", directions.LinearSpeed, directions.RotationSpeed));
                tcpClient.SendString(jsonSpeed);
            }
            else
            {
                outputTCPTextBox.Text = "You must be connected to steer the robot";
            }
        }

        private void setIPButton_Click(object sender, EventArgs e)
        {
            string ipString = ipTextBox.Text;
            string portNumberString = portTextBox.Text;
            if (ipTextBox.Text.Contains(" ") || portTextBox.Text.Contains(" "))
            {
                outputTCPTextBox.Text = "There are white spaces in IPAddress or Port number";
                return;
            }

            if (!IPClient.ValidateIPV4(ipString))
            {
                outputTCPTextBox.Text = "Incorrect IP Address";
                return;
            }
            if(string.IsNullOrWhiteSpace(portNumberString))
            {
                outputTCPTextBox.Text = "Incorrect Port number";
                return;
            }
            else
            {
                tcpClient.IP = ipTextBox.Text;
                tcpClient.PortNumber = int.Parse(portTextBox.Text);
                connectButton.Enabled = true;
                udpServer.PortNumber = int.Parse(portTextBox.Text) + 100;
//                udpClient.IP = ipTextBox.Text;
//                udpClient.PortNumber = int.Parse(portTextBox.Text);
                outputTCPTextBox.Text = "Correct format of IPAddres and Port number. Ready to connect.";
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            outputTCPTextBox.Text = "User pressed disconnect button";
            tcpClient.CloseConnection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            outputTCPTextBox.Text = tcpClient.OutputText;
            outputUDPTextBox.Text = udpServer.OutputText;
            disconnectButton.Enabled = !connectButton.Enabled;
            //if (udpServer.ImageToDisplay != null)
            //{
            //    displayImage(udpServer.ImageToDisplay);
            //}
            UpdateForm();
        }

        private void displayImage(Bitmap imageToDisplay)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)imageToDisplay;
        }

        private void timer3000_Tick(object sender, EventArgs e)
        {
            //client.SendString("test");
            if (tcpClient.IsConnected)
            {
                connectButton.Enabled = false;
            }
            else
            {
                connectButton.Enabled = true;
            }
            if (tcpClient.IsConnected)
            {
                try
                {
                    tcpClient.SendString("");
                }
                catch
                {
                    outputTCPTextBox.Text = "Connection lost (timer event)";
                    tcpClient.CloseConnection();
                }
            }
        }
    }
    public class speed
    {
        public int linear;
        public int angular;
    }
}
