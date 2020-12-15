﻿using Communication;
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
using Network;

namespace UI
{
	public partial class UserForm : Form
	{
		
		public User user;
		private List<Panel> BoxChats;
		private int id;
		private List<FileInfo> files;
		private short LastInteracted;
		public ucUserINChatBox messageFocus;
		public UserUI userUI;
		public ucInforuser ucInforuser;
		public List<ucFileShow> listfileShows=new List<ucFileShow>();
		public UserForm()
		{
			InitializeComponent();
			this.Visible = false;
			addpnInfor();
			ucInforuser._LoadInforUser(user, listfileShows);
			isclickmenu = false;
		}
		public UserForm(UserManager.User user , UserUI userUI)
		{
			InitializeComponent();
			this.panelLine.BackColor = Form1.theme.FocusColor;
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PicturePlus);
		
			this.pictureBoxMenu.Image = Image.FromFile(Form1.theme.PictureMenu);
			this.userUI = userUI;
			this.Visible = false;
			
			this.user = user;
			this.id = 0;
			LastInteracted = 0;
			BoxChats = new List<Panel>();
			files = new List<FileInfo>();
			InitUserForm();
			addpnInfor();
			ucInforuser._LoadInforUser(user, listfileShows);
			isclickmenu = false;
		}
		public Panel Pncontaininfor
		{
			get
			{
				return this.pncontaininfo;
			}
			set
            {
				pncontaininfo = value;
            }
		}
		public Panel PnLine1
		{
			get
			{
				return this.pnLine1;
			}
			set
            {
				this.pnLine1 = value;
            }
		}
		public void ResetPicture()
		{
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PicturePlus);
			this.pictureBoxMenu.Image = Image.FromFile(Form1.theme.PictureMenu);
		}
		public void ChangeColorLine()
		{
			this.panelLine.BackColor = Form1.theme.LineColor;
			this.pnLine1.BackColor = Form1.theme.LineColor;
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
		public void AddItemInToListChat(User user,string IDMess, string str)
		{
			Panel tempPanel = new Panel();
			tempPanel.Dock = DockStyle.Top;
			tempPanel.AutoSize = true;
			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user,this.user.Id);
			if (user.Id != Form1.me.Id) UserInChatBox.DisableEdit(); 
			ucMessShow messShow = new ucMessShow(str,user,UserInChatBox);
			messShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;
			UserInChatBox._AddMessControl(messShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			this.panelListChat.Controls.Add(tempPanel);
			UserInChatBox.InitColor();
			messShow.ChangeTheme();

			if (IDMess == "-1") Form1.listMessAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;
		}
		public void AddFileToListChat(User _user,string tempID, string tempName)
		{
			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox UserInChatBox = new ucUserINChatBox(_user,this.user.Id);
			UserInChatBox.DisableEdit();
			ucFileShow fileshow = new ucFileShow(_user, tempID, tempName,UserInChatBox);
			if (_user == Form1.me) fileshow._DisableButDownLoad();
			fileshow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;

			UserInChatBox._AddFileControl(fileshow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			UserInChatBox.InitColor();
			fileshow.InitColor();
			listfileShows.Add(fileshow);

			if (tempID == "-1") Form1.listFileAwaitID.Add(UserInChatBox);// Thêm vào hàng đợi ID file từ server gửi xuống
			else UserInChatBox.ID = tempID;
		}
		public void EditMessage(string IDMess, string newMess)
		{
			foreach (var item in this.panelListChat.Controls)
			{
				if (item.GetType() == typeof(Panel))
				{
					foreach (var item2 in (item as Panel).Controls)
					{
						if ((item2 as ucUserINChatBox).ID == IDMess)
						{
							(item2 as ucUserINChatBox).EditMessage(newMess);
							return;
						}
					}
				}
			}
		}
		public void DeleteMessage(string IDMess)
		{
			foreach (var item in this.panelListChat.Controls)
			{
				if (item.GetType() == typeof(Panel))
				{
					foreach (var item2 in (item as Panel).Controls)
					{
						if ((item2 as ucUserINChatBox).ID == IDMess)
						{
							(item2 as ucUserINChatBox).DeleteMessage(IDMess);
							return;
						}
					}
				}
			}
		}
		public async Task SendMessage()
		{
			if (TextBoxEnterChat.Text != "")
			{
				// Gửi tin nhắn qua server
				byte[] tempbuff = Encoding.UTF8.GetBytes("SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
				// tạo một panel chat 
				this.AddItemInToListChat(Form1.me,"-1", this.TextBoxEnterChat.Text);
				this.userUI.AddMessageIntoInteract(Form1.me.Name, TextBoxEnterChat.Text);
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
					if (item.Length > 3000000)
					{
						MessageBox.Show("Size file small than 4 Mb", "Error", MessageBoxButtons.OK);
						return;
					}
				}
			}
			if (this.panelListFile.Controls.Count > 0)
			{
			foreach (var item in files)
			{
				AddFileToListChat(Form1.me, "-1", item.Name);
				//Gửi
				byte[] data = File.ReadAllBytes(item.FullName);
				Guid id = Guid.NewGuid();

				byte[] tempbuff = Encoding.UTF8.GetBytes("STARTSENDFILE%" + user.Id +"%" + data.Length.ToString()  + "%" + item.Name + "%" + item.Extension + "%"
														+ id.ToString() +"%" + "Private");
				SmallPackage smallpackage = new SmallPackage(0, 1024, "M", tempbuff, "0");
				Form1.server.GetStream().WriteAsync(smallpackage.Packing(), 0, smallpackage.Packing().Length);
				await Form1.client.SendFileToServer(data, "F", id.ToString()) ;
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
			this.pictureBoxSend.Click += pictureBox1_Click_1;
		}
		public void AddFrom(Panel panelRight)
		{
			panelRight.Controls.Add(this);
		}
		private void pictureBox1_Click_1(object sender, EventArgs e)
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
						usFileTemp x = new usFileTemp(panelListFile, files, temp);
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

        private void TextBoxEnterChat_KeyDown_1(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				if (Form1.chatBoxFocus != null)
				{
					Form1.chatBoxFocus.BackColor = Color.Transparent;
					Form1.chatBoxFocus.DisableMenu();
				}
				SendMessage();
				e.SuppressKeyPress = true;
			}
		}

        private async void pictureBoxSend_Click_1(object sender, EventArgs e)
        {
			if (Form1.chatBoxFocus != null)
			{
				Form1.chatBoxFocus.BackColor = Color.Transparent;
				Form1.chatBoxFocus.DisableMenu();
			}
			await SendFile();
			await SendMessage();
		}
		public void addpnInfor()
        {
			this.ucInforuser = new ucInforuser(this);
			this.ucInforuser._LoadInforUser(user, listfileShows);
			this.pncontaininfo.Visible = false;
		}
		bool isclickmenu = false;
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
			
			isclickmenu =! isclickmenu;
			pncontaininfo.AutoScroll = true;
			if(isclickmenu)
            {
				this.ucInforuser._LoadInforUser(user, listfileShows);
				
				this.pncontaininfo.Visible = true;
            }
			else
            {
				this.pncontaininfo.Visible = false;
            }
		
        }
		public void _clearlistchat()
        {
			panelListChat.Controls.Clear();
        }
		
    }
}
