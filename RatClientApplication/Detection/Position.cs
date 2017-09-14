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
        public abstract Point Value { get; }
        public abstract void Draw(Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> rawImage);
    }

    public class CorrectPosition : Position
    {
        Point position;
        public CorrectPosition(int x, int y)
        {
            position = new Point(x, y);
        }
        public CorrectPosition(Point point) : this(point.X, point.Y) { }
        public override Point Value => position;

        public override void Draw(Image<Bgr, byte> rawImage)
        {
            int radius = 40, thickness = 10;
            Color markColor = Color.LightGreen;
            CvInvoke.Circle(rawImage, position, radius, Detection.GetMCvScalar(markColor), thickness);
            CvInvoke.Line(rawImage, new Point(position.X, position.Y - radius),
                                    new Point(position.X, position.Y + radius),
                                    Detection.GetMCvScalar(markColor), thickness);
            CvInvoke.Line(rawImage, new Point(position.X - radius, position.Y),
                                    new Point(position.X + radius, position.Y),
                                    Detection.GetMCvScalar(markColor), thickness);
        }
    }

    public class IncorrectPosition : Position
    {
        public override Point Value => new Point(5000, 5000);

        public override void Draw(Image<Bgr, byte> rawImage)
        {
            CvInvoke.PutText(rawImage, "Rat could not be detected", new Point(100, 100), FontFace.HersheyPlain, fontScale: 5,
               color: Detection.GetMCvScalar(Color.Red), thickness: 10);
        }
    }
}
