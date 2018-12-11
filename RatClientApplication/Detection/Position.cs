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
    public abstract class Position
    {
        public abstract PointF Value { get; }
        public abstract void Draw(Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> rawImage);
    }

    public class CorrectPosition : Position
    {
        PointF position;
        public CorrectPosition(float x, float y)
        {
            position = new PointF(x, y);
        }
        public CorrectPosition(Point point) : this(point.X, point.Y) { }
        public override PointF Value => position;

        public override void Draw(Image<Bgr, byte> rawImage)
        {
            int radius = 40, thickness = 10;
            Color markColor = Color.LightGreen;
            var intPosition = new Point((int)position.X, (int)position.Y);
            CvInvoke.Circle(rawImage, intPosition, radius, Detection.GetMCvScalar(markColor), thickness);
            CvInvoke.Line(rawImage, new Point(intPosition.X, intPosition.Y - radius),
                                    new Point(intPosition.X, intPosition.Y + radius),
                                    Detection.GetMCvScalar(markColor), thickness);
            CvInvoke.Line(rawImage, new Point(intPosition.X - radius, intPosition.Y),
                                    new Point(intPosition.X + radius, intPosition.Y),
                                    Detection.GetMCvScalar(markColor), thickness);
        }
    }

    public class IncorrectPosition : Position
    {
        public override PointF Value => new PointF(float.NaN, float.NaN);

        public override void Draw(Image<Bgr, byte> rawImage)
        {
            CvInvoke.PutText(rawImage, "Rat could not be detected", new Point(0, 100), FontFace.HersheyPlain, fontScale: 3,
               color: Detection.GetMCvScalar(Color.Red), thickness: 10);
        }
    }
}
