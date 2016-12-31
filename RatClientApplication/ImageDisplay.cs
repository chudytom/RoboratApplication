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
        public Bitmap CurrentImage { get; set; }
        public int xPictureBoxSize { get; set; }
        public int yPictureBoxSize { get; set; }
        private List<Bitmap> listOfImages = new List<Bitmap>();
        public String fileToDisplay = @"D:\OneDrive\Szczur\szczur.jpg";

        public virtual void OnImageReceived(EventArgs e)
        {
            ImageReceived?.Invoke(this, e);
        }

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
            CurrentImage?.Dispose();
            //if (imageToDisplay !=null)
            //{
            //    imageToDisplay.Dispose();
            //}
            CurrentImage = new Bitmap(fileToDisplay);
            return CurrentImage;
        }
        public int GetCountOfImages()
        {
            return listOfImages.Count;
        }

        public event EventHandler ImageReceived;
    }
}
