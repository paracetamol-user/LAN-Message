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
		public ucVoicePanel voicePanel;
		public UserUI userUI;
		public ucInfoUser ucInfoUser;
		public List<ucFileShow> listfileShows = new List<ucFileShow>();
		public UserForm()
		{
			InitializeComponent();
			this.Visible = false;
			addpnInfo();
			ucInfoUser._LoadInfoUser(user, listfileShows);
		}
		public UserForm(UserManager.User user, UserUI userUI)
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
			voicePanel = new ucVoicePanel(user, this);
			this.Controls.Add(voicePanel);
			this.SizeChanged += UserForm_SizeChanged;
			addpnInfo();
			ucInfoUser._LoadInfoUser(user, listfileShows);
		}

		private void UserForm_SizeChanged(object sender, EventArgs e)
		{
			Point point = panel4.Location;
			voicePanel.Location = new Point(point.X - voicePanel.Width / 2 + 10,
											this.Height - 50 - voicePanel.Height);
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
			//this.TextBoxEnterChat.FillColor = Form1.theme.TxtBackColor;
			//this.TextBoxEnterChat.ForeColor = Form1.theme.TxtForeColor;
		}
		public void SetAvatar(string path)
		{

		}
		public void AddItemInToListChat(User user, string IDMess, string str)
		{
			Panel tempPanel = new Panel();
			tempPanel.Dock = DockStyle.Top;
			tempPanel.AutoSize = true;
			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user, this.user.Id);
			if (user.Id != Form1.me.Id) UserInChatBox.DisableEdit();
			ucMessShow messShow = new ucMessShow(str, user, UserInChatBox);
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
		public void AddFileToListChat(User _user, string tempID, string tempName)
		{
			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox UserInChatBox = new ucUserINChatBox(_user, this.user.Id);
			UserInChatBox.DisableEdit();
			ucFileShow fileshow = new ucFileShow(_user, tempID, tempName, UserInChatBox);
			if (_user == Form1.me) fileshow._DisableButDownLoad();
			fileshow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;

			UserInChatBox._AddFileControl(fileshow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			UserInChatBox.InitColor();
			fileshow.InitColor();

			if (tempID == "-1") Form1.listFileAwaitID.Add(UserInChatBox);// Thêm vào hàng đợi ID file từ server gửi xuống
			else UserInChatBox.ID = tempID;
			
			listfileShows.Add(fileshow);
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
				this.AddItemInToListChat(Form1.me, "-1", this.TextBoxEnterChat.Text);
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

					byte[] tempbuff = Encoding.UTF8.GetBytes("STARTSENDFILE%" + user.Id + "%" + data.Length.ToString() + "%" + item.Name + "%" + item.Extension + "%"
															+ id.ToString() + "%" + "Private");
					SmallPackage smallpackage = new SmallPackage(0, 1024, "M", tempbuff, "0");
					Form1.server.GetStream().WriteAsync(smallpackage.Packing(), 0, smallpackage.Packing().Length);
					await Form1.client.SendFileToServer(data, "F", id.ToString());
				}
				this.files.Clear();
				this.panelListFile.Controls.Clear();
				this.panelListFile.Visible = false;
			}
		}
		private void InitUserForm()
		{
			this.labelID.Text = "#" + user.Id;
			this.labelName.Text = user.Name;

		}

		public void AddFrom(Panel panelRight)
		{
			panelRight.Controls.Add(this);
		}

		public void AddVoiceMessage(User _user, string path)
		{
			Panel tempPanel = new Panel();
			tempPanel.AutoSize = false;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox userINChatBox = new ucUserINChatBox(_user, this.user.Id);
			userINChatBox.DisableEdit();
			ucVoiceMessage voiceMessage = new ucVoiceMessage(path, userINChatBox);
			voiceMessage.Path = path;
			voiceMessage.Dock = DockStyle.Top;
			userINChatBox.Dock = DockStyle.Top;

			userINChatBox._AddVoiceMessage(voiceMessage);
			tempPanel.Controls.Add(userINChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			userINChatBox.InitColor();
			// voiceMessage.InitColor();
		}

		private bool isShow;


		private void pictureVoice_Click_1(object sender, EventArgs e)
		{
			if (!isShow)
			{
				voicePanel.Visible = true;
				voicePanel.Show();
				voicePanel.BringToFront();
				isShow = true;
			}
			else
			{
				voicePanel.Visible = false;
				isShow = false;
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

		private void TextBoxEnterChat_KeyDown(object sender, KeyEventArgs e)
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
		public Panel Pncontaininfo
		{
			get
			{
				return this.panel1;
			}
			set
			{
				panel1 = value;
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
		public void addpnInfo()
		{
			this.ucInfoUser = new ucInfoUser(this);
			this.ucInfoUser._LoadInfoUser(user, listfileShows);
			this.panel1.Visible = false;
		}
		bool isclickmenu = false;
		public void _clearlistchat()
		{
			panelListChat.Controls.Clear();
		}

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
			isclickmenu = !isclickmenu;
			panel1.AutoScroll = true;
			if (isclickmenu)
			{
				this.ucInfoUser._LoadInfoUser(user, listfileShows);

				this.panel1.Visible = true;
			}
			else
			{
				this.panel1.Visible = false;
			}
		}
    }
}
