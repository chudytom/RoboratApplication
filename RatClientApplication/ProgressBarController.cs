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
        public int Percantage { get; set; }
        ColorfulProgressBar batteryProgressBar;
        private int[] thresholds = new int[5] {27, 54, 67, 84, 100};
        private enum Levels { LowLow, Low, Medium, High, HighHigh }
        public ProgressBarController(ColorfulProgressBar batteryProgressBar)
        {
            this.batteryProgressBar = batteryProgressBar;
        }
        public void ResolveColor()
        {
            if (Percantage >= 100)
                Percantage = 99;
            if (Percantage < 0)
                Percantage = 0;
            //batteryProgressBar.Value = Voltage;
            Levels level = GetLevel(Percantage);
            switch (level)
            {
                case Levels.LowLow:
                    batteryProgressBar.Color = Color.Red;
                    break;
                case Levels.Low:
                    batteryProgressBar.Color = Color.Orange;
                    break;
                case Levels.Medium:
                    batteryProgressBar.Color = Color.Yellow;
                    break;
                case Levels.High:
                    batteryProgressBar.Color = Color.GreenYellow;
                    break;
                case Levels.HighHigh:
                    batteryProgressBar.Color = Color.Green;
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
