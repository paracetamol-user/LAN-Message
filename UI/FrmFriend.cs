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
    public partial class FrmFriend : Form
    {
        Panel pnAllFriend;
        public FrmFriend()
        {
            InitializeComponent();
            InitPnAllFriend();
        }
        private void InitPnAllFriend()
        {
            this.pnAllFriend = new Panel();
            this.pnAllFriend.Dock = DockStyle.Fill;
            this.pnAllFriend.Padding = new Padding(30, 20, 20, 0);
            this.pnAllFriend.BringToFront();
            this.pnAllFriend.Visible = false;
            this.Controls.Add(pnAllFriend);
        }
        public void AddFriend(UserUI userUI)
        {
            pnAllFriend.Controls.Add(userUI.ucFriend);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.pnAllFriend.Visible = true;
            pnAllFriend.Show();
            pnAllFriend.BringToFront();
        }
    }
}
