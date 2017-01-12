using System;
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
using System.Net;

namespace RatClientApplication
{
    public partial class FormRat : Form
    {
        Keys[] keysPressed = new Keys[4];
        private bool keyDownPressed = false;
        private bool keyUpPressed = false;
        private bool keyLeftPressed = false;
        private bool keyRightPressed = false;

        RobotData robotData = new RobotData();
        // Interesting thing. When you connect UDP after TCP, TCP gets autoamtically connected with whatever
        IPClient tcpClient = new IPClient();
        ImageDisplay imageHandler = new ImageDisplay(300, 175);
        UDPServer udpServer;

        //private ColorfulProgressBar batteryProgressBar;
        private ProgressBarController batteryController;
        private OutgoingMessage outgoingMessage;
        private OutgoingMessage outgoingParameters;

        private IncomingMessage incomingMessage;
        private IncomingMessage incomingParameters;
        private bool isUltrasoundPlaying = false;
        private int currentOutgoingFrequency;

        public FormRat()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer100.Enabled = true;
            //incomingMessage = new IncomingMessage();
            //timer3000.Enabled = true;
            incomingParameters = new IncomingMessage();
            outgoingParameters = new OutgoingMessage();
            //ResolveIncomingMessage(incomingMessage);
            //batteryProgressBar = new ColorfulProgressBar(new Point(30, 90), Color.Yellow);
            //this.Controls.Add(batteryProgressBar);
            batteryController = new ProgressBarController(batteryProgressBar);
            this.Text = "Rat application";
            this.KeyPreview = true;
            linearSpeedHScrollBar.Value = robotData.LinearSpeed1 = 123;
            angularSpeedHScrollBar.Value = robotData.AngularSpeed1 = 30;
            ipTextBox.Text = "192.168.1.3";
            portTextBox.Text = "50000";
            imageHandler.ImageReceived += ImageToDisplay_ImageReceived;
            tcpClient.MessageReceived += TcpClient_MessageReceived;
            udpServer = new UDPServer(imageHandler);
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
            incomingParameters = incomingMessage;
            pheromoneProgressBar.Value = (int)(10 * incomingParameters.incoming_pheromones.stress_pheromone_volume_left);
            pheromoneLeftLabel.Text = incomingParameters.incoming_pheromones.stress_pheromone_volume_left.ToString() + " ml";
            //robotData.mode = (RobotData.RobotMode)incomingParameters.mode;
            UpdateBatteryProgressBar();
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
                robotData.LinearDirection = 1;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Down && !keyDownPressed)
            {
                keyDownPressed = true;
                downBox.BackColor = Color.Green;
                robotData.LinearDirection = -1;
                if (keyLeftPressed || keyRightPressed)
                {
                    robotData.RotationDirection *= -1;
                }
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Left && !keyLeftPressed)
            {
                keyLeftPressed = true;
                leftBox.BackColor = Color.Green;
                robotData.RotationDirection = -1;
                if (robotData.LinearDirection < 0)
                {
                    robotData.RotationDirection *= -1;
                }
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Right && !keyRightPressed)
            {
                keyRightPressed = true;
                rightBox.BackColor = Color.Green;
                robotData.RotationDirection = 1;
                if (robotData.LinearDirection < 0)
                {
                    robotData.RotationDirection *= -1;
                }
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Space)
            {
                robotData.LinearDirection = 0;
                robotData.RotationDirection = 0;
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
                robotData.LinearDirection = 0;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Down)
            {
                keyDownPressed = false;
                downBox.BackColor = Color.Gray;
                robotData.LinearDirection = 0;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Left)
            {
                keyLeftPressed = false;
                leftBox.BackColor = Color.Gray;
                robotData.RotationDirection = 0;
                SendOutgoingMessage();
            }
            if (e.KeyData == Keys.Right)
            {
                keyRightPressed = false;
                rightBox.BackColor = Color.Gray;
                robotData.RotationDirection = 0;
                SendOutgoingMessage();
            }
            UpdateForm();
        }

        private void speedHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            
            robotData.LinearSpeed1 = linearSpeedHScrollBar.Value;
            UpdateForm();
        }

        private void angularSpeedHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            robotData.AngularSpeed1 = angularSpeedHScrollBar.Value;
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
            linearSpeedLabel2.Text = robotData.LinearSpeed.ToString();
            angularSpeedLabel2.Text = robotData.RotationSpeed.ToString();
            linearSpeedLabel1.Text = robotData.LinearSpeed1.ToString();
            angularSpeedLabel1.Text = robotData.AngularSpeed1.ToString();
            UpdatePheromoneReleaseLabel();
            UpdateFrequencyLabel();
            UpdateTimeSoundLabel();
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
            batteryController.Voltage = incomingParameters.battery_state.percentage;
            batteryController.CalculateValues();
            batteryProgressBar.Update();
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
                outputTCPTextBox.Text = "You must be connected to control the robot";
            }
        }

        private void PrepareOutgoingMessage()
        {
            outgoingParameters.speed.linear = robotData.LinearSpeed;
            outgoingParameters.speed.angular = robotData.RotationSpeed;
            outgoingParameters.mode = (int)robotData.Mode;
            outgoingParameters.camera.address.ip = Dns.GetHostAddresses(Dns.GetHostName()).ToString();
            outgoingParameters.camera.address.port = tcpClient.PortNumber;
            outgoingParameters.camera.should_stream = true;

            outgoingMessage = outgoingParameters;
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

        private void manualModeButton_Click(object sender, EventArgs e)
        {
            robotData.Mode = RobotData.RobotMode.Manual;
            ResolveRobotMode();
        }

        private void automaticModeButton_Click(object sender, EventArgs e)
        {
            robotData.Mode = RobotData.RobotMode.Automatic;
            ResolveRobotMode();
        }

        private void randomMovingButton_Click(object sender, EventArgs e)
        {
            robotData.Mode = RobotData.RobotMode.Random;
            ResolveRobotMode();
        }

        private void ResolveRobotMode()
        {
            SendOutgoingMessage();
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
            //UpdateBatteryProgressBar();
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

        private void EnableModeButtons(bool enable)
        {
            automaticModeButton.Enabled = enable;
            manualModeButton.Enabled = enable;
            randomMovingButton.Enabled = enable;
        }

        private void advancedIPOptionsButton_Click(object sender, EventArgs e)
        {
            advancedIPGroupBox.Visible = true;
        }

        private void hideAdvancedIPOptionsButton_Click(object sender, EventArgs e)
        {
            advancedIPGroupBox.Visible = false;
        }

        private void pheromoneReleaseScrollbar_ValueChanged(object sender, EventArgs e)
        {
            UpdatePheromoneReleaseLabel();

        }

        private void UpdatePheromoneReleaseLabel()
        {
            pheromoneReleaseLabel.Text = (pheromoneReleaseScrollbar.Value * 0.1f).ToString() + " ml";
        }

        private void frequencyScrollbar_ValueChanged(object sender, EventArgs e)
        {
            UpdateFrequencyLabel();
        }

        private void UpdateFrequencyLabel()
        {
            switch (frequencyScrollbar.Value)
            {
                case 0:
                    frequencyLabel.Text = "5kHz";
                    currentOutgoingFrequency = 5000;
                    break;
                case 1:
                    frequencyLabel.Text = "8kHz";
                    currentOutgoingFrequency = 8000;
                    break;
                case 2:
                    frequencyLabel.Text = "10kHz";
                    currentOutgoingFrequency = 10000;
                    break;
                case 3:
                    frequencyLabel.Text = "20kHz";
                    currentOutgoingFrequency = 20000;
                    break;
                case 4:
                    frequencyLabel.Text = "40kHz";
                    currentOutgoingFrequency = 40000;
                    break;
                default:
                    break;
            }
        }

        private void timeSoundScrollbar_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimeSoundLabel();
        }

        private void UpdateTimeSoundLabel()
        {
            timeSoundLabel.Text = (timeSoundScrollbar.Value * 0.1f).ToString() + " s";
            if (timeSoundScrollbar.Value == 0)
                startImpulseButton.Enabled = false;
            else
                startImpulseButton.Enabled = true;
        }

        private void startExtractingScentButton_Click(object sender, EventArgs e)
        {
            if (pheromoneReleaseScrollbar.Value > 0)
            {
                outgoingParameters.pheromones.stress_pheromone_volume_out = pheromoneReleaseScrollbar.Value * 1.0f;
                SendOutgoingMessage();
                pheromoneReleaseScrollbar.Value = 0;
            }
        }

        private void startPlayingSoundButton_Click(object sender, EventArgs e)
        {
            if (!isUltrasoundPlaying)
            {
                outgoingParameters.ultrasound.frequency = currentOutgoingFrequency;
                isUltrasoundPlaying = true;
            }
            else
            {
                outgoingParameters.ultrasound.frequency = 0;
                isUltrasoundPlaying = false;
                timerSound.Enabled = false;
            }
            SendOutgoingMessage();
            UpdateStartSoundButton();
        }

        private void startImpulseButton_Click(object sender, EventArgs e)
        {
            outgoingParameters.ultrasound.frequency = currentOutgoingFrequency;
            SendOutgoingMessage();
            timerSound.Interval = 100 * timeSoundScrollbar.Value;
            timerSound.Enabled = true;
            isUltrasoundPlaying = true;
            UpdateStartSoundButton();
        }

        private void soundTimer_Tick(object sender, EventArgs e)
        {
            outgoingParameters.ultrasound.frequency = 0;
            SendOutgoingMessage();
            timerSound.Enabled = false;
            isUltrasoundPlaying = false;
            UpdateStartSoundButton();
        }

        private void UpdateStartSoundButton()
        {
            if (!isUltrasoundPlaying)
            {
                startPlayingSoundButton.Text = "Start continuous sound";
                startImpulseButton.Enabled = true;
            }
            else
            {
                startPlayingSoundButton.Text = "Stop continuous sound";
                startImpulseButton.Enabled = false;
            }
        }

        private void pheromoneReleaseScrollbar_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void frequencyScrollbar_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void timeSoundScrollbar_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
