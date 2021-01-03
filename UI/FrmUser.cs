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
	public partial class FrmUser : Form
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
		public List<ucUserINChatBox> userINChatBoxes;
		public FrmUser()
		{
			InitializeComponent();
			this.Visible = false;
			addpnInfo();
			ucInfoUser._LoadInfoUser(user, listfileShows);
		}
		public FrmUser(UserManager.User user, UserUI userUI)
		{
			InitializeComponent();
			
			this.pictureBox1.Image = Image.FromFile(FrmMain.theme.PicturePlus);
			//this.pictureBoxMenu.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.pictureVoice.Image = Image.FromFile(FrmMain.theme.pictureVoice);
			panelLine.BackColor = FrmMain.theme.LineColor;
			this.userUI = userUI;
			this.Visible = false;
			this.user = user;
			this.id = 0;
			LastInteracted = 0;
			BoxChats = new List<Panel>();
			files = new List<FileInfo>();
			userINChatBoxes = new List<ucUserINChatBox>();
			InitUserForm();
			voicePanel = new ucVoicePanel(user, this);
			this.Controls.Add(voicePanel);
			this.SizeChanged += UserForm_SizeChanged;
			this.panel2.SizeChanged += UserForm_SizeChanged;
			addpnInfo();
			ucInfoUser._LoadInfoUser(user, listfileShows);
			InitColor();
		}

		private void UserForm_SizeChanged(object sender, EventArgs e)
		{
			Point point = panel4.Location;
			voicePanel.Location = new Point(point.X - voicePanel.Width / 2 + 18,
											this.Height - 50 - voicePanel.Height);
		}

		public void ResetPicture()
		{
			this.pictureBox1.Image = Image.FromFile(FrmMain.theme.PicturePlus);
			//this.pictureBoxMenu.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.pictureVoice.Image = Image.FromFile(FrmMain.theme.pictureVoice);
		}
		public void ChangeColorLine()
		{
			this.panelLine.BackColor = FrmMain.theme.LineColor;
		}
		public void InitColor()
		{
			this.labelName.ForeColor = FrmMain.theme.TextColor;
			this.labelID.ForeColor = FrmMain.theme.TextMenuColor;
			panelLine.BackColor = FrmMain.theme.LineColor;
			this.BackColor = FrmMain.theme.BackColor;
			this.pictureVoice.Image = Image.FromFile(FrmMain.theme.pictureVoice);
			voicePanel.InitControls();
			this.TextBoxEnterChat.BackColor = FrmMain.theme.Menu;
			this.TextBoxEnterChat.ForeColor = FrmMain.theme.TxtForeColor;
			this.panel1.BackColor = FrmMain.theme.Menu;
            foreach (var item in userINChatBoxes)
            {
				item.InitColor();
            }
			this.ucInfoUser.InitControls();
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
			if (user.Id != FrmMain.me.Id) UserInChatBox.DisableEdit();
			ucMessShow messShow = new ucMessShow(str, user, UserInChatBox);
			messShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;
			UserInChatBox._AddMessControl(messShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			this.panelListChat.Controls.Add(tempPanel);
			UserInChatBox.InitColor();
			messShow.ChangeTheme();

			if (IDMess == "-1") FrmMain.listMessAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;
			userINChatBoxes.Add(UserInChatBox);
		}
		public void AddFileToListChat(User _user, string tempID, string tempName)
		{
			userUI.ucInterac.AddMessage(user.Name + ": " + "Send a file");

			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox UserInChatBox = new ucUserINChatBox(_user, this.user.Id);
			UserInChatBox.DisableEdit();
			ucFileShow fileshow = new ucFileShow(_user, tempID, tempName, UserInChatBox);
			//if (_user == Form1.me) fileshow._DisableButDownLoad();
			fileshow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;

			UserInChatBox._AddFileControl(fileshow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			UserInChatBox.InitColor();
			fileshow.InitColor();

			if (tempID == "-1") FrmMain.listFileAwaitID.Add(UserInChatBox);// Thêm vào hàng đợi ID file từ server gửi xuống
			else UserInChatBox.ID = tempID;
			
			listfileShows.Add(fileshow);
			userINChatBoxes.Add(UserInChatBox);
		}
		public void AddVoiceMessage(User _user, string path, string id)
		{
			userUI.ucInterac.AddMessage(_user.Name + ": " + "Send a voice");

			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox userINChatBox = new ucUserINChatBox(_user, this.user.Id);
			userINChatBox.DisableEdit();
			//userINChatBox.DisableDelete();
			ucVoiceMessage voiceMessage = new ucVoiceMessage(path, userINChatBox);
			voiceMessage.Path = path;
			voiceMessage.Dock = DockStyle.Top;
			userINChatBox.Dock = DockStyle.Top;

			userINChatBox._AddVoiceMessage(voiceMessage);
			tempPanel.Controls.Add(userINChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			userINChatBox.InitColor();
			// voiceMessage.InitColor();

			if (id == "-1") FrmMain.listVoiceAwaitID.Add(userINChatBox);// Thêm vào hàng đợi ID file từ server gửi xuống
			else userINChatBox.ID = id;
			userINChatBoxes.Add(userINChatBox);
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
			try
			{
				if (TextBoxEnterChat.Text != "")
				{
					// Gửi tin nhắn qua server
					byte[] tempbuff = Encoding.UTF8.GetBytes("SEND%" + FrmMain.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
					// tạo một panel chat 
					this.AddItemInToListChat(FrmMain.me, "-1", this.TextBoxEnterChat.Text);
					this.userUI.AddMessageIntoInteract(FrmMain.me.Name, TextBoxEnterChat.Text);
					//clear textbox nhập chat
					TextBoxEnterChat.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public async Task SendFile()
		{
			try
			{
				if (this.panelListFile.Controls.Count > 0)
				{
					foreach (var item in files)
					{
						if (item.Length > 3000000)
						{
							MessageBox.Show("Size file small than 3 Mb", "Error", MessageBoxButtons.OK);
							return;
						}
					}
				}
				if (this.panelListFile.Controls.Count > 0)
				{
					foreach (var item in files)
					{
						AddFileToListChat(FrmMain.me, "-1", item.Name);
						//Gửi
						byte[] data = File.ReadAllBytes(item.FullName);
						Guid id = Guid.NewGuid();

						byte[] tempbuff = Encoding.UTF8.GetBytes("STARTSENDFILE%" + user.Id + "%" + data.Length.ToString() + "%" + item.Name + "%" + item.Extension + "%"
																+ id.ToString() + "%" + "Private");
						SmallPackage smallpackage = new SmallPackage(0, 1024, "M", tempbuff, "0");
						FrmMain.server.GetStream().WriteAsync(smallpackage.Packing(), 0, smallpackage.Packing().Length);
						await FrmMain.client.SendFileToServer(data, "F", id.ToString());
					}
					this.files.Clear();
					this.panelListFile.Controls.Clear();
					this.panelListFile.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		public bool isVoicePanelShow = false;
		private void pictureVoice_Click_1(object sender, EventArgs e)
		{
			if (!isVoicePanelShow)
			{
				voicePanel.Visible = true;
				voicePanel.InitControls();
				voicePanel.Show();
				voicePanel.BringToFront();
				isVoicePanelShow = true;
			}
			else
			{
				voicePanel.Visible = false;	
				isVoicePanelShow = false;
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
						ucFileTemp x = new ucFileTemp(panelListFile, files, temp);
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
			if (FrmMain.chatBoxFocus != null)
			{
				FrmMain.chatBoxFocus.BackColor = Color.Transparent;
				FrmMain.chatBoxFocus.DisableMenu();
			}
			await SendFile();
			await SendMessage();
		}

		private async void TextBoxEnterChat_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (FrmMain.chatBoxFocus != null)
				{
					FrmMain.chatBoxFocus.BackColor = Color.Transparent;
					FrmMain.chatBoxFocus.DisableMenu();
				}
				await SendFile();
				await SendMessage();
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
