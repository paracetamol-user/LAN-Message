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
using Timer = System.Windows.Forms.Timer;

namespace UI
{
	public partial class FrmMain : Form
	{
		/// <summary>
		///QUY ĐỊNH NGƯỜI SỬ DỤNG CHƯƠNG TRÌNH CÓ BIẾN LÀ <ME>
		///NGƯỜI SỬ DỤNG SERVER LÀ USER
		/// </summary>
		public FrmLogin loginForm;
		public static List<UserUI> UserUIs; // List form giao diện chat cho từng user
		public List<GroupUI> GroupUIs { get; set; } // List form giao diện chat cho từng group
		public static User me; // Nguoi su dung chuong trinh

		public static UserUI userRightForcus = null;
		public static UserUI userUIForcus = null;
		public static FrmUser userFormFocus = null;
		public static FrmGroup groupFormFocus = null;
		public static ucUserINChatBox chatBoxFocus = null;
		public static ucInterac interactFocus = null;

		public static SocketClient client;
		public static TcpClient server;
		public static FrmSetting settingForm;
		public static FrmFriend frmFriend;
		public static List<string> listFile;

		public ServerForm serverUsersForm;
		public NetworkStream stream;
		public ucGroup UcGroup;
		public FrmADDMemberToGroup AddToGroup;
		public FrmADD frmADD;
		public FrmContactBook frmContactBook;
		public FrmADDMemberToContact frmADDMemberToContact;
		public FrmLoading frmLoading;
		public static List<User> listUser;
		public static Theme theme;
		public static List<ucUserINChatBox> listMessAwaitID;
		public static List<ucUserINChatBox> listFileAwaitID;
		public static List<ucUserINChatBox> listVoiceAwaitID;
		public static List<Group> listGroup;

