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
			this.panelLine.BackColor = Form1.theme.FocusColor;
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PicturePlus);
		
			this.pictureBoxMenu.Image = Image.FromFile(Form1.theme.PictureMenu);
	
			this.Visible = false;
			this.user = user;
			this.id = 0;
			LastInteracted = 0;
			BoxChats = new List<Panel>();
			files = new List<FileInfo>();
			InitUserForm();
		}
		public void ResetPicture()
		{
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PicturePlus);
			this.pictureBoxMenu.Image = Image.FromFile(Form1.theme.PictureMenu);
		}
		public void ChangeColorLine()
		{
			this.panelLine.BackColor = Form1.theme.LineColor;
		}
		public void InitColor()
		{
			this.labelName.ForeColor = Form1.theme.TextColor;
			this.labelID.ForeColor = Form1.theme.TextMenuColor;
			this.BackColor = Form1.theme.BackColor;
			this.TextBoxEnterChat.FillColor = Form1.theme.TxtBackColor;
			this.TextBoxEnterChat.ForeColor = Form1.theme.TxtForeColor;
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
			ucMessShow messShow = new ucMessShow(str,user);
			messShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;
			UserInChatBox._AddMessControl(messShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			this.panelListChat.Controls.Add(tempPanel);
			UserInChatBox.InitColor();
			messShow.ChangeTheme();
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
			UserInChatBox.InitColor();
			fileshow.InitColor();
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
	}
}
