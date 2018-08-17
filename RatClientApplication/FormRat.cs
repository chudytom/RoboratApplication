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
using System.Net.Sockets;
using RatClientApplication.Detection;
using System.Diagnostics;
using RatClientApplication.DesignatedPath;
//using TCPConnection;

namespace RatClientApplication
{
    public partial class FormRat : Form
    {
        private bool keyDownPressed = false;
        private bool keyUpPressed = false;
        private bool keyLeftPressed = false;
        private bool keyRightPressed = false;
        private RobotData robotData = new RobotData();
        private TCPConnection.TCPlient client;
        //private TCPlient tcpClient = new TCPlient();
        private ImageDisplay imageHandler = new ImageDisplay(300, 175);
        private string ipAddress;
        private int portNumber;
        private RatTracker ratTracker;
        private UDPServer udpServer;
        private ProgressBarController batteryController;
        private ComputerToRoboRatMessage outgoingMessage;
        private ComputerToRoboRatMessage outgoingParameters;
        private RoboRatToComputerMessage incomingMessage;
        private RoboRatToComputerMessage incomingParameters;
        private bool isUltrasoundPlaying = false;
        private int currentOutgoingFrequency;
        public event Action DiagnosticsMessageReceived;

        public FormRat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            incomingParameters = new RoboRatToComputerMessage();
            outgoingParameters = new ComputerToRoboRatMessage();
            batteryController = new ProgressBarController(batteryProgressBar);
            this.Text = "Rat application";
            this.KeyPreview = true;
            ipTextBox.Text = "192.168.1.3";
            portTextBox.Text = "50000";
            //portTextBox.Text = "10";
            //ipTextBox.Text = "192.168.1.3";
            IpConfiguration();
            DiagnosticsMessageReceived += OnDiagnosticsMessageReceived;
            //client = new TCPConnection.TCPlient(portNumber, ipAddress);
            //udpServer = new UDPServer(imageHandler, portNumber);
            imageHandler.ImageReceived += ImageToDisplay_ImageReceived;
            //tcpClient.MessageReceived += TcpClient_MessageReceived;
            client.MessageReceived += TcpClient_MessageReceived;
            batteryProgressBar.Value = 0;
            pheromoneProgressBar.Value = 0;
            incomingParameters.incoming_pheromones.stress_pheromone_volume_left = 0.0f;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ratTracker = GetRatTrackerWithBasicHsvLimits();
            linearSpeedHScrollBar.Value = robotData.LinearSpeed1 = 123;
            angularSpeedHScrollBar.Value = robotData.AngularSpeed1 = 30;
            UpdateForm();
        }


        private RatTracker GetRatTrackerWithBasicHsvLimits()
        {
            return new RatTracker(lowerHSVLimit: new Emgu.CV.Structure.Hsv(13, 210, 144),
                                    upperHSVLimit: new Emgu.CV.Structure.Hsv(36, 231, 217));
        }

        private void TcpClient_MessageReceived(object sender, EventArgs e)
        {
            try
            {
                //udpServer.OutputText = tcpClient.IncomingText;
                //incomingMessage = JsonConvert.DeserializeObject<IncomingMessage>(tcpClient.IncomingText);
                incomingMessage = JsonConvert.DeserializeObject<RoboRatToComputerMessage>(client.IncomingText);
            }
            catch (Exception ex)
            {
                client.OutputText = ex.Message;
                //tcpClient.OutputText = ex.Message;
                //outputTCPTextBox.Text = "Something wrong with JSON " /*+ ex.Message*/;
                return;
            }
            //incomingMessage = JsonConvert.DeserializeObject<IncomingMessage>(tcpClient.IncomingText);
            udpServer.OutputText = client.IncomingText;
            ResolveIncomingMessage(incomingMessage);

        }