		public bool acceptClose;
		// Tất cả các khai báo trên đều là biến tĩnh, được quyền sử dụng trọng mỗi class.
		public Timer timer;
		public bool time;
		public int tick;
		public FrmMain()
		{
			InitializeComponent();
		}
		public FrmMain(FrmLogin loginform, User user, SocketClient client, TcpClient server, string Theme)
		{
			acceptClose = true;
			frmLoading = new FrmLoading();
			time = false;
			tick = 0;
			timer = new Timer();
			
			frmLoading.TopLevel = false;
			frmLoading.Dock = DockStyle.Fill;
			frmLoading.BringToFront();
			frmLoading.Show();
			this.Controls.Add(frmLoading);
			timer.Interval = 1000;
			timer.Tick += (timersender, timerEvent) => { tick++; if (time == true && tick > 1)
				{
					timer.Stop();
					this.Controls.Remove(frmLoading);
				} };
			timer.Start();
			
			this.loginForm = loginform;
			FrmMain.client = client;
			FrmMain.server = server;
			FrmMain.me = user;
			theme = new Theme();
			if (Theme == "Black")
			{
				theme.Black();
			}
			else theme.White();
			InitializeComponent();
			Panel temp = new Panel();
			temp.Dock = DockStyle.Fill;
			temp.BackColor = Color.Transparent;
			this.panelRIGHT.Controls.Add(temp);
			temp.BringToFront();
			temp.Show();
			UserUIs = new List<UserUI>();
			listUser = new List<User>();
			listMessAwaitID = new List<ucUserINChatBox>();
			listFileAwaitID = new List<ucUserINChatBox>();
			listVoiceAwaitID = new List<ucUserINChatBox>();
			GroupUIs = new List<GroupUI>();
			listGroup = new List<Group>();
			frmContactBook = new FrmContactBook(this);
			UcGroup = new ucGroup(this, GroupUIs);
			AddToGroup = new FrmADDMemberToGroup(this);
			frmADD = new FrmADD(this);
			frmADDMemberToContact = new FrmADDMemberToContact(this);

			me.AvatarPath = @"./images/avatarDefault/avatarDefault.png";
			
			LoadDataUser();
			InitServerUsersForm();
			InitFrmFriend();
			InitSettingForm();
			LoadGroupData();
			LoadContactBook();
			if (Theme == "Black") ChangeTheme();
			LoadMyData();
			AwaitReadData();
			this.SizeChanged += new EventHandler(Form1_SizeChanged);
		}
		public void InitSettingForm()
		{
			settingForm = new FrmSetting(me, this ,loginForm);
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
			frmContactBook._InitControls();
			ChangeColorAllLabelControls(this);
			ChangeColorLine();
			ChangePicture();
			ChangeColorBoxChat();
			ChangeColorFocus();

			settingForm.ChangeColorPanelControl();
			settingForm.ChangeColorAllLabelControl(settingForm);
			serverUsersForm.ChangeColorControl();
			UcGroup.InitColor();
			//frmFriend.ChangeColorControl();
		}
		private void ChangeColorFocus()
		{
			if (userUIForcus != null) userUIForcus.ucInterac.ChangeColorWhenClick();
			if (interactFocus != null) interactFocus.ChangeColorWhenClick();
		}
		private void ChangeColorBoxChat()
		{
			foreach (var item in UserUIs)
			{
				item.ResetTheme();
			}
			foreach (var item in GroupUIs)
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
			settingForm.ResetPicture();
		}
		private void ChangeColorLine()
		{
			this.pnLine.BackColor = theme.LineColor;
			this.pnLine2.BackColor = theme.LineColor;
			this.pnLine3.BackColor = theme.LineColor;
			this.pnLine4.BackColor = theme.LineColor;
			this.pnLine5.BackColor = theme.LineColor;
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
				ChangeColorAllLabelControls(item as Control);
			}
		}
		private void InitFrmFriend()
		{
			FrmMain.frmFriend = new FrmFriend();
			FrmMain.frmFriend.TopLevel = false;
			FrmMain.frmFriend.Dock = DockStyle.Fill;
			panelRIGHT.Controls.Add(FrmMain.frmFriend);
		}
		public void LoadUser()
		{
			//this.Avatar.Image = Image.FromFile(me.AvatarPath);
			this.labelUSERNAME.Text = me.Name;
			this.labelID.Text = "#" + me.Id;
			using (FileStream fs = new FileStream(me.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
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
			labelID.Text = "#" + me.Id;
			labelUSERNAME.Text = me.Name;
			using (FileStream fs = new FileStream(me.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
		private async Task AwaitReadData()
		{
			try
			{
				byte[] tempBuff;
				SmallPackage package;
				List<Package> listAwaitPackage = new List<Package>();
				while (true)
				{
					// Nhận Gói Tin
					byte[] buff = new byte[1024];
					int nReturn = await server.GetStream().ReadAsync(buff, 0, buff.Length);
					package = new SmallPackage();
					package.DividePackage(buff);

					if (package.Style == "M")
					{
						string[] data = (System.Text.Encoding.UTF8.GetString(package.Data).Trim('\0', '\t', '\r', '\n')).Split('%');
						// Xử lí gói tin

						string action = data[0];
						// Tìm hành động
						if (action == "LOADUSERDATA")
						{
							for (int i = 1; i < data.Length; i++)
							{
								if (data[i] == "") break;

								string[] arr = data[i].Split(' ');
								string path = @"./images/avatarDefault/avatarDefault.png";
								if (arr[1] != me.Name)
								{
									listUser.Add(new User(arr[0], arr[1], bool.Parse(arr[2]), path));
									UserUIs.Add(new UserUI(listUser[listUser.Count - 1], this));
								}
							}
							serverUsersForm.LoadListAllUser();
						}
						else if (action == "LOADCONTACTBOOK")
						{
							for (int j = 1; j < data.Length; j++)
							{
								string[] arr = data[j].Split('•');
								ContactBook newContactBook = new ContactBook(arr[0], arr[1]);
								for (int i = 2; i < arr.Length; i++)
								{
									foreach (var item3 in UserUIs)
									{
										if (item3.user.Id == arr[i])
										{
											newContactBook._AddMember(item3.user);
											break;
										}
									}
								}
								frmContactBook._AddContactBook(newContactBook);
							}
							time = true;
						}
						else if (action == "MESSAGE") // MESSAGE +id tin nhan+ tin nhắn + Id người gửi
						{
							string temp = Encoding.UTF8.GetString(package.Data).Trim('\0', '\t', '\n');
							string Message = "";
							int count = 0;
							for (int j = 0; j < temp.Length; j++)
							{
								if (count >= 3)
								{
									Message = Message + temp[j];
								}
								else
									if (temp[j] == '%') count++;
							}
							for (int i = 0; i < UserUIs.Count; i++)
							{
								if (UserUIs[i].GetId() == data[2])
								{
									UserUIs[i].AddMessage(data[1], Message);
									UserUIs[i].BringToTop();
									break;
								}
							}
						}
						else if (action == "ADDUSER")
						{
							string path = @"./images/avatarDefault/avatarDefault.png";
							User tempUser = (new User(data[1], data[2], false, path));
							UserUI temp = new UserUI(tempUser, this);
							listUser.Add(tempUser);
							UserUIs.Add(temp);
							serverUsersForm._AddNewUser(temp);
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
						else if (action == "FILE")
						{
							Package awaitPackage = new Package(data[1], me.Id, 0, int.Parse(data[2]),
										"F", data[3], data[4], data[5], false);
							listAwaitPackage.Add(awaitPackage);
						}
						else if (action == "TEMPFILE") //("TEMPFILE%" + Createid.ToString() + "%" + client.id_ + "%" + infoByte.Name);
						{
							string tempFileId = data[1];
							string tempidNguoiGui = data[2];
							string tempFileName = data[3];
							if (data[4] == "Private")
							{
								for (int i = 0; i < FrmMain.UserUIs.Count; i++)
								{
									if (UserUIs[i].GetId() == tempidNguoiGui)
									{
										UserUIs[i].AddPanelFile(tempFileId, tempFileName);
										UserUIs[i].BringToTop();
										break;
									}
								}
							}
							else
							{
								for (int i = 0; i < GroupUIs.Count; i++)
								{
									if (GroupUIs[i].group.ID == data[5])
									{
										foreach (var item in listUser)
										{
											if (item.Id == tempidNguoiGui)
											{
												GroupUIs[i].AddPanelFile(item, tempFileId, tempFileName);
												GroupUIs[i].BringToTop();
												break;
											}
										}
										break;
									}
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
						else if (action == "AVATAR")
						{
							Package awaitPackage = new Package("0", me.Id, 0, int.Parse(data[2]),
										"A", data[1], data[3], data[4], false);
							listAwaitPackage.Add(awaitPackage);
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
						else if (action == "EDITMESSAGE")
						{
							foreach (var item in UserUIs)
							{
								if (item.user.Id == data[2])
								{
									item.EditMessage(data[1], data[3]);
									break;
								}
							}
						}
						else if (action == "EDITGROUPMESSAGE")
						{
							foreach (var item in GroupUIs)
							{
								if (item.group.ID == data[2])
								{
									item.EditMessage(data[1], data[3]);
									break;
								}
							}
						}
						else if (action == "DELETEMESSAGE")
						{
							foreach (var item in UserUIs)
							{
								if (item.user.Id == data[2])
								{
									item.DeleteMessage(data[1]);
									break;
								}
							}
						}
						else if (action == "DELETEGROUPMESSAGE")
						{
							foreach (var item in GroupUIs)
							{
								if (item.group.ID == data[2])
								{
									item.DeleteMessage(data[1]);
									break;
								}
							}
						}
						else if (action == "IDMESS")
						{
							listMessAwaitID[0].ID = data[1];
							listMessAwaitID.Remove(listMessAwaitID[0]);
						}
						else if (action == "IDFILE")
						{
							listFileAwaitID[0].ID = data[1];
							listFileAwaitID.Remove(listFileAwaitID[0]);
						}
						else if (action == "LOADGROUPDATA")
						{
							for (int i = 1; i < data.Length; i++)
							{
								if (data[i] == "") break;

								string[] arr = data[i].Split('•');
								string path = @"./images/avatarDefault/groupDefault.png";
								listGroup.Add(new Group(arr[0], arr[1], path));
								listGroup[listGroup.Count - 1].AddMember(me);
								for (int j = 3; j < arr.Length; j += 2)
								{
									foreach (var item in listUser)
									{
										if (arr[j] == item.Id)
										{
											listGroup[listGroup.Count - 1].AddMember(item);
											if (item.Id == arr[2]) listGroup[listGroup.Count - 1].admin = item;
											break;
										}
									}
								}
								if (arr[2] == me.Id) listGroup[listGroup.Count - 1].admin = me;
								GroupUIs.Add(new GroupUI(listGroup[listGroup.Count - 1], this));
							}
						}
						else if (action == "GPENDING")
						{
							GroupUI temp = new GroupUI(new Group(data[1], data[2]), this);
							serverUsersForm.AddGroupPending(temp);
							serverUsersForm.EnablePointPending();
							picNotification.Visible = true;
						}
						else if (action == "GROUPDATA")
						{
							string[] arr = data[1].Split('•');
							Group group = new Group(arr[0], arr[1]);
							string admin = arr[2];

							for (int j = 3; j < arr.Length; j += 2)
							{
								foreach (var item in listUser)
								{
									if (arr[j] == item.Id)
									{
										group.AddMember(item);
										if (admin == item.Id) group.admin = item;
										break;
									}
								}
							}
							group.AddMember(me);
							if (arr[2] == me.Id) group.admin = me;
							listGroup.Add(group);
							GroupUIs.Add(new GroupUI(group, this));
						}
						else if (action == "NEWMEMBER")
						{
							foreach (var item in GroupUIs)
							{
								if (item.group.ID == data[1])
								{
									foreach (var item2 in listUser)
									{
										if (data[2] == item2.Id)
										{
											item.group.AddMember(item2);
											break;
										}
									}
								}
							}
						}
						else if (action == "GSEND")
						{
							string temp = Encoding.UTF8.GetString(package.Data).Trim('\0', '\t', '\n');
							string Message = "";
							int count = 0;
							for (int j = 0; j < temp.Length; j++)
							{
								if (count >= 4)
								{
									Message = Message + temp[j];
								}
								else
									if (temp[j] == '%') count++;
							}
							for (int i = 0; i < GroupUIs.Count; i++)
							{
								if (GroupUIs[i].group.ID == data[1])
								{
									foreach (User user in listUser)
									{
										if (user.Id == data[2])
										{
											GroupUIs[i].AddMessage(user, data[3], Message);
											GroupUIs[i].BringToTop();
											break;
										}
									}
									break;
								}
							}
						}
						else if (action == "OUTGR")
						{
							string IDGr = data[1];
							string IDmember = data[2];
							foreach (var item in this.GroupUIs)
							{
								if (item.group.ID == IDGr)
								{
									if (IDmember == me.Id)
									{
										GroupUIs.Remove(item);
										listGroup.Remove(item.group);
										item.Dispose();
									}
									else
									{
										item.group.RemoveMember(IDmember);
									}
									break;
								}
							}
						}
						else if (action == "CREATEGRERROR")
						{
							MessageBox.Show("Create Group Fail! Please check your name group or connection", "Create Error", MessageBoxButtons.OK);
						}
						else if (action == "CREATEGROKE")
						{
							MessageBox.Show("Create Group successfully!", "Create Group", MessageBoxButtons.OK);
						}
						else if (action == "CHANGEHOST")
						{
							string IDgr = data[1];
							string newHost = data[2];

							foreach (var item in GroupUIs)
							{
								if (item.group.ID == data[1])
								{
									if (me.Id == data[2])
									{
										item.group.admin = me;
									}
									else
									{
										item.group.ChangeHost(newHost);
									}
									break;
								}
							}
						}
						else if (action == "CREATECBERRORNAME")
						{
							MessageBox.Show("Contact name has exists!", "Erorr Create Contact", MessageBoxButtons.OK);
						}
						else if (action == "CREATECBSUCCES")
						{
							MessageBox.Show("Create contact successfully!", "Create Contact", MessageBoxButtons.OK);
						}
						else if (action == "NEWCB")
						{
							ContactBook newContactBook = new ContactBook(data[1], data[2]);
							frmContactBook._AddContactBook(newContactBook);

						}
						else if (action == "VOICE")
						{
							Package awaitPackage;
							if (data[2][0] != 'G')
							{
								awaitPackage = new Package(data[1], FrmMain.me.Id, 0, int.Parse(data[2]), "V", "NULL",
															".wav", data[3], true);
								listAwaitPackage.Add(awaitPackage);
							}
							else
							{
								awaitPackage = new Package(data[1], data[2], 0, int.Parse(data[3]), "V", "NULL",
																			".wav", data[4], false);
								listAwaitPackage.Add(awaitPackage);
							}
						}
						else if (action == "REMOVEUSER")
						{
							User temp = new User();
							foreach (var item in listUser)
							{
								if (item.Id == data[1])
								{
									temp = item;
									break;
								}
							}
							foreach (var item in GroupUIs)
							{
								if (item.group.MemberInGroup(temp))
								{
									item.group.RemoveMember(temp.Id);
								}

							}
							foreach (var item in UserUIs)
							{
								if (item.user.Id == temp.Id)
								{
									UserUIs.Remove(item);
									item.Dispose();
									break;
								}
							}
							frmContactBook._RemoveUser(data[1]);
							listUser.Remove(temp);
						}
						else if (action == "IDVOICE")
                        {
							listVoiceAwaitID[0].ID = data[1];
							listVoiceAwaitID.Remove(listVoiceAwaitID[0]);
						}
					}
					else if (package.Style == "F")
					{
						foreach (var item in listAwaitPackage)
						{
							if (package.ID == item.IDpackage)
							{
								if (item.Ack + package.Data.Length > item.Length)
								{
									byte[] tempBuffer = new byte[item.Length - item.Ack];
									Buffer.BlockCopy(package.Data, 0, tempBuffer, 0, item.Length - item.Ack);
									package.Data = new byte[item.Length - item.Ack];
									tempBuffer.CopyTo(package.Data, 0);
								}
								package.Data.CopyTo(item.Data, item.Ack);
								item.Ack = item.Ack + package.Data.Length;
								if (item.Ack == item.Length)
								{
									_FileDialog fd = new _FileDialog();
									fd.SaveFile(item.Data, item.FileName);
								}
							}
						}
					}
					else if (package.Style == "A")
					{
						foreach (var item in listAwaitPackage)
						{
							if (package.ID == item.IDpackage)
							{
								if (item.Ack + package.Data.Length > item.Length)
								{
									byte[] tempBuffer = new byte[item.Length - item.Ack];
									Buffer.BlockCopy(package.Data, 0, tempBuffer, 0, item.Length - item.Ack);
									package.Data = new byte[item.Length - item.Ack];
									tempBuffer.CopyTo(package.Data, 0);
								}
								package.Data.CopyTo(item.Data, item.Ack);
								item.Ack = item.Ack + package.Data.Length;
								if (item.Ack == item.Length)
								{
									string path = @"./cache/avatar/" + item.FileName + item.Extension;
									try
									{
										File.WriteAllBytes(path, item.Data);
									}
									catch (Exception ex)
									{

									}
									foreach (var item2 in UserUIs)
									{
										if (item2.user.Id == item.FileName)
										{
											item2.SetAvatar(path);
											
											break;
										}
										if (item.FileName == me.Id)
										{
											this.SetAvatar(path);
											this.LoadUser();
											break;
										}
									}
								}
							}
						}
					}
					else if (package.Style == "V")
					{
						foreach (var item in listAwaitPackage)
						{
							if (package.ID == item.IDpackage)
							{
								if (item.Ack + package.Data.Length > item.Length)
								{
									byte[] tempBuffer = new byte[item.Length - item.Ack];
									Buffer.BlockCopy(package.Data, 0, tempBuffer, 0, item.Length - item.Ack);
									package.Data = new byte[item.Length - item.Ack];
									tempBuffer.CopyTo(package.Data, 0);
								}
								package.Data.CopyTo(item.Data, item.Ack);
								item.Ack = item.Ack + package.Data.Length;
								if (item.Ack == item.Length)
								{
									if (item.isPrivate)
									{
										foreach (var userUI in UserUIs)
										{
											if (userUI.user.Id == item.IDsend)
											{
												string path = string.Format(@"./voice/{0}/", item.IDsend);
												if (!Directory.Exists(path))
													Directory.CreateDirectory(path);
												path += string.Format("{0}.wav", GetIDForIncomingVoice(path));
												File.WriteAllBytes(path, item.Data);
												userUI.userForm.AddVoiceMessage(userUI.user, path , item.IDpackage);
												userUI.BringToTop();
												break;
											}
										}
									}
									else
									{
										foreach (var groupUI in GroupUIs)
										{
											if ("G" + groupUI.group.ID == item.IDreceive)
											{
												string path = string.Format(@"./voice/{0}/", item.IDreceive);
												if (!Directory.Exists(path))
													Directory.CreateDirectory(path);
												path += string.Format("{0}.wav", GetIDForIncomingVoice(path));
												File.WriteAllBytes(path, item.Data);
												foreach (var userUI in UserUIs)
												{
													if (userUI.user.Id == item.IDsend)
													{
                                                        groupUI.groupForm.AddVoiceMessage(userUI.user, path, item.IDpackage);
														groupUI.BringToTop();
														break;
													}
												}
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (acceptClose != false)
				MessageBox.Show("Server disconnected!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				acceptClose = false;
				this.Close();
			}
		}
		public void SetAvatar(string path)
		{
			me.AvatarPath = path;
		}
		private async void LoadDataUser()
		{
			byte[] buff = new byte[1024];
			byte[] tempbuff = Encoding.UTF8.GetBytes("LOADUSERDATA%");
			SmallPackage packageReceive = new SmallPackage(0, 1024, "M", tempbuff, "0");
			await server.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
		}
		private async void LoadGroupData()
		{
			byte[] tempbuff = Encoding.UTF8.GetBytes("LOADGROUPDATA%" + me.Id);
			SmallPackage packageReceive = new SmallPackage(0, 1024, "M", tempbuff, "0");
			await server.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
		}
		private async void LoadContactBook()
		{
			byte[] tempbuff = Encoding.UTF8.GetBytes("LOADCONTACTBOOK%");
			SmallPackage packageReceive = new SmallPackage(0, 1024, "M", tempbuff, "0");
			await server.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
		}
		public static void AddUserIntoFrmFriend(UserUI userUI)
		{
			frmFriend.AddUserIntoFrmFriend(userUI);
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
			settingForm = new FrmSetting(me, this, loginForm);
			settingForm.Show();
			settingForm.BringToFront();
		}
		private void btnFriend_Click(object sender, EventArgs e)
		{
			if (FrmMain.userUIForcus != null)
			{
				FrmMain.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				FrmMain.userUIForcus = null;
			}

			frmFriend.Show();
			frmFriend.BringToFront();
			frmFriend.InitStart();
		}
		private void btnServer_Click(object sender, EventArgs e)
		{
			picNotification.Visible = false;
			if (FrmMain.userFormFocus != null) FrmMain.userFormFocus.Hide();
			if (FrmMain.userUIForcus != null)
			{
				FrmMain.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				FrmMain.userUIForcus = null;
			}
			serverUsersForm.Show();
			serverUsersForm.BringToFront();
			serverUsersForm.InitStart();
		}
		public Panel PnRight
		{
			get
			{
				return this.panelRIGHT;
			}
		}
		public Panel PnInteract
		{
			get
			{
				return this.panelINTERACTED;
			}
		}
		private void btnGroup_Click(object sender, EventArgs e)
		{
			this.UcGroup.Show();
			this.UcGroup.BringToFront();
			this.UcGroup._LoadGroup();
		}
		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			this.AddToGroup.ReLocation();
			this.frmADD.ReLocation();
		}
		private void btnGroup_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				(sender as Button).BackColor = Color.Transparent;
			}
			catch
			{
				btnServer.BackColor = Color.Transparent;
			}
		}
		private void btnPhoneBook_Click(object sender, EventArgs e)
		{
			this.frmContactBook.Show();
			this.frmContactBook.BringToFront();
		}
		private int GetIDForIncomingVoice(string path)
		{
			int id = 0;
			while (true)
			{
				string temp = string.Format("{0}{1}.wav", path, id);
				if (!File.Exists(temp))
					return id;
				id++;
			}
		}
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (acceptClose == false)
			{
				this.Dispose();
				this.loginForm.DisconectServer();
				this.loginForm.Show();
				this.loginForm.ReConnect();
			}
			else
			{
				this.Dispose();
				loginForm.Close();
			}
				
		}
        private void btnPhoneBook_MouseMove(object sender, MouseEventArgs e)
        {
			try
			{
				(sender as Button).BackColor = theme.FocusColor;
			}
			catch
			{
				btnServer.BackColor = Color.Transparent;
			}
		}
        private void picNotification_MouseMove(object sender, MouseEventArgs e)
        {
			btnServer.BackColor = theme.FocusColor;
		}
        private void picNotification_Click(object sender, EventArgs e)
        {
			picNotification.Visible = false;
			if (FrmMain.userFormFocus != null) FrmMain.userFormFocus.Hide();
			if (FrmMain.userUIForcus != null)
			{
				FrmMain.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				FrmMain.userUIForcus = null;
			}
			serverUsersForm.Show();
			serverUsersForm.BringToFront();
			serverUsersForm.InitStart();
		}
    }
}
