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
	public partial class GroupForm : Form
	{
		private Group group;
		private List<Panel> BoxChats;
		private int ID;
		private List<FileInfo> files;
		private short LastInteracted;
		public GroupUI GroupUI;
		public ucInforGroup ucInforGroup;
		public List<ucFileShow> listfileShows = new List<ucFileShow>();
		public GroupForm()
		{
			InitializeComponent();
			this.Visible = false;
			addpnInfor();
			this.ucInforGroup._LoadInforGroup(group, listfileShows);
		}
		public GroupForm(Group group , GroupUI grUI)
		{
			InitializeComponent();
			InitColor();
			this.Visible = false;
			this.group = group;
			this.ID = 0;
			this.GroupUI = grUI;
			this.labelName.Text = group.Name;
			this.labelID.Text = group.ID;
			LastInteracted = 0;
			BoxChats = new List<Panel>();
			files = new List<FileInfo>();
			InitGroupForm();
			addpnInfor();
			this.ucInforGroup._LoadInforGroup(group, listfileShows);
		}
		public void InitColor()
		{
			this.labelName.ForeColor = Form1.theme.TextColor;
			this.labelID.ForeColor = Form1.theme.TextMenuColor;
			this.BackColor = Form1.theme.BackColor;
			this.TextBoxEnterChat.FillColor = Form1.theme.TxtBackColor;
			this.TextBoxEnterChat.ForeColor = Form1.theme.TxtForeColor;
			this.pictureBox1.Image = Image.FromFile(Form1.theme.PicturePlus);
			this.pictureBoxMenu.Image = Image.FromFile(Form1.theme.PictureMenu);
		}
		public void AddItemToListChat(User user, string IDMess,string str)
		{
			Panel tempPanel = new Panel();
			tempPanel.Dock = DockStyle.Top;
			tempPanel.AutoSize = true;
			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user, group.ID);
			ucMessShow messShow = new ucMessShow(str,user,UserInChatBox);
			if (user.Id != Form1.me.Id) UserInChatBox.DisableEdit();
			messShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;
			UserInChatBox._AddMessControl(messShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			this.panelListChat.Controls.Add(tempPanel);

			if (IDMess == "-1") Form1.listMessAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;
		}
		public void AddFileToListChat(User user,string IDMess, string tempName)
		{
			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user, group.ID);
			ucFileShow fileShow = new ucFileShow(user, IDMess, tempName,UserInChatBox);
			UserInChatBox.DisableEdit();
			if (user == Form1.me)
				fileShow._DisableButDownLoad();
			fileShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;

			UserInChatBox._AddFileControl(fileShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			if (IDMess == "-1") Form1.listFileAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;

			listfileShows.Add(fileShow);
		}
		public async Task SendMessage()
		{
			if (TextBoxEnterChat.Text.Trim() != "")
			{
				byte[] tempbuff = Encoding.UTF8.GetBytes("GSEND%" + group.ID + "%" +
															Form1.me.Id + "%" +
															this.TextBoxEnterChat.Text);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);

				this.AddItemToListChat(Form1.me,"-1", this.TextBoxEnterChat.Text);
				this.GroupUI.AddMessageIntoInteract(Form1.me.Name, TextBoxEnterChat.Text);
				TextBoxEnterChat.Text = string.Empty;
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
					Guid id = Guid.NewGuid();

					byte[] tempbuff = Encoding.UTF8.GetBytes("STARTSENDFILE%" + group.ID + "%"+ data.Length.ToString()+ "%" + item.Name  +"%" + item.Extension + "%"
															+ id.ToString() + "%" + "Public");
					SmallPackage Smallpackage = new SmallPackage(0, 1024, "M", tempbuff, "0");
					await Form1.server.GetStream().WriteAsync(Smallpackage.Packing(), 0, Smallpackage.Packing().Length);
				 Form1.client.SendFileToServer(data, "F", id.ToString()); ;
				}
				this.files.Clear();
				this.panelListFile.Controls.Clear();
				this.panelListFile.Visible = false;
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

		private void pictureVoice_Click(object sender, EventArgs e)
		{

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
		public void addpnInfor()
		{
			this.ucInforGroup = new ucInforGroup(this);
			this.ucInforGroup._LoadInforGroup(group, listfileShows);
			this.panel1.Visible = false;
		}
		bool isclickmenu = false;
		public void _clearlistchat()
		{
			this.panelListChat.Controls.Clear();
		}

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
			isclickmenu = !isclickmenu;
			panel1.AutoScroll = true;
			if (isclickmenu)
			{
				this.ucInforGroup._LoadInforGroup(group, listfileShows);

				this.panel1.Visible = true;
			}
			else
			{
				this.panel1.Visible = false;
			}
		}
    }
}
