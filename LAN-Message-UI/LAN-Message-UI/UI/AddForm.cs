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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            LoadButtonX(button2);
        }
        private void LoadButtonX(Button but)
        {
            but.Text = "Thoat";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
