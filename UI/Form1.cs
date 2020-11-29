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

			InitializeComponent();
			LoadMyData();
			LoadDataUser();
			InitServerUsersForm();
			AwaitReadData(); 
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
			string FILEID = "";
			string FILENAME = "";
			string ID = "";
			int FILELENGHT= 0;
			InfoByte infoByte = null;
			byte[] buff = null;
			byte[] dataFile = null;
			stream = server.GetStream();
			while (true)
			{
				buff = new byte[1024];
				int nReturn = await stream.ReadAsync(buff, 0, buff.Length);
				string[] data = (System.Text.Encoding.UTF8.GetString(buff,0,nReturn).Trim('\0', '\t', '\r', '\n')).Split('%');
				for (int i = 0; i < data.Length; i++)
				{
					data[i] = data[i].Trim('\0');
				}
				string action = data[0];
				if (action == "LOADUSERDATA")
                {
					for (int i = 1; i < data.Length; i++)
					{
						if (data[i] == "") break;
						string[] arr = data[i].Split(' ');
						if (arr[1] != me.Name)
						{
							UserUIs.Add(new UserUI(new User(arr[0], arr[1], bool.Parse(arr[2])), panelINTERACTED, panelRIGHT));
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
					UserUIs.Add(new UserUI(new User(data[1], data[2], false), panelINTERACTED, panelRIGHT));
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
					FILEID = data[1];
					FILENAME = data[2];
					ID = data[5];
					FILELENGHT = int.Parse(data[3]);
					infoByte = new InfoByte();
					infoByte.ByteLeft = FILELENGHT;
					infoByte.Extension = data[4];
					dataFile = new byte[infoByte.ByteLeft];
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
				else
				{
					if (buff.Length + infoByte.AllByteRead > infoByte.ByteLeft)
                    {
						Array.Resize(ref buff, 1024 - (buff.Length + infoByte.AllByteRead - infoByte.ByteLeft));
                    }
					buff.CopyTo(dataFile, infoByte.AllByteRead);
					infoByte.AllByteRead = infoByte.AllByteRead + buff.Length;
					if (infoByte.AllByteRead == infoByte.ByteLeft)
					{
						_FileDialog fd = new _FileDialog();
						fd.SaveFile(dataFile, FILENAME + infoByte.Extension);
						//File.WriteAllBytes(@"..\..\cache\file\" + FILEID + infoByte.Extension, dataFile);
						//FileInfo fi = new FileInfo((@"..\..\cache\file\" + FILEID + infoByte.Extension));
					}
				}
			}
		}

		//LoadDataUser gọi server trả về tất cả người dùng có trong server
		private async void LoadDataUser()
		{
            byte[] buff = new byte[1024];
			byte[] tembuff = Encoding.UTF8.GetBytes("LOADUSERDATA%" + me.Name);
			tembuff.CopyTo(buff, 0);
			server.GetStream().WriteAsync(buff, 0, buff.Length);
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
