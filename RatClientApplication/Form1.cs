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
using TCP;
//using System.Runtime.InteropServices;

namespace RatClientApplication
{
    public partial class Form1 : Form
    {
        DirectionData directions = new DirectionData();
        TCPClient client = new TCPClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            speedHScrollBar.Value = directions.Speed = 123;
            UpdateForm();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Up)
            {
                upBox.BackColor = Color.Green;
                directions.LinearDirection = 1;
                UpdateForm();
                SendSpeed();
            }
            if (e.KeyData == Keys.Down)
            {
                downBox.BackColor = Color.Green;
                directions.LinearDirection = -1;
                SendSpeed();
            }
            if (e.KeyData == Keys.Left)
            {
                leftBox.BackColor = Color.Green;
                directions.RotationDirection = -1;
                SendSpeed();
            }
            if (e.KeyData == Keys.Right)
            {
                rightBox.BackColor = Color.Green;
                directions.RotationDirection = 1;
                SendSpeed();
            }
            UpdateForm();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                upBox.BackColor = Color.Gray;
                directions.LinearDirection = 0;
                SendSpeed();
            }
            if (e.KeyData == Keys.Down)
            {
                downBox.BackColor = Color.Gray;
                directions.LinearDirection = 0;
                SendSpeed();
            }
            if (e.KeyData == Keys.Left)
            {
                leftBox.BackColor = Color.Gray;
                directions.RotationDirection = 0;
                SendSpeed();
            }
            if (e.KeyData == Keys.Right)
            {
                rightBox.BackColor = Color.Gray;
                directions.RotationDirection = 0;
                SendSpeed();
            }
            UpdateForm();
            
        }

        private void speedHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            
            directions.Speed = speedHScrollBar.Value;
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
        private void UpdateForm()
        {
            linearSpeedLabel.Text = directions.LinearSpeed.ToString();
            rotationSpeedLabel.Text = directions.RotationSpeed.ToString();
            speedLabel.Text = directions.Speed.ToString();
            UpdateConnectionLabel();
        }

        private void UpdateConnectionLabel()
        {
            if(client.IsConnected)
            {
                connectionLabel.BackColor = Color.Green;
                connectionLabel.Text = "ON";
            }
            else
            {
                connectionLabel.BackColor = Color.Red;
                connectionLabel.Text = "OFF";
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            client.Start();
            timer100.Enabled = true;
            timer2000.Enabled = true;

            UpdateForm();
            connectButton.Enabled = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                client.SendString(inputTextBox.Text);
            }
            else
            {
                outputTextBox.Text = "You must be connected to send text";
            }
            outputTextBox.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            outputTextBox.Text = client.OutputText;
            //if(client.IsConnected)
            //{
            //    connectButton.Enabled = false;
            //}
            //else
            //{
            //    connectButton.Enabled = true;
            //}
            UpdateForm();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
        }
        
        private void SendSpeed()
        {
            if(client.IsConnected)
            {
                 client.SendString(String.Format("{0} {1}", directions.LinearSpeed, directions.RotationSpeed));
            }
            else
            {
                outputTextBox.Text = "You must be connected to steer the robot";
            }
        }

        private void setIPButton_Click(object sender, EventArgs e)
        {
            string ipString = ipTextBox.Text;
            string portNumberString = portTextBox.Text;
            if (ipTextBox.Text.Contains(" ") || portTextBox.Text.Contains(" "))
            {
                outputTextBox.Text = "There are white spaces in IPAddress or Port number";
                return;
            }

            if (!TCPClient.ValidateIPV4(ipString))
            {
                outputTextBox.Text = "Incorrect IP Address";
                return;
            }
            if(string.IsNullOrWhiteSpace(portNumberString))
            {
                outputTextBox.Text = "Incorrect Port number";
                return;
            }
            else
            {
                client.IP = ipTextBox.Text;
                client.PortNumber = int.Parse(portTextBox.Text);
                connectButton.Enabled = true;
                outputTextBox.Text = "Correct format of IPAddres and Port number. Ready to connect.";
            }
        }

        private void timer2000_Tick(object sender, EventArgs e)
        {
            //client.SendString("test");
            if (client.IsConnected)
            {
                connectButton.Enabled = false;
            }
            else
            {
                connectButton.Enabled = true;
            }
            try
            {
                client.SendString("");
            }
            catch
            {
                client.CloseConnection();
            }

        }


    }
}
