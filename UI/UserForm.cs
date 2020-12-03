using Communication;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
using User = UserManager.User;
using Guna.UI2.WinForms;
using System.IO;

namespace UI
{
	public partial class UserForm : Form
	{
		private User user;
		private List<Panel> BoxChats;
		private int id;
		private List<FileInfo> files;
		private short LastInteracted;
		public UserForm()
		{
			InitializeComponent();
			this.Visible = false;
		}
		public UserForm(UserManager.User user)
		{
			InitializeComponent();
			this.Visible = false;
			this.user = user;
			this.id = 0;
			LastInteracted = 0;
			BoxChats = new List<Panel>();
			files = new List<FileInfo>();
			InitUserForm();
		}
		public void SetAvatar(string path)
		{
			
		}
		public void AddItemInToListChat(User user, string str)
		{
			Panel tempPanel = new Panel();
			tempPanel.Dock = DockStyle.Top;
			tempPanel.AutoSize = true;
			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user);
			ucMessShow messShow = new ucMessShow(str);
			messShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;
			UserInChatBox._AddMessControl(messShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			this.panelListChat.Controls.Add(tempPanel);
		}
		public void AddFileToListChat(User _user,string tempId, string tempName)
		{
			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

				ucUserINChatBox UserInChatBox = new ucUserINChatBox(_user);
				ucFileShow fileshow = new ucFileShow(_user, tempId, tempName);
				if (_user == Form1.me) fileshow._DisableButDownLoad();
				fileshow.Dock = DockStyle.Top;
				UserInChatBox.Dock = DockStyle.Top;
				
				UserInChatBox._AddFileControl(fileshow);
				tempPanel.Controls.Add(UserInChatBox);
				this.panelListChat.Controls.Add(tempPanel);
		}
		public async Task SendMessage()
		{
			if (TextBoxEnterChat.Text != "")
			{
				// Gửi tin nhắn qua server
				byte[] buff = new byte[1024];
				byte[] tempbuff;
				tempbuff = System.Text.Encoding.UTF8.GetBytes("SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text);
				tempbuff.CopyTo(buff, 0);
				Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);

				// tạo một panel chat 
				this.AddItemInToListChat(Form1.me, this.TextBoxEnterChat.Text);

				//clear textbox nhập chat
				TextBoxEnterChat.Text = "";
			}
		}
		public async Task SendFile()
		{
			if (this.panelListFile.Controls.Count > 0)
			{
				foreach (var item in files)
				{
					AddFileToListChat(Form1.me, "-1", item.Name);
					//Gửi
					byte[] data = File.ReadAllBytes(item.FullName);
					int temp = 1024 - (data.Length % 1024);
					byte[] package = new byte[data.Length + temp];
					data.CopyTo(package, 0);
					byte[] buff = new byte[1024];
					byte[] tempbuff;
					tempbuff = System.Text.Encoding.UTF8.GetBytes("STARTFILE%" + item.Name + "%" + data.Length.ToString() + "%" + item.Extension + "%" + user.Id);
					tempbuff.CopyTo(buff, 0);
					await Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
					await Form1.client.SendFileToServer(package);
				}
				this.files.Clear();
				this.panelListFile.Controls.Clear();
				this.panelListFile.Visible = false;
			}
		}
		private void InitUserForm()
		{
			this.labelID.Text = "#"+user.Id;
			this.labelName.Text = user.Name;
			this.pictureBoxSend.Click += PictureBoxSend_Click;
		}
		private async void PictureBoxSend_Click(object sender, EventArgs e)
		{
			await SendFile();
			await SendMessage();
		}
		public void AddFrom(Panel panelRight)
		{
			panelRight.Controls.Add(this);
		}
		private void TextBoxEnterChat_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SendMessage();
				e.SuppressKeyPress = true;
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter =
				"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
				"All files (*.*)|*.*";

			openFileDialog.Multiselect = true;
			//openFileDialog.Title = "Select Photos";		
			DialogResult dr = openFileDialog.ShowDialog();
			if (dr == DialogResult.OK)
			{
				foreach (string item in openFileDialog.FileNames)
				{
					try
					{
						FileInfo temp = new FileInfo(item);
						files.Add(temp);
						usFileTemp x = new usFileTemp(panelListFile,files, temp);
						this.panelListFile.Controls.Add(x);
						x.Dock = DockStyle.Left;
						x._FileName = temp.Name;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				panelListFile.Visible = true;
			}

		}
        private void panelListChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelENTERCHAT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCHATBOX_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxEnterChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelENTERCHATOPTION_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSEND_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSend_Click_1(object sender, EventArgs e)
        {

        }

        private void panelUSERINFO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelOPTIONUSER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

        }

        private void panelNULL2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUSERCHATINFO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelListFile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
