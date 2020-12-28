using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace UI
{
    class roundpicturebox:PictureBox
    {
        public roundpicturebox()
        {
            this.BackColor = SystemColors.Control;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Control tam=this.Parent;
            while (tam.Parent != null && tam.BackColor == Color.Transparent)
            {
                tam = tam.Parent;
               
            }
            this.BackColor = tam.BackColor;
            
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                Region = new Region(gp);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