        private void ResolveIncomingMessage(RoboRatToComputerMessage incomingMessage)
        {
            if (incomingMessage != null)
            {
                incomingParameters = incomingMessage;
                //udpServer.OutputText += JsonConvert.SerializeObject(incomingMessage);
                //pheromoneProgressBar.Value = (int)(10 * incomingParameters.incoming_pheromones.stress_pheromone_volume_left);
                // pheromoneLeftLabel.Text = incomingParameters.incoming_pheromones.stress_pheromone_volume_left.ToString() + " ml";
                CheckForDiagnosticsParameters();
                UpdateIncomingPheromones();
                UpdateBatteryProgressBar();
                UpdateForm();
            }
        }

        private void CheckForDiagnosticsParameters()
        {
            if (!string.IsNullOrWhiteSpace(incomingParameters.diagnostics))
                DiagnosticsMessageReceived();
        }

        private void OnDiagnosticsMessageReceived()
        {
            udpServer.OutputText += $" Diagnostics message: {incomingParameters.diagnostics}";
        }

        private void UpdateIncomingPheromones()
        {
            pheromoneProgressBar.Value = (int)(10 * incomingParameters.incoming_pheromones.stress_pheromone_volume_left);
            pheromoneLeftLabel.Text = (incomingParameters.incoming_pheromones.stress_pheromone_volume_left * 1.0f).ToString("0.0") + " ml";
        }

        private void UpdateBatteryProgressBar()
        {
            batteryController.Voltage = incomingParameters.battery_state.percentage;
            batteryController.ResolveColor();
            batteryProgressBar.Value = incomingParameters.battery_state.percentage;
            batteryProgressBar.Update();
        }

        private void ImageToDisplay_ImageReceived(object sender, EventArgs e)
        {
            imageHandler.AddImage(udpServer.JpegImageBytes);
            if (robotData.Mode == RobotData.RobotMode.Automatic)
            {
                Point detectedRatPosition = ratTracker.PerformDetection(udpServer.ImageBitMap);
                displayImage(ratTracker.GetOriginalImage());
                outgoingParameters.camera.detected_position.x = detectedRatPosition.X;
                outgoingParameters.camera.detected_position.y = detectedRatPosition.Y;
                SendOutgoingMessage();
            }
            else
                displayImage(udpServer.ImageBitMap);
            //udpServer.OutputText = String.Format("Images displayed: {0}", imageHandler.GetCountOfImages());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateForm();
            if (e.KeyData == Keys.Up && !keyUpPressed)
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
                robotData.RotationDirection = 1;//
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
                robotData.RotationDirection = -1;
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
            robotData.Mode = RobotData.RobotMode.Manual;
            SendOutgoingMessage();
            outgoingParameters.speed.panic = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
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
            linearSpeedLabel2.Text = ((int)(robotData.LinearSpeed * 0.4)).ToString();
            angularSpeedLabel2.Text = ((int)(robotData.RotationSpeed * 2.5)).ToString();
            linearSpeedLabel1.Text = ((int)(robotData.LinearSpeed1 * 0.4)).ToString();
            angularSpeedLabel1.Text = ((int)(robotData.AngularSpeed1 * 2.5)).ToString();
            UpdatePheromoneReleaseLabel();
            UpdateFrequencyLabel();
            UpdateTimeSoundLabel();
            UpdateConnectionLabels();
            UpdateBatteryProgressBar();
            UpdateIncomingPheromones();
            outputTCPTextBox.Text = client.OutputText;
            outputUDPTextBox.Text = udpServer.OutputText + imageHandler.OutputText;
        }

        private void UpdateConnectionLabels()
        {
            if (client.IsConnected)
            {
                tcpConnectionLabel.BackColor = Color.Green;
                tcpConnectionLabel.Text = "ON";
                outputTCPTextBox.Text = "Connected";
            }
            else
            {
                tcpConnectionLabel.BackColor = Color.Red;
                tcpConnectionLabel.Text = "OFF";
                outputTCPTextBox.Text = "Disconnected";
            }
        }



