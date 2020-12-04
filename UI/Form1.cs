using Communication;
using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
namespace UI
{
	public partial class Form1 : Form
	{
		/// <summary>
		///QUY ĐỊNH NGƯỜI SỬ DỤNG CHƯƠNG TRÌNH CÓ BIẾN LÀ <ME>
		///NGƯỜI SỬ DỤNG SERVER LÀ USER
		/// </summary> 
		public LoginForm loginForm;
		public static List<UserUI> UserUIs; // List form giao diện chat cho từng user
		public static User me; // Nguoi su dung chuong trinh
		public static UserUI userRightForcus = null;
		public static UserUI userUIForcus = null;
		public static UserForm userFormFocus = null;
		public static SocketClient client;
		public static TcpClient server;
		public static SettingForm settingForm;
		public static FrmFriend frmFriend;
		public static List<string> listFile;
		public ServerForm serverUsersForm;
		public NetworkStream stream;
		public static List<User> listUser;
		public static Theme theme;
		
		// Tất cả các khai báo trên đều là biến tĩnh, được quyền sử dụng trọng mõi class.
		//242,243,245
		public Form1()
		{
			InitializeComponent();           
		}
		public Form1(LoginForm loginform, User user, SocketClient client, TcpClient server, string Theme)
		{
			UserUIs = new List<UserUI>();
			listUser = new List<User>();
			this.loginForm = loginform;
			Form1.client = client;
			Form1.server = server;
			Form1.me = user;
			theme = new Theme();
			if (Theme == "White")
			{
					theme.White();
			}
			else theme.Black();
			me.AvatarPath = @"../../avatarDefault.png";
			InitializeComponent();
			LoadMyData();
			LoadDataUser();
			InitServerUsersForm();
			InitFrmFriend();
			InitSettingForm();
			ChangeTheme();
			AwaitReadData(); 
		}
        private void InitSettingForm()
        {
			settingForm = new SettingForm(me, this);
			settingForm.TopLevel = false;
			settingForm.Dock = DockStyle.Fill;
			this.Controls.Add(settingForm);
			settingForm.BackColor = theme.BackColor;	
		}
        public void ChangeTheme()
		{
			this.BackColor = theme.BackColor;
			this.panelMenu.BackColor = theme.Menu;
			serverUsersForm.BackColor = theme.BackColor;
			frmFriend.BackColor = theme.BackColor;
			settingForm.BackColor = theme.BackColor;
			ChangeColorAllLabelControls(this);
			ChangeColorLine();
			ChangePicture();
			ChangeColorUserUIs();
			ChangeColorFocus();
			settingForm.ChangeColorPanelControl();
			settingForm.ChangeColorAllLabelControl(settingForm);
			serverUsersForm.ChangeColorControl();
			//frmFriend.ChangeColorControl();
		}

