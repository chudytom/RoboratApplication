using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace RatClientApplication
{
    class ImageDisplay
    {
        private List<byte[]> listOfImages = new List<byte[]>();
        string folderPath = @"C:\Rat Application\Saved frames";

        public Bitmap CurrentImage { get; set; }
        public int xPictureBoxSize { get; set; }
        public int yPictureBoxSize { get; set; }
        public string OutputText { get; private set; }

        public virtual void OnImageReceived(EventArgs e)
        {
            ImageReceived?.Invoke(this, e);
        }

        public ImageDisplay(int xPictureBoxSize, int yPictureBoxSize)
        {
            this.xPictureBoxSize = xPictureBoxSize;
            this.yPictureBoxSize = yPictureBoxSize;
            OutputText = "";
        }

        public void AddImage(byte[] imageToSave)
        {
            listOfImages.Add(imageToSave);

        }
        
        public void SaveAllImages()
        {
            try
            {
                int i = 1;
                string folderPathWithTimestamp = folderPath + " " + DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss");
                Directory.CreateDirectory(folderPathWithTimestamp);
                foreach (byte[] image in listOfImages)
                {
                    string filename = folderPathWithTimestamp + @"\Image" + i.ToString() + ".jpg";
                    FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
                    file.Write(image, 0, image.Length);
                    OutputText = String.Format("{0} images saved", i);
                    i++;
                }
                OutputText = String.Format("\n All frames saved in a folder {0}", folderPathWithTimestamp);
            }
            catch (Exception e)
            {
                OutputText = String.Format("Couldn't save images in the following directory: {0} because: {1}", folderPath, e.Message); 
            }
        }

        public int GetCountOfImages()
        {
            return listOfImages.Count;
        }

        public event EventHandler ImageReceived;
    }
}
