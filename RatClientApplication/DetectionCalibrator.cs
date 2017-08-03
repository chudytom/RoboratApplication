using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace RatClientApplication
{
    public class DetectionCalibrator
    {
        public DetectionCalibrator(Bitmap originalImage)
        {
            originalImageCV = new Image<Emgu.CV.Structure.Bgr, Byte>(originalImage);
            //originalMat = originalImageCV.Mat;
        }

        Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> originalImageCV;
        Emgu.CV.Image<Emgu.CV.Structure.Hsv, Byte> hsvImageCV;
        Emgu.CV.Image<Emgu.CV.Structure.Gray, Byte> binaryImageCV;
        Hsv lowerLimit;
        Hsv upperLimit;

        public Hsv LowerHSVLimit
        {
            get { return lowerLimit; }
            set { lowerLimit = value; }
        }

        public Hsv UpperHSVLimit
        {
            get { return upperLimit; }
            set { upperLimit = value; }
        }

        public int HueMin { get; set; }
        public int HueMax { get; set; }
        public int SaturationMin { get; set; }
        public int SaturationMax { get; set; }
        public int ValueMin { get; set; }
        public int ValueMax { get; set; }

        public Image GetOriginalImage()
        {
            return originalImageCV.ToBitmap();
        }

        public Image GetHsvImage()
        {
            hsvImageCV = originalImageCV.Convert<Hsv, Byte>();
            CvInvoke.CvtColor(hsvImageCV, hsvImageCV, ColorConversion.Bgr2Hsv);
            return hsvImageCV.ToBitmap();
        }

        public Image GetBinaryImage()
        {
            binaryImageCV = hsvImageCV.InRange(lowerLimit, upperLimit);
            return binaryImageCV.ToBitmap();
        }
    }
}
