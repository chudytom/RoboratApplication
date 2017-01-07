using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RatClientApplication
{
    class ColorfulProgressBar : ProgressBar
    {
        SolidBrush rectangleBrush = new SolidBrush(Color.GreenYellow);
        public Color Color { get; set; }
        public ColorfulProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            Color = new Color();
            Color = Color.Yellow;
            this.Value = 100;
        }

        public ColorfulProgressBar(Point location, Color progressBarColor) : this()
        {
            Color = progressBarColor;
            this.Location = location;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle colorRectangle = e.ClipRectangle;
            colorRectangle.Width = (int)(colorRectangle.Width * ((double)Value / Maximum));
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            e.Graphics.FillRectangle(new SolidBrush(Color), colorRectangle);
        }
    }
}
