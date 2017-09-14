﻿using System;
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
    public class RatTracker : Detection
    {
        public RatTracker(Hsv lowerHSVLimit, Hsv upperHSVLimit)
        {
            LowerHSVLimit = lowerHSVLimit;
            UpperHSVLimit = upperHSVLimit;
        }

        public override void DrawPositionInfo()
        {
            ratPosition.Draw(rawImageCV);
        }

        public Point PerformDetection(Bitmap originalImage)
        {
            rawImageCV = new Image<Bgr, byte>(originalImage);
            hsvImageCV = GetHsvImage();
            PrepareBinaryImage(performMorphology: true);
            return GetRatPosition(drawPositionInfo: true);
        }
    }
}
