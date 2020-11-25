using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ucMessShow : UserControl
    {
        private string mess;
        private string idMess;
        public ucMessShow()
        {
            InitializeComponent();
        }
        public ucMessShow(string mess)
        {
            InitializeComponent();
            this.label1.Text = mess;
            this.ScaleLabel();
        }
        public void ScaleLabel()
        {
            Size lblTextSize() => TextRenderer.MeasureText(label1.Text, label1.Font);
            Size s = lblTextSize();
            while (true)
            {
                if (label1.Height < s.Height)
                {
                    label1.Height = label1.Height + 2 * (int)label1.Font.Size;
                }
                else break;
            }
        }
    }
}
