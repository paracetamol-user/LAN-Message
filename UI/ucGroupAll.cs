using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ucGroupAll : UserControl
    {
        public ucGroupAll()
        {
            InitializeComponent();
        }

        private void picChat_Click(object sender, EventArgs e)
        {

        }
        public void SetAvatar(string path)
        {
            gunaPic.Image = Image.FromFile(path);
        }
    }
}
