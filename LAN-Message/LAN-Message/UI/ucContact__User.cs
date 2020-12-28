using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			this.label1.ForeColor = FrmMain.theme.TxtForeColor;
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			this.picRemove.Image = Image.FromFile(FrmMain.theme.PictureClose);
			using (FileStream fs = new FileStream(user.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
		public void _RemoveThis()
		{
			this.UcContactParent._RemoveContact__User(this);
		}

		private void picRemove_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure remove this user!", "Remove User In Contact", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					byte[] buff = Encoding.UTF8.GetBytes("DELETEUSERINCONTACT%" + UcContactParent._ID + "%" + user.Id);
					SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "Server");
					FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);

					_RemoveThis();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void pnLine_Click(object sender, EventArgs e)
		{
			foreach (var item in FrmMain.UserUIs)
			{
				if (item.user == this.user)
				{
					item.ShowChatForm();
					item.AddUserInteracted();
					if (FrmMain.interactFocus != null)
					{
						FrmMain.interactFocus.ChangeColorWhenNonClick();
					}
					item.ucInterac.ChangeColorWhenClick();
					FrmMain.interactFocus = item.ucInterac;
				}
			}
			
		}
	}
}
