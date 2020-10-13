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
    public partial class AddFriendForm : Form
    {
        public AddFriendForm()
        {
            InitializeComponent();
            InitLoaction();
        }
        public void InitLoaction()
        {
            labelIp.Location = new Point( (panel1.Width / 2) - labelIp.Width - 20 , (panel1.Height / 2));
            textBoxIp.Location = new Point((panel1.Width / 2)  , (panel1.Height / 2));
            buttonAdd.Location = new Point((panel1.Width / 2) , (panel1.Size.Height / 2 + 50));
        }

        private void textBoxIp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                buttonAdd.Focus();
            }
        }
    }
}
