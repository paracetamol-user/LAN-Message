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
	public partial class FrmSetting : Form
	{
		string oldUsername;
		Button btnFocus;
		public FileInfo fi;
		public User me;
		public FrmMain parent;
		FrmLogin loginForm;
		public FrmSetting()
		{
			InitializeComponent();
		}
		public FrmSetting(User me, FrmMain parent, FrmLogin loginForm)
		{
			InitializeComponent();
			this.me = me;
			this.parent = parent;
			this.loginForm = loginForm;
			InitSettingForm();
			ChangeColorAllLabelControl(this);
			InitStartForm();
			LoadMyAccount();
		}

		private void LoadMyAccount()
		{
			this.lblName.Text = me.Name;
			this.lblID.Text = "#" + me.Id;
			using (FileStream fs = new FileStream(me.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.pictureAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}

		private void InitSettingForm()
		{
			this.TopLevel = false;
			this.parent.Controls.Add(this);
			this.Dock = DockStyle.Fill;
			this.BackColor = FrmMain.theme.BackColor;
			this.ChangeColorPanelControl();
			this.ChangeColorLine();
		}

		public void ChangeColorPanelControl()
		{
			this.pnMenu.BackColor = FrmMain.theme.Menu;
			this.pnPassword.BackColor = FrmMain.theme.FocusColor;
			this.btnEditPassword.BackColor = FrmMain.theme.BackColor;
			this.btnSave.BackColor = FrmMain.theme.FocusColor;
			this.btnSave.ForeColor = FrmMain.theme.TxtForeColor;
			this.btnSavePassword.ForeColor = FrmMain.theme.TxtForeColor;
			this.btnSavePassword.BackColor = FrmMain.theme.BackColor;
		}
		public void ChangeColorAllLabelControl(Control x)
		{
			foreach (var item in x.Controls)
			{
				if (item.GetType() == typeof(Label))
				{
					(item as Label).ForeColor = FrmMain.theme.TextColor;

				}
				else
				if (item.GetType() == typeof(Button))
				{
					(item as Button).ForeColor = FrmMain.theme.TextColor;
				}
				else if (item.GetType() == typeof(RadioButton))
				{
					(item as RadioButton).ForeColor = FrmMain.theme.TextColor;
				}
				ChangeColorAllLabelControl(item as Control);
			}
		}
		public void ChangeColorLine()
		{
			this.pnLine2.BackColor = FrmMain.theme.LineColor;
			this.panelLine1.BackColor = FrmMain.theme.LineColor;
		}
		public void ResetPicture()
		{
			using (FileStream fs = new FileStream(FrmMain.theme.PictureClose, FileMode.Open, FileAccess.Read))
			{
				this.pictureBox2.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
		private void InitStartForm()
		{
			this.pnMyAccount.Show();
			this.pnMyAccount.BringToFront();
			this.pnMyAccount.Dock = DockStyle.Fill;
			this.pnMyAccount.Visible = true;
			this.btnMyAccount.BackColor = FrmMain.theme.FocusColor;
			this.btnFocus = this.btnMyAccount;
		}

		private bool isChangingUsername = false;
		private TextBox txtUsername = null;
		private void CheckPasswordFromServer()
		{
			try
			{
				UserVerification verification = new UserVerification();

				byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("CHECKPASS%{0}%{1}%{2}",
					FrmMain.me.Id,
					verification.GetSHA256(txtOldPassword.Text),
					verification.GetSHA256(txtNewPassword.Text)));
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", tempBuff, "Server");
				FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void RespondToChangePasswordMessage(bool isSuccess)
		{
			if (isSuccess)
			{
				this.lblNoticeINPassword.Visible = true;
				this.btnEditPassword.Text = "CHANGE";
				this.panelChangePassword.Visible = false;
				this.btnSavePassword.Visible = false;
				lblErrorINPassword.Visible = false;
			}
			else
			{
				lblErrorINPassword.Visible = true;
			}
		}
		public async void ChangeAvatar()
		{
			try
			{
				Guid id = Guid.NewGuid();
				byte[] tempBuff = Encoding.UTF8.GetBytes("SAVEAVATAR%" + fi.Length + "%" + fi.Name + "%" + fi.Extension + "%" + id.ToString());
				SmallPackage packageReceive = new SmallPackage(0, 1024, "M", tempBuff, "0");
				FrmMain.server.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);

				/// Send file
				byte[] data = File.ReadAllBytes(fi.FullName);

				await FrmMain.client.SendFileToServer(data, "A", id.ToString());
				byte[] tempfile = File.ReadAllBytes(fi.FullName);
				
				File.WriteAllBytes(@"./cache/avatar/" + me.Id + fi.Extension, tempfile);
				FrmMain.me.AvatarPath = @"./cache/avatar/" + me.Id + fi.Extension;
				this.parent.LoadUser();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.btnFocus != null) this.btnFocus.BackColor = Color.Transparent;
			this.pnMyAccount.Show();
			this.pnMyAccount.BringToFront();
			this.pnMyAccount.Dock = DockStyle.Fill;
			this.pnMyAccount.Visible = true;
			this.btnMyAccount.BackColor = FrmMain.theme.FocusColor;
			this.btnFocus = this.btnMyAccount;
		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (this.btnFocus != null) this.btnFocus.BackColor = Color.Transparent;
			this.pnTheme.Show();
			this.pnTheme.BringToFront();
			this.pnTheme.Dock = DockStyle.Fill;
			this.pnTheme.Visible = true;
			this.btnTheme.BackColor = FrmMain.theme.FocusColor;
			this.btnFocus = this.btnTheme;
			if (FrmMain.theme.IsWhite) this.radioButton1.Checked = true;
			else this.radioButton2.Checked = true;
		}
		private void btnLog_Click(object sender, EventArgs e)
		{
			parent.acceptClose = false;
			this.Close();
			parent.Close();
			
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		private void btnMyAccount_MouseMove(object sender, MouseEventArgs e)
		{
			(sender as Button).BackColor = FrmMain.theme.FocusColor;
		}
		private void btnTheme_MouseLeave(object sender, EventArgs e)
		{
			(sender as Button).BackColor = Color.Transparent;
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				FrmMain.theme.White();
				parent.ChangeTheme();
				byte[] tempbuff = Encoding.UTF8.GetBytes("THEME%" + (FrmMain.theme.IsWhite == true ? "White" : "Black"));
				SmallPackage packageReceive = new SmallPackage(1024, tempbuff.Length, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				FrmMain.theme.Black();
				parent.ChangeTheme();
				byte[] tempbuff = Encoding.UTF8.GetBytes("THEME%" + (FrmMain.theme.IsWhite == true ? "White" : "Black"));
				SmallPackage packageReceive = new SmallPackage(1024, tempbuff.Length, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}


        private void btnSave_Click(object sender, EventArgs e)
        {
			ChangeAvatar();
		}
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
			if (txtOldPassword.Text.Trim() == string.Empty || txtNewPassword.Text.Trim() == string.Empty)
			{
				lblErrorINPassword.Text = "Thiếu thông tin";
				return;
			}

			CheckPasswordFromServer();
		}
		private void btnEditPassword_Click(object sender, EventArgs e)
		{
			if (this.panelChangePassword.Visible == false)
			{
				this.lblNoticeINPassword.Visible = false;
				this.btnEditPassword.Text = "CANCEL";
				this.panelChangePassword.Visible = true;
				this.btnSavePassword.Visible = true;

			}
			else
			{
				this.btnEditPassword.Text = "CHANGE";
				this.panelChangePassword.Visible = false;
				this.btnSavePassword.Visible = false;
			}
		}
		private void pictureAvatar_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter =
				"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";

			openFileDialog.Multiselect = false;

			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
				{
					this.pictureAvatar.Image = Image.FromStream(fs);
					fs.Dispose();
				}
				// Upload to database and update to all users.
				fi = new FileInfo(openFileDialog.FileName);
			}

			// Enable discard and save button for click
			this.btnSave.Enabled = true;
		}
	}
}
