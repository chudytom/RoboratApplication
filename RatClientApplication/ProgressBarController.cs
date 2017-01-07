using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RatClientApplication
{
    class ProgressBarController
    {
        public int Voltage { get; set; }
        ColorfulProgressBar progressBar;
        private const int  lowLowLevel = 500;
        public ProgressBarController(ColorfulProgressBar progressBar)
        {
            this.progressBar = progressBar;
            this.Voltage = Voltage;
        }
        public void CalculateValues()
        {
            if (Voltage < lowLowLevel)
                return;
            progressBar.Value = (Voltage - lowLowLevel) / 5;

            if (progressBar.Value >= 50)
                progressBar.Color = Color.Green;
            else
                progressBar.Color = Color.Red;
        }
    }
}
