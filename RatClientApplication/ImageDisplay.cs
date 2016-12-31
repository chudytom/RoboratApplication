using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RatClientApplication
{
    class ImageDisplay
    {
        public Bitmap imageToDisplay { get; set; }
        public int xPictureBoxSize { get; set; }
        public int yPictureBoxSize { get; set; }
        private List<Bitmap> listOfImages = new List<Bitmap>();
        public String fileToDisplay = @"D:\OneDrive\Szczur\szczur.jpg";

        public ImageDisplay(int xPictureBoxSize, int yPictureBoxSize)
        {
            this.xPictureBoxSize = xPictureBoxSize;
            this.yPictureBoxSize = yPictureBoxSize;

        }

        public void addImage(Bitmap imageToDisplay)
        {
            listOfImages.Add(imageToDisplay);
        }

        public Bitmap getImage()
        {
            if (imageToDisplay !=null)
            {
                imageToDisplay.Dispose();
            }
            imageToDisplay = new Bitmap(fileToDisplay);
            return imageToDisplay;
        }
    }
}
