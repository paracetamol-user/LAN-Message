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
	public partial class FrmADDMemberToContact : Form
	{
		public FrmMain mainForm { get; set; }
		public List<User> listUser;
		public ucContact selectedContactBook;
		public FrmADDMemberToContact()
		{
			InitializeComponent();
		}
		public FrmADDMemberToContact(FrmMain mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			this.mainForm.Controls.Add(this);
			this.pnContainAll.Location = new Point(mainForm.Width / 2 - this.pnContainAll.Width / 2, mainForm.Height / 2 - this.pnContainAll.Height / 2);
			listUser = new List<User>();
			InitControls();
		}
		public void  InitControls()
		{
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.picBoxClose.Image = Image.FromFile(FrmMain.theme.PictureClose);
			this.BackColor = FrmMain.theme.BackColor;
		}
		public void ReLocation()
		{
			this.pnContainAll.Location = new Point(mainForm.Width / 2 - 
													this.pnContainAll.Width / 2, mainForm.Height / 2 
													- this.pnContainAll.Height / 2);
		}
		public void OpenAdd(ucContact selectedContactBook)
		{
			InitControls();
			this.selectedContactBook = selectedContactBook;
			this.Show();
			this.BringToFront();
			this.listUser.Clear();
			this.pnUser.Controls.Clear();
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			ReLocation();
			LoadUser();
		}
		private void LoadUser()
		{
			foreach (var item in FrmMain.UserUIs)
			{
				if (!selectedContactBook.contactBook._IsInContactBook(item.user) && item.user.IsFriend)
				{
					item.ucADD.Reset();
					this.pnUser.Controls.Add(item.ucADD);
				}
			}
		}
		private async void SendAddToContact()
		{
			try
            {
				foreach (var item in pnUser.Controls)
				{
					if (item.GetType() == typeof(ucADD))
					{
						if ((item as ucADD).isAdd)
						{
							listUser.Add((item as ucADD).user);
						}
					}
				}
				foreach (var item in listUser)
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("ADDCONTACT%" + item.Id + "%" +
																	   selectedContactBook.contactBook.ID);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);

					selectedContactBook._AddUser(item);
				}
			}
			catch (Exception ex)
            {
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void picBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void pictureBoxAdd_Click(object sender, EventArgs e)
		{
			this.Hide();
			SendAddToContact();
		}
	}
}
