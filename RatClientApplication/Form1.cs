﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace RatClientApplication
{
    public partial class FormRat : Form
    {
        Keys[] keysPressed = new Keys[4];
        private bool keyDownPressed = false;
        private bool keyUpPressed = false;
        private bool keyLeftPressed = false;
        private bool keyRightPressed = false;

        DirectionData directions = new DirectionData();
        // Interesting thing. When you connect UDP after TCP, TCP gets autoamtically connected with whatever
        IPClient tcpClient = new IPClient();
        ImageDisplay imageHandler = new ImageDisplay(300, 175);
        UDPServer udpServer;

        private ColorfulProgressBar progressBar;
        private ProgressBarController batteryController;
        private int outgoingMode;
        private Speed outgoingSpeed;
        private bool panic;
        private Camera outgoingCamera;
        private bool shouldStream;
        private CameraAddress outgoingCameraAddress;
        private Pheromones outgoingPhermonoes;
        private float stress_pheromone_volume_out;
        private Ultrasound outgoingUltrasound;
        private int frequency;
        private OutgoingMessage outgoingMessage;
        private OutgoingMessage outgoingParameters;
        //private string incomingDiagnostics;
        //private int incomingMode;
        //private Battery_state incomingBattery_state;
        //private int percentage;
        //private IncomingPheromones incoming_pheromones;
        //private float stress_pheromone_volume_left;
        private IncomingMessage incomingMessage;
        private IncomingMessage incomingParameters;

        public FormRat()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer100.Enabled = true;

            timer3000.Enabled = true;
            progressBar = new ColorfulProgressBar(new Point(30, 90), Color.Yellow);
            this.Controls.Add(progressBar);
            batteryController = new ProgressBarController(progressBar);
            this.Text = "Rat application";
            this.KeyPreview = true;
            linearSpeedHScrollBar.Value = directions.LinearSpeed1 = 123;
            angularSpeedHScrollBar.Value = directions.AngularSpeed1 = 30;
            ipTextBox.Text = "192.168.1.3";
            portTextBox.Text = "50000";
            imageHandler.ImageReceived += ImageToDisplay_ImageReceived;
            tcpClient.MessageReceived += TcpClient_MessageReceived;
            udpServer = new UDPServer(imageHandler);
            //outgoingMode = 32;
            //outgoingSpeed = new Speed(panic, directions.LinearSpeed, directions.RotationSpeed);
            //outgoingCameraAddress = new CameraAddress(udpServer.IpAddress, udpServer.PortNumber);
            //outgoingCamera = new Camera(shouldStream, outgoingCameraAddress);
            //outgoingPhermonoes = new Pheromones(stress_pheromone_volume_out);
            //outgoingUltrasound = new Ultrasound(frequency);
            //outgoingMessage = new OutgoingMessage(outgoingMode, outgoingSpeed, outgoingCamera, outgoingPhermonoes, outgoingUltrasound);

            //incomingBattery_state = new Battery_state(percentage);
            //incoming_pheromones = new IncomingPheromones(stress_pheromone_volume_left);
            //incomingMessage = new IncomingMessage(incomingDiagnostics, incomingMode, incomingBattery_state, incoming_pheromones);
            incomingParameters = new IncomingMessage();
            outgoingParameters = new OutgoingMessage();
            UpdateForm();
        }

        private void TcpClient_MessageReceived(object sender, EventArgs e)
        {
            //Here might be problem with the instance of IncomingMessage
            incomingMessage = JsonConvert.DeserializeObject<IncomingMessage>(tcpClient.IncomingText);
            ResolveIncomingMessage(incomingMessage);

        }

        private void ResolveIncomingMessage(IncomingMessage incomingMessage)
        {
            incomingParameters.diagnostics = incomingMessage.diagnostics;
            incomingParameters.mode = incomingMessage.mode;
            incomingParameters.battery_state = incomingMessage.battery_state;
            incomingParameters.incoming_pheromones = incomingMessage.incoming_pheromones;
        }

        private void ImageToDisplay_ImageReceived(object sender, EventArgs e)
        {
            imageHandler.AddImage(udpServer.JpegImageBytes);
            displayImage(udpServer.ImageBitMap);
            udpServer.OutputText = String.Format("Images displayed: {0}", imageHandler.GetCountOfImages());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //inputTextBox.Text += "Down Event";
            UpdateForm();
            if(e.KeyData==Keys.Up && !keyUpPressed)
            { 
                keyUpPressed = true;
                upBox.BackColor = Color.Green;
                directions.LinearDirection = 1;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Down && !keyDownPressed)
            {
                keyDownPressed = true;
                downBox.BackColor = Color.Green;
                directions.LinearDirection = -1;
                if (keyLeftPressed || keyRightPressed)
                {
                    directions.RotationDirection *= -1;
                }
                SendOutgoingMessage();
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
                SendOutgoingMessage();
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
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Space)
            {
                directions.LinearDirection = 0;
                directions.RotationDirection = 0;
                PanicStop();
            }
            UpdateForm();
        }

        private void PanicStop()
        {
            outgoingParameters.speed.panic = true;
            SendOutgoingMessage();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //inputTextBox.Text += "Up Event";
            UpdateForm();
            if (e.KeyData == Keys.Up)
            {
                keyUpPressed = false;
                upBox.BackColor = Color.Gray;
                directions.LinearDirection = 0;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Down)
            {
                keyDownPressed = false;
                downBox.BackColor = Color.Gray;
                directions.LinearDirection = 0;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Left)
            {
                keyLeftPressed = false;
                leftBox.BackColor = Color.Gray;
                directions.RotationDirection = 0;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Right)
            {
                keyRightPressed = false;
                rightBox.BackColor = Color.Gray;
                directions.RotationDirection = 0;
                SendOutgoingMessage();
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

        private void UpdateBatteryProgressBar()
        {
            //batteryController.Voltage = tcpClient.IncomingParams.voltage;
            batteryController.Voltage = incomingParameters.battery_state.percentage;
            batteryController.CalculateValues();
            progressBar.Update();
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
            tcpClient.OutputText = "";
            outputTCPTextBox.Clear();
        }
        
        private void SendOutgoingMessage()
        {
            PrepareOutgoingMessage();
            if (tcpClient.IsConnected)
            {
                string jsonSpeed = JsonConvert.SerializeObject(outgoingMessage);
                //client.SendString(String.Format("{0} {1}", directions.LinearSpeed, directions.RotationSpeed));
                tcpClient.SendString(jsonSpeed);
            }
            else
            {
                outputTCPTextBox.Text = "You must be connected to steer the robot";
            }
        }

        private void PrepareOutgoingMessage()
        {
            outgoingMessage = new OutgoingMessage();
            outgoingMessage.speed.linear = directions.LinearSpeed;
            outgoingMessage.speed.angular = directions.RotationSpeed;
            outgoingMessage.speed.panic = outgoingParameters.speed.panic;

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
                udpServer.IpAddress = ipTextBox.Text;
                //                udpClient.PortNumber = int.Parse(portTextBox.Text);
                outputTCPTextBox.Text = "Correct format of IPAddres and Port number. Ready to connect.";
            }
        }

        private void automaticModeButton_Click(object sender, EventArgs e)
        {

        }

        private void manualModeButton_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void randomMovingButton_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            outputTCPTextBox.Text = "User pressed disconnect button";
            tcpClient.CloseConnection();
        }

        private void displayImage(Bitmap imageToDisplay)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)imageToDisplay;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            outputTCPTextBox.Text = tcpClient.OutputText;
            outputUDPTextBox.Text = udpServer.OutputText + imageHandler.OutputText;
            //if (imageHandler.OutputText.Length > 0)
            //    outputUDPTextBox.Text = imageHandler.OutputText;
            disconnectButton.Enabled = !connectButton.Enabled;

            UpdateForm();
            //if (progressBar.Value > 0)
            //    progressBar.Value--;
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
            UpdateBatteryProgressBar();
        }

        private void saveVideoButton_Click(object sender, EventArgs e)
        {
            if (udpServer.ContinueSavingAndDisplayingImages)
                MessageBox.Show("Stop streaming before you save frames");
            else
                imageHandler.SaveAllImages();
        }

        private void continueStreamingButton_Click(object sender, EventArgs e)
        {
            if (udpServer.ContinueSavingAndDisplayingImages)
            {
                udpServer.ContinueSavingAndDisplayingImages = false;
                continueStreamingButton.Text = "Resume streaming";
            }
            else
            {
                udpServer.ContinueSavingAndDisplayingImages = true;
                continueStreamingButton.Text = "Stop streaming";
            }
        }

        private void panicStopButton_Click(object sender, EventArgs e)
        {
            PanicStop();
        }
    }
}