        private void ChangeColorFocus()
        {
			if (userUIForcus != null ) userUIForcus.ucInterac.ChangeColorWhenClick();
        }
        private void ChangeColorUserUIs()
        {
            foreach (var item in UserUIs)
            {
				item.ResetTheme();
            }
        }
        private void ChangePicture()
        {
			this.pictureBoxSetting.Image = Image.FromFile(theme.PictureOption);
            foreach (var item in UserUIs)
            {
				item.ResetPicture();
            }
			serverUsersForm.ResetPicture();
			frmFriend.ResetPicture();
			settingForm.ResetPicture();
		}
        private void ChangeColorLine()
		{
            this.pnLine.BackColor = theme.LineColor;
			this.pnLine2.BackColor = theme.LineColor;
			serverUsersForm.ChangeColorLine();
			frmFriend.ChangeColorLine();
			settingForm.ChangeColorLine();
            foreach (var item in UserUIs)
            {
				item.userForm.ChangeColorLine();
            }
		}
		private void ChangeColorAllLabelControls(Control x)
		{
			foreach (var item in x.Controls)
			{
				if (item.GetType() == typeof(Label))
				{
					(item as Label).ForeColor = theme.TextColor;
					
				}
				else
				if (item.GetType() == typeof(Button))
				{
					(item as Button).ForeColor = theme.TextColor;
				}
				else if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
				{
					(item as Guna.UI2.WinForms.Guna2Button).ForeColor = theme.TextColor;
				}

				ChangeColorAllLabelControls(item as Control);
			}
		}
		private void InitFrmFriend()
		{
			Form1.frmFriend = new FrmFriend();
			Form1.frmFriend.TopLevel = false;
			Form1.frmFriend.Dock = DockStyle.Fill;
			panelRIGHT.Controls.Add(Form1.frmFriend);
		}
		public  void LoadUser()
		{
			this.Avatar.Image = Image.FromFile(me.AvatarPath);
			this.labelUSERNAME.Text = me.Name;
			this.labelID.Text = me.Id;
		}
		private void InitServerUsersForm()
		{
			this.Text = "LM";
			serverUsersForm = new ServerForm(this);
			serverUsersForm.TopLevel = false;
			serverUsersForm.Dock = DockStyle.Fill;
			panelRIGHT.Controls.Add(serverUsersForm);
		}
		private void LoadMyData()
		{
			labelID.Text = "#"+me.Id;
			labelUSERNAME.Text = me.Name;
		}
		private async Task AwaitReadData()
		{
			bool isFile = false;
			bool isAvatar = false;
			string IDNGUOIGUI = "";
			InfoByte fileData = null;
			byte[] buff = null;
			byte[] dataFile = null;
			int count = 0;
			stream = server.GetStream();
			while (true)
			{
				/// Nhận Gói Tin
				buff = new byte[1024];
				int nReturn = await stream.ReadAsync(buff, 0, buff.Length);
				string[] data = (System.Text.Encoding.UTF8.GetString(buff, 0, nReturn).Trim('\0', '\t', '\r', '\n')).Split('%');
				/// Xử lí gói tin
				for (int i = 0; i < data.Length; i++)
				{
					data[i] = data[i].Trim('\0');
				}
				string action = data[0];
				/// Tìm hành động
				if (action == "LOADUSERDATA")
				{
					for (int i = 1; i < data.Length; i++)
					{
						if (data[i] == "") break;

						string[] arr = data[i].Split(' ');
						string path = @"..\..\avatarDefault.png";
						if (arr[1] != me.Name)
						{
							listUser.Add(new User(arr[0], arr[1], bool.Parse(arr[2]), path));
							UserUIs.Add(new UserUI(listUser[listUser.Count-1], panelINTERACTED, panelRIGHT));
						}
					}
				}
				else if (action == "MESSAGE") // MESSAGE + tin nhắn + Id người gửi 
				{
					for (int i = 0; i < UserUIs.Count; i++)
					{
						if (UserUIs[i].GetId() == data[2])
						{
							UserUIs[i].AddMessage(data[1]);
							UserUIs[i].BringToTop();
							break;
						}
					}
				}
				else if (action == "ADDUSER")
				{
					string path = @"..\..\avatarDefault.png";
					UserUIs.Add(new UserUI(new User(data[1], data[2], false, path), panelINTERACTED, panelRIGHT));
				}
				else if (action == "ONLINE")
				{
					for (int i = 0; i < UserUIs.Count; i++)
					{
						if (UserUIs[i].GetId() == data[1])
						{
							UserUIs[i].SetStatus(true);
							UserUIs[i].ChangeStatusOnline();
							break;
						}
					}
				}
				else if (action == "OFFLINE")
				{
					for (int i = 0; i < UserUIs.Count; i++)
					{
						if (UserUIs[i].GetId() == data[1])
						{
							UserUIs[i].SetStatus(false);
							UserUIs[i].ChangeStatusOffline();
							break;
						}
					}
				}
				else if (action == "FILE") //FILE - FILEID - FILENAME - FILELENGHT - ID THẰNG GỬI CÁI FILE NÀY
				{
					isFile = true;
					fileData = new InfoByte();
					fileData.ID = data[1];
					fileData.Name = data[2];
					fileData.Length = int.Parse(data[3]);
					fileData.Extension = data[4];
					IDNGUOIGUI = data[5];
					dataFile = new byte[fileData.Length];
				}
				else if (action == "TEMPFILE") //("TEMPFILE%" + Createid.ToString() + "%" + client.id_ + "%" + infoByte.Name);
				{
					string tempFileId = data[1];
					string tempidNguoiGui = data[2];
					string tempFileName = data[3];
					for (int i = 0; i < Form1.UserUIs.Count; i++)
					{
						if (UserUIs[i].GetId() == tempidNguoiGui)
						{
							UserUIs[i].AddPanelFile(tempFileId, tempFileName);
							UserUIs[i].BringToTop();
							break;
						}
					}
				}
				else if (action == "CHECKPASS")
				{
					if (data[1] == "YES")
						settingForm.RespondToChangePasswordMessage(true);
					else
						settingForm.RespondToChangePasswordMessage(false);
				}
				else if (action == "CHANGENAME")
				{
					if (data[1] == "YES")
						settingForm.RespondToChangeUsernameMessage(true);
					else
						settingForm.RespondToChangeUsernameMessage(false);
				}
				else if (action == "AVATAR") /// AVATAR + FILENAME + LENGTH + EXTENSION
				{
					isAvatar = true;
					fileData = new InfoByte();
					fileData.Name = data[1];
					fileData.Length = int.Parse(data[2]);
					fileData.Extension = data[3];
					dataFile = new byte[fileData.Length];
				}
				else if (action == "PENDING")
				{
					foreach (var item in UserUIs)
					{
						if (item.user.Id == data[1])
						{
							serverUsersForm.AddPending(item);
							serverUsersForm.EnablePointPending();
							picNotification.Visible = true;
							break;
						}
					}
				}
				else if (action == "FRIEND")
				{
					for (int i = 1; i < data.Length; i++)
					{
						if (data[i] == "") break;
						foreach (var item in UserUIs)
						{
							if (item.user.Id == data[i])
							{
								item.user.IsFriend = true;
								item.EnableRemove();
								item.DisableADD();
							}
						}
					}
				}
				else if (action == "ACCEPTFRIEND")
				{
					foreach (var item in UserUIs)
					{
						if (item.user.Id == data[1])
						{
							AddUserIntoFrmFriend(item);
							item.user.IsFriend = true;
							item.DisableADD();
							item.EnableRemove();
							break;
						}
					}
				}
				else if (action == "REMOVEFRIEND")
				{
					foreach (var item in UserUIs)
					{
						if (item.user.Id == data[1])
						{
							frmFriend.RemoveFriend(item);
							item.user.IsFriend = false;
							item.EnableADD();
							item.DisableRemove();
							break;
						}
					}
				}
				else
				{
					/// Nén gói tin bị thừa lại để vừa đủ số byte của file.
					if (buff.Length + fileData.AllByteRead > fileData.Length)
					{
						Array.Resize(ref buff, 1024 - (buff.Length + fileData.AllByteRead - fileData.Length));
					}
					buff.CopyTo(dataFile, fileData.AllByteRead);
					fileData.AllByteRead = fileData.AllByteRead + buff.Length;
					/// File đã nhận đủ
					if (fileData.AllByteRead == fileData.Length)
					{
						if (isFile == true) // Nếu file được gửi từ người dùng
						{
							isFile = false;
							_FileDialog fd = new _FileDialog();
							fd.SaveFile(dataFile, fileData.Name + fileData.Extension);
							/// AddIDIntoFile();
						}
						else if (isAvatar == true) // nếu file là Avatar
						{
							isAvatar = false;
							string path = @"..\..\cache\avatar\" + fileData.Name + fileData.Extension;
							File.WriteAllBytes(path, dataFile);
							foreach (var item in UserUIs)
							{
								if (item.user.Id == fileData.Name)
								{
									item.SetAvatar(path);
									break;
								}
								if (fileData.Name == me.Id)
								{
									this.SetAvatar(path);
									this.LoadUser();
									break;
								}
							}
							///
						}
					}
				}
			}
		}
		public void SetAvatar(string path)
		{
			me.AvatarPath = path;
		}
		private async void LoadDataUser()
		{
			byte[] buff = new byte[1024];
			byte[] tembuff = Encoding.UTF8.GetBytes("LOADUSERDATA%" + me.Name);
			tembuff.CopyTo(buff, 0);
			await server.GetStream().WriteAsync(buff, 0, buff.Length);
		}
		public static void AddUserIntoFrmFriend(UserUI userUI)
		{
			frmFriend.AddUserIntoFrmFriend(userUI);
		}
		private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] buff = new byte[1024];
			byte[] tembuff = Encoding.UTF8.GetBytes("THEME%" + (theme.IsWhite == true ? "White":"Black"));
			tembuff.CopyTo(buff, 0);
			await server.GetStream().WriteAsync(buff, 0, buff.Length);
			loginForm.Close();
		}
		public void DisableNotification()
		{
			picNotification.Visible = false;
		}
		/// <summary>
		/// Event Click
		/// </summary>
		private void pictureBoxSetting_Click(object sender, EventArgs e)
		{
			
			settingForm.Show();
			settingForm.BringToFront();
		}
		private void btnFriend_Click(object sender, EventArgs e)
		{
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				Form1.userUIForcus = null;
			}
			
			frmFriend.Show();
			frmFriend.BringToFront();
			frmFriend.Reset();
		}
		private void btnFriend_MouseMove(object sender, MouseEventArgs e)
		{
			(sender as Button).BackColor = theme.FocusColor;
		}
		private void btnFriend_MouseLeave(object sender, EventArgs e)
		{
			(sender as Button).BackColor = Color.Transparent;
		}
		private void btnServer_Click(object sender, EventArgs e)
		{
			picNotification.Visible = false;
			if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				Form1.userUIForcus = null;
			}
			serverUsersForm.Show();
			serverUsersForm.BringToFront();
		}
	}
}
