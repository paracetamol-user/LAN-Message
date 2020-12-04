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
	public partial class SettingForm : Form
	{
		string oldUsername;
		Form1 parentForm;
		public FileInfo fi;
		public SettingForm()
		{
			InitializeComponent();
		}

		public SettingForm(User me, Form1 parent)
		{
			InitializeComponent();
			lblUsername.Text = me.Name;
			lblName.Text = me.Name;
			oldUsername = me.Name;
			lblID.Text = string.Format("#{0}", me.Id);
			lblPassword.Text = "*********";
			lblPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			this.parentForm = parent;
			this.pictureBox1.Image = Image.FromFile(me.AvatarPath);
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{

			if (Form1.me.Name != lblName.Text)
			{
				Form1.me.Name = lblName.Text;
				
			}
			Form1.settingForm = null;
			this.Close();
		}


		private bool isChangingUsername = false;
		private TextBox txtUsername = null;

		private void btnEditUsername_Click(object sender, EventArgs e)
		{
			if (!isChangingUsername)
			{
				isChangingUsername = true;
				// Hide label
				this.lblUsername.Visible = false;
				// Create the textbox for typing username
				txtUsername = new TextBox();
				this.panelUsername.Controls.Add(txtUsername);
				txtUsername.Text = lblUsername.Text;
				txtUsername.Dock = DockStyle.Left;
				txtUsername.Width = 180;
				txtUsername.Height = 22;
				txtUsername.TextChanged += (s, ev) =>
				{
					this.btnDiscard.Enabled = true;
					this.btnSave.Enabled = true;
				};
			}
			//// Enable discard and save button for click
			//this.btnDiscard.Enabled = true;
			//this.btnSave.Enabled = true;
		}
		
		// Release changes in username
		private void ReleaseUsernameChange()
		{
			// Remove textbox for change username
			this.panelUsername.Controls.Remove(txtUsername);
			txtUsername.Visible = false;
			txtUsername = null;

			// Show label username
			this.lblUsername.Visible = true;
		}
		private void btnEditDownloadPath_Click_1(object sender, EventArgs e)
		{
			FolderBrowserDialog browser = new FolderBrowserDialog();
			// Description for browser
			browser.Description = "Select downloads save path";
			// Allow create new folders in file explorer
			browser.ShowNewFolderButton = true;
			// Default to the My documents folder
			browser.RootFolder = Environment.SpecialFolder.MyDocuments;
			// Show the browser dialog and return path string
			DialogResult result = browser.ShowDialog();
			if (result == DialogResult.OK)
				lblPath.Text = browser.SelectedPath;


			// Enable discard and save button for click
			this.btnDiscard.Enabled = true;
			this.btnSave.Enabled = true;
		}

		private void btnSavePassword_Click_1(object sender, EventArgs e)
		{
			if(txtOldPassword.Text.Trim() == string.Empty || txtNewPassword.Text.Trim() == string.Empty)
			{
				lblErrorINPassword.Text = "Thiếu thông tin";
				return;
			}

			CheckPasswordFromServer();
		}


		// Log out function
		// Close with parent form and login form
		private void btnLogout_Click_1(object sender, EventArgs e)
		{
			this.Close();
			parentForm.Close();
		}
		
		private void btnSave_Click_1(object sender, EventArgs e)
		{
			// Update to server
			if( txtUsername != null && txtUsername.Text != Form1.me.Name )
			ChangeUsernameInServer(txtUsername.Text);
			// ChangeAvatar();
		}

		private void btnDiscard_Click(object sender, EventArgs e)
		{
			// Release changes in username field
			ReleaseUsernameChange();
			isChangingUsername = false;
			// Release changes in path


			// Enable discard and save button for click
			this.btnDiscard.Enabled = false;
			this.btnSave.Enabled = false;
		}
		// Discard changes and revert old version
		// Change status of DISCARD and SAVE button
		// Save changes and send to server
		// Change status of DISCARD and SAVE button
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

		// Change password
		private void CheckPasswordFromServer()
		{
			UserVerification verification = new UserVerification();
			byte[] buff = new byte[1024];
			byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("CHECKPASS%{0}%{1}%{2}", Form1.me.Id,
																							verification.GetSHA256(txtOldPassword.Text),
																							verification.GetSHA256(txtNewPassword.Text)));
			tempBuff.CopyTo(buff, 0);
			Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
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
		// Change username
		private void ChangeUsernameInServer(string newUsername)
		{
			byte[] buff = new byte[1024];
			byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("CHANGENAME%{0}%{1}", Form1.me.Id, newUsername));

			tempBuff.CopyTo(buff, 0);
			Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
		}
		/// <summary>
		///  Change Avatar
		/// </summary>
		public async void ChangeAvatar()
        {
			byte[] tempBuff = Encoding.UTF8.GetBytes("SAVEAVATAR%" + Form1.me.Id + "%" + fi.Name + "%" + fi.Length + "%" + fi.Extension);
			byte[] buffer = new byte[1024];
			tempBuff.CopyTo(buffer, 0);
			await Form1.server.GetStream().WriteAsync(buffer, 0, buffer.Length);

			/// Send file
			byte[] data = File.ReadAllBytes(fi.FullName);
			int temp = 1024 - (data.Length % 1024);
			byte[] package = new byte[data.Length + temp];
			data.CopyTo(package, 0);
			await Form1.client.SendFileToServer(package);
			byte[] tempfile = File.ReadAllBytes(fi.FullName);
			File.WriteAllBytes(@"..\..\cache\avatar\" + fi.Name + fi.Extension, tempfile);
			Form1.me.AvatarPath = @"..\..\cache\avatar\" + fi.Name + fi.Extension;
			this.parentForm.LoadUser();
			}
		public void RespondToChangeUsernameMessage(bool isSuccess) 
		{
			if (isSuccess)
			{
				lblErrorINUsername.Visible = false;
				lblNoticeINUsername.Visible = true;
				lblName.Text = txtUsername.Text;
				lblUsername.Text = txtUsername.Text;
				ReleaseUsernameChange();

				// Change status
				this.btnDiscard.Enabled = false;
				this.btnSave.Enabled = true;
				isChangingUsername = false;
				Form1.me.Name = lblUsername.Text;
				parentForm.LoadUser();
			}
			else
			{
				lblErrorINUsername.Visible = true;
			}
		}
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter =
				"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";

			openFileDialog.Multiselect = false;

			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				Image avatar = Image.FromFile(openFileDialog.FileName);
				this.pictureBox1.Image = avatar;

				// Upload to database and update to all users.
				fi = new FileInfo(openFileDialog.FileName);
			}

			// Enable discard and save button for click
			this.btnDiscard.Enabled = false;
			this.btnSave.Enabled = true;
		}
    }
}
