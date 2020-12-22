using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucContact__User : UserControl
	{
		public User user { get; set; }
		public ucContact UcContactParent { get; set; }
		public ucContact__User()
		{
			InitializeComponent();
		}
		public ucContact__User(User user , ucContact ucContactParent)
		{
			this.user = user;
			this.UcContactParent = ucContactParent;
			InitializeComponent();
			this.Dock = DockStyle.Top;
			_InitControls();
		}
		public void _InitControls()
		{
			this.label1.Text = user.Name;
			this.label1.ForeColor = Form1.theme.TxtForeColor;
			this.pnLine.BackColor = Form1.theme.LineColor;
			this.picRemove.Image = Image.FromFile(Form1.theme.PictureClose);
			this.roundPicAvatar.Image = Image.FromFile(user.AvatarPath);
		}
		public void _RemoveThis()
		{
			this.UcContactParent._RemoveContact__User(this);
		}

		private void picRemove_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure remove this user!", "Remove User In Contact", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				byte[] buff = Encoding.UTF8.GetBytes("DELETEUSERINCONTACT%" + UcContactParent._ID + "%" + user.Id);
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "Server");
				Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);

				_RemoveThis();
			}
		}

		private void pnLine_Click(object sender, EventArgs e)
		{
			foreach (var item in Form1.UserUIs)
			{
				if (item.user == this.user)
				{
					item.ShowChatForm();
					item.AddUserInteracted();
					if (Form1.interactFocus != null)
					{
						Form1.interactFocus.ChangeColorWhenNonClick();
					}
					item.ucInterac.ChangeColorWhenClick();
					Form1.interactFocus = item.ucInterac;
				}
			}
			
		}
	}
}
