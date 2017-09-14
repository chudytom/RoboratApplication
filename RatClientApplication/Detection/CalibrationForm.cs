using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RatClientApplication.Detection;

namespace RatClientApplication
{
    public partial class CalibrationForm : Form
    {
        private DetectionCalibrator calibrator;

        public CalibrationForm()
        {
            InitializeComponent();
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHSV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBinary.SizeMode = PictureBoxSizeMode.StretchImage;            
        }

        public CalibrationForm(DetectionCalibrator calibrator) : this()
        {
            this.calibrator = calibrator;
            pictureBoxOriginal.Image = calibrator.GetOriginalImage();
            pictureBoxHSV.Image = calibrator.GetHsvBitmap();
            ScrollBarValueChanged();
        }


        private void SetBinaryImageWithNewLimits()
        {
            calibrator.LowerHSVLimit = new Emgu.CV.Structure.Hsv(
                hScrollBarHMin.Value, hScrollBarSMin.Value, hScrollBarVMin.Value);
            calibrator.UpperHSVLimit = new Emgu.CV.Structure.Hsv(
                hScrollBarHMax.Value, hScrollBarSMax.Value, hScrollBarVMax.Value);
            calibrator.PrepareBinaryImage(performMorphology: true);
            pictureBoxBinary.Image = calibrator.GetBinaryImage();
            calibrator.GetRatPosition(drawPositionInfo: true);
            pictureBoxOriginal.Image = calibrator.GetOriginalImage();
        }

        private void UpdateLabelsValues()
        {
            labelHMin.Text = hScrollBarHMin.Value.ToString();
            labelHMax.Text = hScrollBarHMax.Value.ToString();
            labelSMin.Text = hScrollBarSMin.Value.ToString();
            labelSMax.Text = hScrollBarSMax.Value.ToString();
            labelVMin.Text = hScrollBarVMin.Value.ToString();
            labelVMax.Text = hScrollBarVMax.Value.ToString();
        }

        private void ScrollBarValueChanged()
        {
            UpdateLabelsValues();
            SetBinaryImageWithNewLimits();
        }

        private void hScrollBarHMin_ValueChanged(object sender, EventArgs e)
        {
            ScrollBarValueChanged();
        }

        private void hScrollBarSMin_ValueChanged(object sender, EventArgs e)
        {
            ScrollBarValueChanged();
        }

        private void hScrollBarVMin_ValueChanged(object sender, EventArgs e)
        {
            ScrollBarValueChanged();
        }

        private void hScrollBarHMax_ValueChanged(object sender, EventArgs e)
        {
            ScrollBarValueChanged();
        }

        private void hScrollBarSMax_ValueChanged(object sender, EventArgs e)
        {
            ScrollBarValueChanged();
        }

        private void hScrollBarVMax_ValueChanged(object sender, EventArgs e)
        {
            ScrollBarValueChanged();
        }

        private void buttonSendCalibrationParameters_Click(object sender, EventArgs e)
        {
            calibrator.HueMin = hScrollBarHMin.Value;
            calibrator.HueMax = hScrollBarHMax.Value;
            calibrator.SaturationMin = hScrollBarSMin.Value;
            calibrator.SaturationMax = hScrollBarSMax.Value;
            calibrator.ValueMin = hScrollBarVMin.Value;
            calibrator.ValueMax = hScrollBarVMax.Value;
            DialogResult result = MessageBox.Show("Detection algorithm has been calibrated successfully", "Calibration successfull",
                MessageBoxButtons.OK);
            if(result == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
