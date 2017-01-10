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
        private int[] thresholds = new int[5] {27, 54, 67, 84, 100};
        private enum Levels { LowLow, Low, Medium, High, HighHigh }
        public ProgressBarController(ColorfulProgressBar progressBar)
        {
            this.progressBar = progressBar;
            this.Voltage = Voltage;
        }
        public void CalculateValues()
        {
            if (Voltage >= 100)
                Voltage = 99;
            if (Voltage < 0)
                Voltage = 0;
            progressBar.Value = Voltage;
            Levels level = GetLevel(Voltage);
            switch (level)
            {
                case Levels.LowLow:
                    progressBar.Color = Color.Red;
                    break;
                case Levels.Low:
                    progressBar.Color = Color.Orange;
                    break;
                case Levels.Medium:
                    progressBar.Color = Color.Yellow;
                    break;
                case Levels.High:
                    progressBar.Color = Color.GreenYellow;
                    break;
                case Levels.HighHigh:
                    progressBar.Color = Color.Green;
                    break;
            }
        }

        private Levels GetLevel(int voltage)
        {
            for (int i = 0; i < thresholds.Length; i++)
            {
                if (voltage <= thresholds[i])
                    return (Levels)i;
            }
            return Levels.HighHigh;
        }
    }
}
