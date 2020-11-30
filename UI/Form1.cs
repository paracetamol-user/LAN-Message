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
		public static List<string> listFile;
		public ServerForm serverUsersForm;
		public NetworkStream stream;


		// Tất cả các khai báo trên đều là biến tĩnh, được quyền sử dụng trọng mõi class.
		//242,243,245
		public Form1()
		{
			InitializeComponent();           
		}
		public Form1(LoginForm loginform, User user, SocketClient client , TcpClient server)
		{
			UserUIs = new List<UserUI>();
			this.loginForm = loginform;
			Form1.client = client;
			Form1.server = server;
			Form1.me = user;
			me.AvatarPath = @"../../avatarDefault.png";
			InitializeComponent();
			LoadMyData();
			LoadDataUser();
			InitServerUsersForm();
			AwaitReadData(); 
		}
		public void LoadUser()
        {
			this.Avatar.Image = Image.FromFile(me.AvatarPath);
			this.labelUSERNAME.Text = me.Name;
			this.labelID.Text = me.Id;
        }
		private void InitServerUsersForm()
		{
			this.Text = "LM";
			serverUsersForm = new ServerForm();
			serverUsersForm.TopLevel = false;
			serverUsersForm.Dock = DockStyle.Fill;
			panelRIGHT.Controls.Add(serverUsersForm);
		}
		private void LoadMyData()
		{
			labelID.Text = "#"+me.Id;
			labelUSERNAME.Text = me.Name;
		}
		// AwaitReadData chờ và nhận tin nhắn từ server
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
				string[] data = (System.Text.Encoding.UTF8.GetString(buff,0,nReturn).Trim('\0', '\t', '\r', '\n')).Split('%');
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
							UserUIs.Add(new UserUI(new User(arr[0], arr[1], bool.Parse(arr[2]), path), panelINTERACTED, panelRIGHT));
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
					UserUIs.Add(new UserUI(new User(data[1], data[2], false,path), panelINTERACTED, panelRIGHT));
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
							if (!File.Exists(path)) //File.Delete(path);
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
		//LoadDataUser gọi server trả về tất cả người dùng có trong server
		private async void LoadDataUser()
		{
            byte[] buff = new byte[1024];
			byte[] tembuff = Encoding.UTF8.GetBytes("LOADUSERDATA%" + me.Name);
			tembuff.CopyTo(buff, 0);
			await server.GetStream().WriteAsync(buff, 0, buff.Length);
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			loginForm.Close();
		}

		private void ButtonLanMessenger_Click(object sender, EventArgs e)
		{
			if (Form1.userFormFocus != null) Form1.userFormFocus.Hide();
			if (Form1.userUIForcus != null)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				Form1.userUIForcus = null;
			}
			serverUsersForm.Show();
			serverUsersForm.BringToFront();
		}

        private void pictureBoxSetting_Click(object sender, EventArgs e)
        {
			settingForm = new SettingForm(me, this);
			settingForm.TopLevel = false;
			settingForm.Dock = DockStyle.Fill;
			this.panelRIGHT.Controls.Add(settingForm);
			settingForm.Show();
			settingForm.BringToFront();
		}
    }
}
