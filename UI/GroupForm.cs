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
		public GroupForm()
		{
			InitializeComponent();
			this.Visible = false;
		}
		public GroupForm(Group group , GroupUI grUI)
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
			InitGroupForm();
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
		public void AddFileToListChat(User user,string IDMess, string tempId, string tempName)
		{
			Panel tempPanel = new Panel();
			tempPanel.AutoSize = true;
			tempPanel.Dock = DockStyle.Top;

			ucUserINChatBox UserInChatBox = new ucUserINChatBox(user, group.ID);
			ucFileShow fileShow = new ucFileShow(user, tempId, tempName,UserInChatBox);
			UserInChatBox.DisableEdit();
			if (user == Form1.me)
				fileShow._DisableButDownLoad();
			fileShow.Dock = DockStyle.Top;
			UserInChatBox.Dock = DockStyle.Top;

			UserInChatBox._AddFileControl(fileShow);
			tempPanel.Controls.Add(UserInChatBox);
			this.panelListChat.Controls.Add(tempPanel);
			if (IDMess == "-1") Form1.listMessAwaitID.Add(UserInChatBox); // Thêm vào hàng đợi ID ti nhan từ server gửi xuống
			else UserInChatBox.ID = IDMess;
		}
		public async Task SendMessage()
		{
			if (TextBoxEnterChat.Text.Trim() != "")
			{
				byte[] buff = new byte[1024];
				byte[] tempBuff;
				tempBuff = Encoding.UTF8.GetBytes("GSEND%" + group.ID + "%" +
															Form1.me.Id + "%" +
															this.TextBoxEnterChat.Text);
				tempBuff.CopyTo(buff, 0);
				Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);

				this.AddItemToListChat(Form1.me,"-1", this.TextBoxEnterChat.Text);
				this.GroupUI.AddMessageIntoInteract(Form1.me.Name, TextBoxEnterChat.Text);
				TextBoxEnterChat.Text = string.Empty;
			}
		}
		public void InitGroupForm()
		{
			this.labelID.Text = string.Format("#{0}", group.ID);
			this.labelName.Text = group.Name;
			this.pictureBoxSend.Click += PictureBoxSend_Click;
		}
		public void SetAvatar(string path)
		{

		}
		private async void PictureBoxSend_Click(object sender, EventArgs e)
		{
			await SendMessage();
		}
		public void AddFrom(Panel panelRight)
		{
			panelRight.Controls.Add(this);
		}

		private void TextBoxEnterChat_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
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
	}
}
