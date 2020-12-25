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
    public partial class frmADD : Form
    {
		Group selectedGroup;
		FrmMain mainForm;
		GroupForm groupForm;
		public List<User> listAdd;
		public frmADD(FrmMain mainForm)
		{
			InitializeComponent();
			InitControls();
			this.mainForm = mainForm;
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			this.mainForm.Controls.Add(this);
			this.pnContainAll.Location = new Point(mainForm.Width / 2 - this.pnContainAll.Width / 2, mainForm.Height / 2 - this.pnContainAll.Height / 2);
			listAdd = new List<User>();
		}
		
		public void InitControls()
		{
			this.BackColor = FrmMain.theme.BackColor;
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.picBoxClose.Image = Image.FromFile(FrmMain.theme.PictureClose);
		}

		public void InitAddGroupForm(Group selectedGroup)
		{
			listAdd = new List<User>();
			this.Show();
			this.BringToFront();
			this.selectedGroup = selectedGroup;
			this.pnUser.Controls.Clear();
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			ReLocation();
			LoadUserOption();
		}
		public void ReLocation()
		{
			this.pnContainAll.Location = new Point(mainForm.Width / 2 - this.pnContainAll.Width / 2, mainForm.Height / 2 - this.pnContainAll.Height / 2);
		}
		private void LoadUserOption()
		{
			foreach (var item in FrmMain.UserUIs)
			{
				if (!selectedGroup.MemberInGroup(item.user) && item.user.IsFriend && item.user.Status)
				{
					item.ucADD.Reset();
					this.pnUser.Controls.Add(item.ucADD);
				}
			}
		}
		private async void SendAddToGroupToServer()
		{
			foreach (var item in pnUser.Controls)
			{
				if (item.GetType() == typeof(ucADD))
				{
					if ((item as ucADD).isAdd)
					{
						listAdd.Add((item as ucADD).user);
					}
				}
			}
			foreach (var item in listAdd)
			{
				byte[] tempbuff = Encoding.UTF8.GetBytes("GPENDING%" + item.Id + "%" +
																   selectedGroup.ID + "%" + selectedGroup.Name + "%" + selectedGroup.admin.Id) ;
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			}

		}
        private void picBoxAdd_Click(object sender, EventArgs e)
        {
			this.Hide();
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			SendAddToGroupToServer();
			this.Hide();
		}
    }
}
