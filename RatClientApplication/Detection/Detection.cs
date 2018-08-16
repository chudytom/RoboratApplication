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
    public abstract class Detection
    {

        protected Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> rawImageCV;
        protected Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> originalImageCV;
        protected Emgu.CV.Image<Emgu.CV.Structure.Hsv, Byte> hsvImageCV;
        protected Emgu.CV.Image<Emgu.CV.Structure.Gray, Byte> binaryImageCV;
        protected Position ratPosition;
        public Hsv LowerHSVLimit { get; set; }
        public Hsv UpperHSVLimit { get; set; }

        public int HueMin { get; set; }
        public int HueMax { get; set; }
        public int SaturationMin { get; set; }
        public int SaturationMax { get; set; }
        public int ValueMin { get; set; }
        public int ValueMax { get; set; }

        public Bitmap GetOriginalImage()
        {
            return rawImageCV.ToBitmap();
        }

        public abstract void DrawPositionInfo();

        public Image GetHsvBitmap()
        {
            return GetHsvImage().ToBitmap();
        }

        protected Emgu.CV.Image<Emgu.CV.Structure.Hsv, Byte> GetHsvImage()
        {
            hsvImageCV = rawImageCV.Convert<Hsv, Byte>();
            CvInvoke.CvtColor(hsvImageCV, hsvImageCV, ColorConversion.Bgr2HsvFull);
            return hsvImageCV;
        }

        public void PrepareBinaryImage(bool performMorphology)
        {
            binaryImageCV = hsvImageCV.InRange(LowerHSVLimit, UpperHSVLimit);
            if (performMorphology)
                PerformMorphologyOperations(binaryImageCV);
        }

        public Image GetBinaryImage()
        {
            return binaryImageCV.ToBitmap();
        }

        protected void PerformMorphologyOperations(Emgu.CV.Image<Emgu.CV.Structure.Gray, Byte> imageToProcess)
        {
            Mat erosionKernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(10, 10), new Point(-1, -1));
            Mat dilationKernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(20, 20), new Point(-1, -1));
            CvInvoke.Erode(binaryImageCV, binaryImageCV, erosionKernel, new Point(-1, -1), 2, BorderType.Default, new MCvScalar(1, 1, 1));
            CvInvoke.Dilate(binaryImageCV, binaryImageCV, erosionKernel, new Point(-1, -1), 2, BorderType.Default, new MCvScalar(1, 1, 1));
        }

        public Point GetRatPosition(bool drawPositionInfo)
        {
            return GetPositionFromBinary(binaryImageCV, drawPositionInfo);
        }

        protected Point GetPositionFromBinary(Emgu.CV.Image<Emgu.CV.Structure.Gray, Byte> binaryImage, bool drawPositionInfo)
        {
            int maxNumberOfObects = 50;
            int minObjectArea = 30 * 30;
            int maxObjectArea = (int)(binaryImage.Size.Width * binaryImage.Size.Height / 1.05);
            ratPosition = new IncorrectPosition();
            Point positionNotFound = new Point(5000, 5000);
            Emgu.CV.Image<Emgu.CV.Structure.Gray, Byte> temporaryBinaryImage = binaryImage.Clone();
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Emgu.CV.Mat hierarchy = new Mat();
            CvInvoke.FindContours(temporaryBinaryImage, contours, hierarchy, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
            if (contours.Size > 0)
            {
                int numberOfObjects = contours.Size;
                //var h = hierarchy.GetInputOutputArray();
                if (numberOfObjects < maxNumberOfObects)
                {
                    double referenceArea = 0;
                    //index = hierarchy.GetData(new int[] { index, 0 })[0]
                    for (int index = 0; index < numberOfObjects; index++)
                    {
                        IInputArray contour = contours.GetInputArray().GetMat(index);
                        MCvMoments moment = CvInvoke.Moments(contour);
                        double area = moment.M00;

                        if (area > minObjectArea && area < maxObjectArea && area > referenceArea)
                        {
                            ratPosition = new CorrectPosition(x: (int)(moment.M10 / area), y: (int)(moment.M01 / area));
                            referenceArea = area;
                        }
                    }
                }
            }
            if (drawPositionInfo)
            {
                //DrawPositionInfo();
            }

            return ratPosition.Value;
        }

        public static MCvScalar GetMCvScalar(Color color)
        {
            return new MCvScalar(color.B, color.G, color.R);
        }
    }


}