        private void connectButton_Click(object sender, EventArgs e)
        {
            IpConfiguration();
            angularSpeedHScrollBar.Focus();
            //tcpClient.Start();
            client.StartConnection();
            //if (!udpServer.IsConnected)
            //{
            udpServer.Start();
            //}
            timer100.Enabled = true;
            timer3000.Enabled = true;
            UpdateForm();
            SendOutgoingMessage();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            angularSpeedHScrollBar.Focus();
            client.OutputText = "";
            outputTCPTextBox.Clear();
        }

        private void SendOutgoingMessage()
        {
            PrepareOutgoingMessage();
            if (client.IsConnected)
            {
                string jsonMessage = JsonConvert.SerializeObject(outgoingMessage);
                //udpServer.OutputText = jsonSpeed;
                //jsonSpeed = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, " +
                //    "suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. " +
                //"Phasellus pharetra nulla ac diam. Quisque semper justo at risus. ";
                client.SendString(jsonMessage);
            }
            else
            {
                return;
            }
        }

        private void PrepareOutgoingMessage()
        {
            outgoingParameters.speed.linear = robotData.LinearSpeed;
            outgoingParameters.speed.angular = robotData.RotationSpeed;
            outgoingParameters.mode = (int)robotData.Mode;
            //outgoingParameters.camera.address.ip = Dns.GetHostAddresses(Dns.GetHostName()).ToString();
            //outgoingParameters.camera.address.port = tcpClient.PortNumber;
            outgoingParameters.camera.should_stream = udpServer.ContinueSavingAndDisplayingImages;
            //outgoingParameters.camera.address.ip = (Dns.GetHostAddresses(Dns.GetHostName())).ToString();
            outgoingParameters.camera.address.ip = GetLocalIPAddress();
            outgoingParameters.camera.address.port = udpServer.PortNumber;
            outgoingMessage = outgoingParameters;
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void setIPButton_Click(object sender, EventArgs e)
        {
            angularSpeedHScrollBar.Focus();
            IpConfiguration();
        }

        private void IpConfiguration()
        {
            string ipString = ipTextBox.Text;
            string portNumberString = portTextBox.Text;
            if (ipString == "raspberrypi.local" || ipString == "localhost")
            {
                PrepareConnection();
                return;
            }
            if (ipTextBox.Text.Contains(" ") || portTextBox.Text.Contains(" "))
            {
                outputTCPTextBox.Text = "There are white spaces in IPAddress or Port number";
                return;
            }

            if (!TCPlient.IsIPFormatCorrect(ipString))
            {
                outputTCPTextBox.Text = "Incorrect IP Address";
                return;
            }
            if (string.IsNullOrWhiteSpace(portNumberString))
            {
                outputTCPTextBox.Text = "Incorrect Port number";
                return;
            }
            else
            {
                PrepareConnection();
                //tcpClient.IP = ipAddress;
                //tcpClient.PortNumber = portNumber;
                //udpServer.IpAddress = ipAddress;
                //udpServer.PortNumber = portNumber + 100;
            }
        }

        private void PrepareConnection()
        {
            ipAddress = ipTextBox.Text;
            portNumber = int.Parse(portTextBox.Text);
            client = new TCPConnection.TCPlient(portNumber, ipAddress);
            udpServer = new UDPServer(imageHandler, portNumber);
            connectButton.Enabled = true;
            outputTCPTextBox.Text = "Correct format of IPAddres and Port number. Ready to connect.";
        }

        private void manualModeButton_Click(object sender, EventArgs e)
        {
            if (!VerifyConnection())
                return;
            robotData.Mode = RobotData.RobotMode.Manual;
            angularSpeedHScrollBar.Focus();
            ResolveRobotMode();
        }

        private void automaticModeButton_Click(object sender, EventArgs e)
        {
            if (!VerifyConnection())
                return;
            angularSpeedHScrollBar.Focus();
            OnAutomaticModeSelected();
            ResolveRobotMode();
        }

        private void randomMovingButton_Click(object sender, EventArgs e)
        {
            if (!VerifyConnection())
                return;
            robotData.Mode = RobotData.RobotMode.Random;
            angularSpeedHScrollBar.Focus();
            ResolveRobotMode();
        }

        private void designatedPathModeButton_Click(object sender, EventArgs e)
        {
            OnDesignatedPathModeSelected();
        }

        private void OnDesignatedPathModeSelected()
        {
            if (!VerifyConnection())
                return;
            robotData.Mode = RobotData.RobotMode.Manual;
            angularSpeedHScrollBar.Focus();
            ResolveRobotMode();
            var designatedPathForm = new DesignatedPathForm();
            designatedPathForm.ExecutePathRequested += DesignatedPathForm_ExecutePathRequested;
            designatedPathForm.ShowDialog();
        }

        private bool VerifyConnection()
        {
            if (client.IsConnected)
                return true;
            else
            {
                MessageBox.Show("First, you need to be connected to the robot");
                return false;
            }
        }

        private async void DesignatedPathForm_ExecutePathRequested(object sender, EventArgs e)
        {
            var pathElements = sender as List<PathElement>;
            var enumerator = pathElements.GetEnumerator();
            foreach (var element in pathElements)
            {
                ExecutePathElement(element);
                await PutTaskDelay((int)element.Time);
                SendClearedDataToRobot();
                await PutTaskDelay(20);
            }
        }

        async Task PutTaskDelay(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }

        private void ExecutePathElement(PathElement pathElement)
        {
            robotData.LinearSpeed1 = (int)pathElement.Speed;
            robotData.AngularSpeed1 = (int)pathElement.Speed;
            switch (pathElement.PathDirection)
            {
                case PathElement.DirectionEnum.Wait:
                    robotData.LinearDirection = 0;
                    robotData.RotationDirection = 0;
                    break;
                case PathElement.DirectionEnum.Forward:
                    robotData.LinearDirection = 1;
                    upBox.BackColor = Color.Green;
                    break;
                case PathElement.DirectionEnum.Backward:
                    robotData.LinearDirection = -1;
                    downBox.BackColor = Color.Green;
                    break;
                case PathElement.DirectionEnum.Left:
                    robotData.RotationDirection = 1;
                    leftBox.BackColor = Color.Green;
                    break;
                case PathElement.DirectionEnum.Right:
                    robotData.RotationDirection = -1;
                    rightBox.BackColor = Color.Green;
                    break;
                default:
                    break;
            }

            SendOutgoingMessage();

        }

        private void SendClearedDataToRobot()
        {
            upBox.BackColor = Color.Gray;
            downBox.BackColor = Color.Gray;
            leftBox.BackColor = Color.Gray;
            rightBox.BackColor = Color.Gray;
            robotData.LinearDirection = 0;
            robotData.RotationDirection = 0;
            robotData.LinearSpeed1 = 0;
            robotData.AngularSpeed1 = 0;
            SendOutgoingMessage();
        }

        private void OnAutomaticModeSelected()
        {
            DialogResult messageBoxResult = MessageBox.Show(
                "Do you want to calibrate the detection?", "Detection choice",
                MessageBoxButtons.YesNo);
            if (messageBoxResult == DialogResult.Yes)
            {
                //pictureBox1.Image = new Bitmap(@"C: \Users\tomasz123456\Desktop\Muka1.png");
                pictureBox1.Image = new Bitmap(@"D:\OneDrive\Szczur\Zdjecia Testy\Test2\116.jpeg");
                if (pictureBox1.Image is null)
                {
                    MessageBox.Show(@"There is no image in the PictureBox. Make sure you started streaming the video", "Calibration error");
                    return;
                }
                else
                {
                    Bitmap img = new Bitmap(pictureBox1.Image);
                    udpServer.ImageBitMap = img;
                    DetectionCalibrator calibrator = new DetectionCalibrator(udpServer.ImageBitMap);
                    CalibrationForm calibrationForm = new CalibrationForm(calibrator);
                    DialogResult formResult = calibrationForm.ShowDialog();
                    if (formResult == DialogResult.OK)
                    {
                        //ratTracker = new RatTracker(calibrator.LowerHSVLimit, calibrator.UpperHSVLimit); 
                        ratTracker.LowerHSVLimit = calibrator.LowerHSVLimit;
                        ratTracker.UpperHSVLimit = calibrator.UpperHSVLimit;
                    }
                }
            }
            robotData.Mode = RobotData.RobotMode.Automatic;
        }

        private void ResolveRobotMode()
        {
            SendOutgoingMessage();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            outputTCPTextBox.Text = "User pressed disconnect button";
            udpServer.ContinueSavingAndDisplayingImages = false;
            SendOutgoingMessage();
            client.CloseConnection();
            udpServer.CloseConnection();
            angularSpeedHScrollBar.Focus();
        }

        private void displayImage(Bitmap imageToDisplay)
        {
            pictureBox1.Image = imageToDisplay;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            disconnectButton.Enabled = !connectButton.Enabled;
            UpdateForm();
        }

        private void timer3000_Tick(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                connectButton.Enabled = false;
            }
            else
            {
                connectButton.Enabled = true;
            }
            if (client.IsConnected)
            {
                try
                {
                    client.SendString("");
                }
                catch
                {
                    outputTCPTextBox.Text = "Connection lost (timer event)";
                    client.CloseConnection();
                    client.CloseConnection();
                }
            }
        }

