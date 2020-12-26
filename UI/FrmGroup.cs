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
	public partial class FrmGroup : Form
	{
		private Group group;
		private List<Panel> BoxChats;
		private int ID;
		private List<FileInfo> files;
		private short LastInteracted;
		public GroupUI GroupUI { get; set; }
		public ucVoicePanel voicePanel;
		public ucInfoGroup ucInfoGroup;
		public List<ucFileShow> listfileShows = new List<ucFileShow>();
		public List<ucUserINChatBox> userINChatBoxes;
		public FrmGroup()
		{
			InitializeComponent();
			this.Visible = false;
			addpnInfo();
			this.ucInfoGroup._LoadInfoGroup(group, listfileShows);
		}
		public FrmGroup(Group group , GroupUI grUI)
		{
			InitializeComponent();
	
			this.Visible = false;
			this.group = group;
			this.ID = 0;
			this.GroupUI = grUI;
			this.labelName.Text = group.Name;
			this.labelID.Text = group.ID;
			LastInteracted = 0;
			BoxChats = new List<Panel>();
			files = new List<FileInfo>();
			voicePanel = new ucVoicePanel(group, this);
			userINChatBoxes = new List<ucUserINChatBox>();
			this.Controls.Add(voicePanel);
			this.SizeChanged += GroupForm_SizeChanged;
            this.panel2.SizeChanged += GroupForm_SizeChanged;
			InitGroupForm();
			addpnInfo();
			this.ucInfoGroup._LoadInfoGroup(group, listfileShows);
			InitColor();
		}

        private void GroupForm_SizeChanged(object sender, EventArgs e)
        {
			Point point = panel4.Location;
			voicePanel.Location = new Point(point.X - voicePanel.Width / 2 + 20,
											this.Height - 50 - voicePanel.Height);
		}

        public void InitColor()
		{
			
			this.labelName.ForeColor = FrmMain.theme.TextColor;
			this.labelID.ForeColor = FrmMain.theme.TextMenuColor;
			this.BackColor = FrmMain.theme.BackColor;
			panelLine.BackColor = FrmMain.theme.LineColor;
			
			this.TextBoxEnterChat.ForeColor = FrmMain.theme.TxtForeColor;
			this.TextBoxEnterChat.BackColor = FrmMain.theme.Menu;
			this.pictureBox1.Image = Image.FromFile(FrmMain.theme.PicturePlus);
			//this.pictureBoxMenu.Image = Image.FromFile(FrmMain.theme.PictureMenu);
			this.pictureVoice.Image = Image.FromFile(FrmMain.theme.pictureVoice);
			this.panel1.BackColor = FrmMain.theme.Menu;
			foreach (var item in userINChatBoxes)
			{
				item.InitColor();
			}
			ucInfoGroup.InitControls();
		}
		public void AddItemToListChat(User user, string IDMess,string str)
		{
			Panel tempPanel = new Panel();
			tempPanel.Dock = DockStyle.Top;
			tempPanel.AutoSize = true;
			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user, group.ID);
			ucMessShow messShow = new ucMessShow(str,user,UserInChatBox);
			if (user.Id != FrmMain.me.Id) UserInChatBox.DisableEdit();
			messShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;
			UserInChatBox._AddMessControl(messShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			this.panelListChat.Controls.Add(tempPanel);

			if (IDMess == "-1") FrmMain.listMessAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;
			userINChatBoxes.Add(UserInChatBox);
		}
		public void AddFileToListChat(User user,string IDMess, string tempName)
		{
			GroupUI.ucGroupInteract.AddMessage(user.Name + ": " + "Send a file");

			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user, group.ID);
			ucFileShow fileShow = new ucFileShow(user, IDMess, tempName,UserInChatBox);
			UserInChatBox.DisableEdit();
			//if (user == FrmMain.me)
			//	fileShow._DisableButDownLoad();
			fileShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;

			UserInChatBox._AddFileControl(fileShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			if (IDMess == "-1") FrmMain.listFileAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;

			listfileShows.Add(fileShow);
			userINChatBoxes.Add(UserInChatBox);
		}
		public async Task SendMessage()
		{
			try
            {
				if (TextBoxEnterChat.Text.Trim() != "")
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("GSEND%" + group.ID + "%" +
																FrmMain.me.Id + "%" +
																this.TextBoxEnterChat.Text);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);

					this.AddItemToListChat(FrmMain.me, "-1", this.TextBoxEnterChat.Text);
					this.GroupUI.AddMessageIntoInteract(FrmMain.me.Name, TextBoxEnterChat.Text);
					TextBoxEnterChat.Text = string.Empty;
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
						AddFileToListChat(FrmMain.me, "-1", item.Name);
						//Gửi
						byte[] data = File.ReadAllBytes(item.FullName);
						Guid id = Guid.NewGuid();

						byte[] tempbuff = Encoding.UTF8.GetBytes("STARTSENDFILE%" + group.ID + "%" + data.Length.ToString() + "%" + item.Name + "%" + item.Extension + "%"
																+ id.ToString() + "%" + "Public");
						SmallPackage Smallpackage = new SmallPackage(0, 1024, "M", tempbuff, "0");
						await FrmMain.server.GetStream().WriteAsync(Smallpackage.Packing(), 0, Smallpackage.Packing().Length);
						FrmMain.client.SendFileToServer(data, "F", id.ToString()); ;
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

		public void InitGroupForm()
		{
			this.labelID.Text = string.Format("#{0}", group.ID);
			this.labelName.Text = group.Name;

		}
		public void SetAvatar(string path)
		{

		}

		public void AddFrom(Panel panelRight)
		{
			panelRight.Controls.Add(this);
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

		public void AddVoiceMessage(User _user, string path)
        {
			GroupUI.ucGroupInteract.AddMessage(_user.Name + ": " + "Send a voice");

			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox userINChatBox = new ucUserINChatBox(_user, group.ID);
			userINChatBox.DisableDelete();
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
			userINChatBoxes.Add(userINChatBox);
		}

		public bool isVoicePanelShow;
		private void pictureVoice_Click(object sender, EventArgs e)
		{
			if (!isVoicePanelShow)
			{
				voicePanel.Visible = true;
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

		private async void pictureBoxSend_Click(object sender, EventArgs e)
		{
			await SendFile();
			await SendMessage();
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
		public Panel Pncontaininfor
		{
			get
			{
				return this.panel1;
			}
			set
			{
				this.panel1 = value;
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
			this.ucInfoGroup = new ucInfoGroup(this);
			this.ucInfoGroup._LoadInfoGroup(group, listfileShows);
			this.panel1.Visible = false;
		}
		bool isclickmenu = false;
		public void _clearlistchat()
		{
			this.panelListChat.Controls.Clear();
		}

		
        private void pictureBoxMenu_Click_1(object sender, EventArgs e)
        {
			isclickmenu = !isclickmenu;
			panel1.AutoScroll = true;
			if (isclickmenu)
			{
				this.ucInfoGroup._LoadInfoGroup(group, listfileShows);
				this.panel1.Visible = true;
			}
			else
			{
				this.panel1.Visible = false;
			}
			
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
	}
}
