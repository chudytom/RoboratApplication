using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace RatClientApplication.Detection
{

    public class DetectionCalibrator : Detection // Theres is another class named DetectionCalibration. Fix the names !!!!
    {
        public DetectionCalibrator(Bitmap originalImage)
        {
            originalImageCV = new Image<Emgu.CV.Structure.Bgr, Byte>(originalImage);
            rawImageCV = originalImageCV.Clone();
        }

        public override void DrawPositionInfo()
        {
            rawImageCV = originalImageCV.Clone();
            ratPosition.Draw(rawImageCV);
        }
    }
}