        private void saveVideoButton_Click(object sender, EventArgs e)
        {
            angularSpeedHScrollBar.Focus();
            if (udpServer.ContinueSavingAndDisplayingImages)
                MessageBox.Show("Stop streaming before you save frames");
            else
                imageHandler.SaveAllImages();
        }

        private void continueStreamingButton_Click(object sender, EventArgs e)
        {
            angularSpeedHScrollBar.Focus();
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
            angularSpeedHScrollBar.Focus();
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
            angularSpeedHScrollBar.Focus();
            advancedIPGroupBox.Visible = true;

            //var outgoingMessage = new RoboRatToComputerMessage("Some diagnostics", 0, new BatteryState(80), new PheromonesVolumeLeft(2.0f));
            //string str = JsonConvert.SerializeObject(outgoingMessage);
            //client.IncomingText = str;
            //client.OnMessageReceived(EventArgs.Empty);
        }

        private void hideAdvancedIPOptionsButton_Click(object sender, EventArgs e)
        {
            angularSpeedHScrollBar.Focus();
            advancedIPGroupBox.Visible = false;
        }

        private void pheromoneReleaseScrollbar_ValueChanged(object sender, EventArgs e)
        {
            UpdatePheromoneReleaseLabel();

        }

        private void UpdatePheromoneReleaseLabel()
        {
            pheromoneReleaseLabel.Text = (pheromoneReleaseScrollbar.Value * 0.1f).ToString("0.0") + " ml";
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
            angularSpeedHScrollBar.Focus();
            if (pheromoneReleaseScrollbar.Value > 0)
            {
                SetPheromoneVolumeInMessage();
                SendOutgoingMessage();
                pheromoneReleaseScrollbar.Value = 0;
                SetPheromoneVolumeInMessage();
            }
        }

        private void SetPheromoneVolumeInMessage()
        {
            outgoingParameters.pheromones.stress_pheromone_volume_out = pheromoneReleaseScrollbar.Value * 0.1f;
        }

        private void startPlayingSoundButton_Click(object sender, EventArgs e)
        {
            angularSpeedHScrollBar.Focus();
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
            angularSpeedHScrollBar.Focus();
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
