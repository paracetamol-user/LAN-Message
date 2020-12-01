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
	public partial class ucFriend : UserControl
	{
		private UserUI Parent;
		private Panel pnParent;
		public ucFriend()
		{
			InitializeComponent();
		}
		public ucFriend(UserUI userUI)
		{
			InitializeComponent();
			this.Dock = DockStyle.Top;
			this.Parent = userUI;
			this.lbName.Text = userUI.user.Name;
			this.lbId.Text = userUI.user.Id;
		}
		private void pnContain_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(242, 243, 245);
		}

		private void pnContain_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}
		private void picMenu_Click(object sender, EventArgs e)
		{
			Parent.cmns.Show(MousePosition);
		}
		private  void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			Form1.userUIForcus = this.Parent;
		}

        private void pnContainPicture_Click(object sender, EventArgs e)
        {
			this.Parent.ShowChatForm();
			this.Parent.AddUserInteracted();
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
			}
			this.Parent.ucInterac.ChangeColorWhenClick();
			Form1.userUIForcus = this.Parent;
		}
    }
}
