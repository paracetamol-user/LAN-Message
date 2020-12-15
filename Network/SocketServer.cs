﻿using Network;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Communication
{
	public class SocketServer
	{
		IPAddress mIP;
		int mPort;
		TcpListener mListener;
		List<UserClient> clients;
		List<UserClient> clientInvalid;
		//List<string> idInvalid;

		// Database of DAT
		//Data Source = DESKTOP - TSN7OH7; Initial Catalog = LANCHAT; Integrated Security = True
		//Data Source=DESKTOP-TSN7OH7;Initial Catalog=LANCHAT;User ID=sa;Password=1;
		// Data Source=DESKTOP-BM0V9BJ;Initial Catalog=LANCHAT;Integrated Security=True

		// Database of K
		// Data Source=Paracetamol;Initial Catalog=LANCHAT;Integrated Security=True
		string connString = @"Data Source=DESKTOP-L3418BN;Initial Catalog=LANCHAT;Integrated Security=True";
		string queryLogin = "select * from USERS";
		string queryStatusOnline = "UPDATE USERS SET TINHTRANG = 1 WHERE ID = @id";
		string queryStatusOffline = "UPDATE USERS SET TINHTRANG = 0 WHERE ID = @id";
		string queryMessage = "insert into TINNHAN values(@id,@idnguoigui,@idnguoinhan,@tinnhan,@loai,@nhomnhan)";
		string queryChangePassword = "select ID, MATKHAU from USERS where ID = @id";
		string queryChangeUsername = "select ID, TENTK from USERS where ID = @id or TENTK = @name";

		SqlConnection connection;
		SqlCommand command;
		SqlDataReader reader;

		public EventHandler<ClientConnectedEventArgs> RaiseClientConnectedEvent;
		public EventHandler<TextReceivedEventArgs> RaiseTextReceivedEvent;
		protected virtual void OnRaiseClientConnectedEvent(ClientConnectedEventArgs ccea)
		{
			EventHandler<ClientConnectedEventArgs> handler = RaiseClientConnectedEvent;
			if (handler != null)
				handler(this, ccea);
		}
		protected virtual void OnRaiseTextREceivedEvent(TextReceivedEventArgs trea)
		{
			EventHandler<TextReceivedEventArgs> handler = RaiseTextReceivedEvent;
			if (handler != null)
				handler(this, trea);
		}
		private bool KeepRunning { get; set; }
		public SocketServer()
		{
			clients = new List<UserClient>();
			clientInvalid = new List<UserClient>();
			//idInvalid = new List<string>();
		}
		public int idfocus = 0;
		public async Task StartForIncommingConnection(IPAddress addr = null, int port = 5000)
		{
			if (addr == null)
				addr = IPAddress.Any;

			if (port < 0 || port > 65535)
				port = 5000;
			mIP = addr;
			mPort = port;
			System.Diagnostics.Debug.WriteLine(string.Format("IP Address: {0} - Port: {1}", mIP, mPort));
			mListener = new TcpListener(mIP, mPort);
			try
			{
				mListener.Start();
				KeepRunning = true;

				while (KeepRunning)
				{
					UserClient returnedByAccept = new UserClient();
					returnedByAccept.client_ = await mListener.AcceptTcpClientAsync();
					clients.Add(returnedByAccept);
					System.Diagnostics.Debug.WriteLine("Client connected, count: {0}", clients.Count);
					WorkWithClient(returnedByAccept);
					ClientConnectedEventArgs eaClientConnected;
					eaClientConnected = new ClientConnectedEventArgs(returnedByAccept.client_.Client.ToString());
					OnRaiseClientConnectedEvent(eaClientConnected);
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
			}
		}
		/// <summary>
		/// Xử lí các gói tin cho client
		/// </summary>
		private async Task ProcessStyleMessage(UserClient client, SmallPackage package, List<Package> listAwaitPackage)
		{
			string[] data = (Encoding.UTF8.GetString(package.Data).Trim('\0', '\t', '\n')).Split('%');
			byte[] buffMessage = new byte[1024];
			byte[] tempBuff;
			SmallPackage packageReceive;

			if (data[0] == "SIGNUP")
			{
				try
				{
					string idEnd = "";
					// Lấy id cuối cùng để tăng id lên 1 và thêm người dùng vào khi SIGNUP thành công

					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(queryLogin, connection);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						if (data[1] == reader.GetString(1))
						{
							tempBuff = Encoding.UTF8.GetBytes("SIGNUPNO");
							packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
							await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
							return;
						}
						idEnd = reader.GetString(0);
					}
					// Tìm xem người dùng đã tồn tại trong server chưa
					int.TryParse(idEnd, out idfocus);
					idfocus++;
					connection.Close();
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("INSERT INTO USERS VALUES (@id , @tendangnhap , @matkhau, @hoten ,@sdt, @gioitinh, @tinhtrang,@source,@theme)", connection);
					command.Parameters.AddWithValue("@id", idfocus.ToString());
					command.Parameters.AddWithValue("@tendangnhap", data[1]);
					command.Parameters.AddWithValue("@matkhau", data[2]);
					command.Parameters.AddWithValue("@hoten", data[3]);
					command.Parameters.AddWithValue("@sdt", data[4]);
					command.Parameters.AddWithValue("@gioitinh", data[5] == "True" ? 0 : 1);
					command.Parameters.AddWithValue("@tinhtrang", 0);
					command.Parameters.AddWithValue("@source", "Default");
					command.Parameters.AddWithValue("@theme", "White");
					command.ExecuteNonQuery();
					// Thêm người dùng mới vào database
					byte[] tempBuffer = Encoding.UTF8.GetBytes("SIGNUPOKE");
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuffer, "0");
					client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
					SendToAll(client, "ADDUSER%" + idfocus.ToString() + "%" + data[1]);
					connection.Close();
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}
			}
			else if (data[0] == "LOGIN")
			{
				try
				{
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(queryLogin, connection);
					reader = command.ExecuteReader();
					bool check = true;
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						if (data[1] == reader.GetString(1) && data[2] == reader.GetString(2))
						{
							tempBuff = Encoding.UTF8.GetBytes("LOGINOKE%" + reader.GetString(0) + "%" + reader.GetString(8));
							SmallPackage tempPackage = new SmallPackage(0, package.Length, package.Style, tempBuff, "0");
							buffMessage = tempPackage.Packing();
							client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
							// Gửi lại gói tin Login thành công khi đúng tài khoản
							client.id_ = reader.GetString(0);
							clientInvalid.Add(client);
							// Lưu lại client đã online trong server
							SendToAll(client, "ONLINE%" + client.id_.ToString());
							string temp = queryStatusOnline + client.id_.ToString();
							// Gửi thông tin Online từ người dùng này tới tất cả người online trong server
							connection.Close();
							connection = new SqlConnection(connString);
							connection.Open();
							SqlCommand commandstatus = new SqlCommand(queryStatusOnline, connection);
							commandstatus.Parameters.AddWithValue("@id", client.id_);
							commandstatus.ExecuteNonQuery();
							connection.Close();
							// Update status Online cho người dùng
							check = false;
							break;
						}
					}
					if (check != false)
					{
						tempBuff = Encoding.UTF8.GetBytes("LOGIN ERR");
						packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
						await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}
			}
			else if (data[0] == "LOADUSERDATA")
			{
				try
				{
					byte[] tempbuff;
					connection.Close();
					string arr = "LOADUSERDATA%";
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(queryLogin, connection);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						arr = arr + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetBoolean(6).ToString() + "%";
					}
					connection.Close();
					// Lấy tất cả người dùng từ data base
					tempBuff = Encoding.UTF8.GetBytes(arr);
					packageReceive = new SmallPackage(package.Seq, package.Length, package.Style, tempBuff, "0");
					buffMessage = packageReceive.Packing();
					await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

					arr = "FRIEND%";
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("SELECT * FROM FRIEND WHERE ID = @id", connection);
					command.Parameters.AddWithValue("@id", client.id_);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						arr = arr + reader.GetString(1) + "%";
					}
					connection.Close();
					// Lấy tất cả bạn 
					tempBuff = Encoding.UTF8.GetBytes(arr);
					packageReceive = new SmallPackage(package.Seq, package.Length, package.Style, tempBuff, "0");
					buffMessage = packageReceive.Packing();
					client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("SELECT * FROM USERS", connection);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						string path = (reader.GetString(7) != "Default") ? reader.GetString(7) : "";
						if (path != "")
						{
							FileInfo fi = new FileInfo(path);
							byte[] packagetemp = File.ReadAllBytes(path);
							Guid IDpackage = Guid.NewGuid();
							// Lấy file ra
							tempbuff = Encoding.UTF8.GetBytes(string.Format("AVATAR%{0}%{1}%{2}%{3}", reader.GetString(0), fi.Length, fi.Extension , IDpackage.ToString()));
							packageReceive = new SmallPackage(0, 1024, "M", tempbuff, "0");
							buffMessage = packageReceive.Packing();
							client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

							// Gửi Gói khởi đầu avatar về server
							SendFileToClient(packagetemp, client, "A" , IDpackage.ToString());
						}
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}
			}
			else if (data[0] == "SEND") //"SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text;				   // SEND  + Id của thằng gửi + ID thằng nhận + tin nhắn
			{
				Guid id = Guid.NewGuid();
				this.connection = new SqlConnection(this.connString);
				this.connection.Open();
				this.command = new SqlCommand("insert into TINNHAN(MATINNHAN,NGUOIGUI,NGUOINHAN,NOIDUNGTINNHAN,LOAI) values(@id,@idnguoigui,@idnguoinhan,@tinnhan,@loai)", connection);
				this.command.Parameters.Add(new SqlParameter("@id", id.ToString()));
				this.command.Parameters.Add(new SqlParameter("@idnguoigui", client.id_));
				this.command.Parameters.Add(new SqlParameter("@idnguoinhan", data[2]));
				this.command.Parameters.Add(new SqlParameter("@tinnhan", data[3]));
				this.command.Parameters.Add(new SqlParameter("@loai", 1));
				this.command.ExecuteNonQuery();
				this.connection.Close();
				// Lưu vào database

				tempBuff = Encoding.UTF8.GetBytes("IDMESS%" + id.ToString());
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
				await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
				// Gửi lại ID cho client

				int i = 0;
				foreach (var item in clientInvalid)
				{
					if (item.id_.ToString() == data[2])
					{
						try
						{
							buffMessage = new byte[1024];
							tempBuff = Encoding.UTF8.GetBytes("MESSAGE%" + id.ToString() + "%" + data[3] + "%" + data[1]);
							packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
							await item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
						}
						catch (Exception ex)
						{
							Debug.WriteLine(ex.ToString());
						}
					}
					i++;

				}
			}
			else if (data[0] == "STARTSENDFILE")// STARTSENDFILE <ID gửi> <ID Nhận> <chiều dài file> <file name> <extension file> <nhan group hay nhan private>
			{
				Package awaitPackage = new Package(client.id_, data[1], 0, int.Parse(data[2]),
									"F", data[3], data[4], data[5],
									(data[6] == "Public" ? false : true));
				listAwaitPackage.Add(awaitPackage);
			}
			else if (data[0] == "GSEND")
			{
				string query = "select USERS.ID, USERS.TENTK " +
						"from MEMBER, USERS where MEMBER.IDUSERS = USERS.ID " +
						"and MEMBER.IDNHOM = @id";
				Guid id = Guid.NewGuid();
				this.connection.Close();
				this.connection = new SqlConnection(this.connString);
				this.connection.Open();
				this.command = new SqlCommand("insert into TINNHAN(MATINNHAN,NGUOIGUI,NOIDUNGTINNHAN,LOAI,NHOMNHAN) values(@id,@idnguoigui,@tinnhan,@loai,@nhomnhan)", connection);
				this.command.Parameters.Add(new SqlParameter("@id", id.ToString()));
				this.command.Parameters.Add(new SqlParameter("@idnguoigui", client.id_));
				this.command.Parameters.Add(new SqlParameter("@tinnhan", data[3]));
				this.command.Parameters.Add(new SqlParameter("@loai", 1));
				this.command.Parameters.Add(new SqlParameter("@nhomnhan", data[1]));
				this.command.ExecuteNonQuery();
				this.connection.Close();

				tempBuff = Encoding.UTF8.GetBytes("IDMESS%" + id.ToString());
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
				await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);

				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@id", data[1]);
				reader = command.ExecuteReader();
				while (reader.HasRows)
				{
					if (!reader.Read()) break;
					// groupid, userid, message
					string mess = string.Format("GSEND%{0}%{1}%{2}%{3}", data[1], data[2], data[3], id.ToString());
					buffMessage = new byte[1024];
					tempBuff = Encoding.UTF8.GetBytes(mess);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
					foreach (var item in clientInvalid)
					{
						if (item.id_ == reader.GetString(0))
						{
							item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
							break;
						}
					}
				}
				connection.Close();
			}
			else if (data[0] == "SENDFILE") // SENDFILE - FILEID - FILENAME - ID THẰNG GỬI LÊN
			{
				string queryFINDSOURCE = "SELECT * FROM TINNHAN Where MATINNHAN = @id";
				string FILEID = data[1];
				string FILENAME = data[2];
				string ID = data[3];
				string path = "";
				connection = new SqlConnection(this.connString);
				connection.Open();
				command = new SqlCommand(queryFINDSOURCE, connection);
				command.Parameters.AddWithValue("@id", FILEID.ToString());
				reader = command.ExecuteReader();
				while (reader.HasRows)
				{
					if (reader.Read() == false) break;
					if (reader.GetString(0) == FILEID)
					{
						path = reader.GetString(3).ToString();
						break;
					}
				}
				connection.Close();
				Guid id = Guid.NewGuid();
				FileInfo fileInfo = new FileInfo(path);
				byte[] fileData = File.ReadAllBytes(fileInfo.FullName);
				tempBuff = Encoding.UTF8.GetBytes(string.Format("FILE%{0}%{1}%{2}%{3}%{4}"," ",
																 fileData.Length.ToString(), FILENAME,
																fileInfo.Extension.ToString(), id.ToString()));
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, FILEID);
				client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);

				SendFileToClient(fileData, client, "F" , id.ToString());
			}
			else if (data[0] == "CHECKPASS")
			{
				string messageToClient = "CHECKPASS%NO";
				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand(queryChangePassword, connection);
				command.Parameters.AddWithValue("@id", data[1]);
				reader = command.ExecuteReader();
				bool isFound = false;
				while (reader.HasRows)
				{
					if (reader.Read() == false) break;

					if (reader.GetString(1) == data[2])
					{
						isFound = true;
						break;
					}
				}
				connection.Close();
				if (isFound)
				{
					string cmdChange = "update USERS set MATKHAU = @mk where ID = @id";
					connection.Open();
					command = new SqlCommand(cmdChange, connection);
					command.Parameters.AddWithValue("@mk", data[3]);
					command.Parameters.AddWithValue("@id", data[1]);

					command.ExecuteNonQuery();
					messageToClient = "CHECKPASS%YES";
					connection.Close();
				}

				tempBuff = Encoding.UTF8.GetBytes(messageToClient);
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
				await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
			}
			else if (data[0] == "CHANGENAME")
			{
				string messageToClient = "CHANGENAME%NO";
				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand(queryChangeUsername, connection);
				command.Parameters.AddWithValue("@id", data[1]);
				command.Parameters.AddWithValue("@name", data[2]);
				reader = command.ExecuteReader();

				bool isExist = false;
				while (reader.HasRows)
				{
					if (reader.Read() == false) break;
					if (reader.GetString(1) == data[2])
					{
						isExist = true;
						break;
					}
				}

				connection.Close();
				if (!isExist)
				{
					string cmdChange = "update USERS set TENTK = @name where ID = @id";
					connection.Open();
					command = new SqlCommand(cmdChange, connection);
					command.Parameters.AddWithValue("@id", data[1]);
					command.Parameters.AddWithValue("@name", data[2]);

					command.ExecuteNonQuery();
					messageToClient = "CHANGENAME%YES";
					connection.Close();
				}

				tempBuff = Encoding.UTF8.GetBytes(messageToClient);
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
				await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
			}
			else if (data[0] == "ACCEPTFRIEND")
			{
				try
				{
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("INSERT INTO FRIEND VALUES (@id,@idfriend)", connection);
					command.Parameters.AddWithValue("@id", data[1]);
					command.Parameters.AddWithValue("@idfriend", data[2]);
					command.ExecuteNonQuery();
					connection.Close();
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("INSERT INTO FRIEND VALUES (@id,@idfriend)", connection);
					command.Parameters.AddWithValue("@id", data[2]);
					command.Parameters.AddWithValue("@idfriend", data[1]);
					command.ExecuteNonQuery();
					connection.Close();
					foreach (var item in clientInvalid)
					{
						if (item.id_ == data[2])
						{
							tempBuff = Encoding.UTF8.GetBytes("ACCEPTFRIEND%" + data[1]);
							packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
							await item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
							break;
						}
					}
				}
				catch (Exception ex)
				{

				}
			}
			else if (data[0] == "REMOVEFRIEND")
			{
				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand("DELETE FROM FRIEND WHERE ID = @id AND IDFRIEND = @idfriend", connection);
				command.Parameters.AddWithValue("@id", data[1]);
				command.Parameters.AddWithValue("@idfriend", data[2]);
				command.ExecuteNonQuery();
				connection.Close();

				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand("DELETE FROM FRIEND WHERE ID = @id AND IDFRIEND = @idfriend", connection);
				command.Parameters.AddWithValue("@id", data[2]);
				command.Parameters.AddWithValue("@idfriend", data[1]);
				command.ExecuteNonQuery();
				connection.Close();
				foreach (var item in clientInvalid)
				{
					if (item.id_ == data[2])
					{
						tempBuff = Encoding.UTF8.GetBytes("REMOVEFRIEND%" + data[1]);
						packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
						await item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
						break;
					}
				}
			}
			else if (data[0] == "PENDING")
			{
				tempBuff = Encoding.UTF8.GetBytes("PENDING%" + data[1]);
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
				foreach (var item in clientInvalid)
				{
					if (item.id_ == data[2])
					{
						await item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
						break;
					}
				}
			}
			else if (data[0] == "THEME")
			{
				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand("UPDATE USERS SET THEME = @THEME WHERE ID = @ID", connection);
				command.Parameters.AddWithValue("@THEME", data[1]);
				command.Parameters.AddWithValue("@ID", client.id_);
				command.ExecuteNonQuery();
				connection.Close(); ;
			}
			else if (data[0] == "EDITMESSAGE")
			{
				string tempquery = "Select * from tinnhan where MATINNHAN = @id ";
				string nguoinhan = "";
				string nhomnhan = "";
				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand(tempquery, connection);
				command.Parameters.AddWithValue("@id", data[1]);
				reader = command.ExecuteReader();
				while (reader.HasRows)
				{
					if (!reader.Read()) break;
					try { nguoinhan = reader.GetString(2); } catch { }
					try { nhomnhan = reader.GetString(5); } catch { }

				}
				connection.Close();
				if (nguoinhan != "")
				{
					tempBuff = Encoding.UTF8.GetBytes("EDITMESSAGE%" + data[1] + "%" + client.id_ + "%" + data[3]);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");

					foreach (var item in clientInvalid)
					{
						if (item.id_ == data[2])
						{
							item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
							break;
						}
					}
				}
				else
				{
					tempBuff = Encoding.UTF8.GetBytes("EDITGROUPMESSAGE%" + data[1] + "%" + nhomnhan + "%" + data[3]);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
					string query = "select USERS.ID, USERS.TENTK " +
						"from MEMBER, USERS where MEMBER.IDUSERS = USERS.ID " +
						"and MEMBER.IDNHOM = @id";
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@id", nhomnhan);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (!reader.Read()) break;
						// groupid, userid, message
						foreach (var item in clientInvalid)
						{
							if (item.id_ == reader.GetString(0))
							{
								item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
								break;
							}
						}
					}
					connection.Close();
				}
			}
			else if (data[0] == "GPENDING")
			{
				tempBuff = Encoding.UTF8.GetBytes(string.Format("GPENDING%{0}%{1}", data[1], data[2]));
				packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");

				foreach (var item in clientInvalid)
				{
					if (item.id_ == data[3])
					{
						item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
						break;
					}
				}
			}
			else if (data[0] == "DELETEMESSAGE")
			{
				string tempquery = "Select * from tinnhan where MATINNHAN = @id ";
				string nguoinhan = "";
				string nhomnhan = "";
				connection = new SqlConnection(connString);
				connection.Open();
				command = new SqlCommand(tempquery, connection);
				command.Parameters.AddWithValue("@id", data[1]);
				reader = command.ExecuteReader();
				while (reader.HasRows)
				{
					if (!reader.Read()) break;
					try { nguoinhan = reader.GetString(2); } catch { }
					try { nhomnhan = reader.GetString(5); } catch { }

				}
				connection.Close();
				if (nguoinhan != "")
				{
					tempBuff = Encoding.UTF8.GetBytes("DELETEMESSAGE%" + data[1] + "%" + client.id_);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
					foreach (var item in clientInvalid)
					{
						if (item.id_ == data[2])
						{
							item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
							break;
						}
					}
				}
				else
				{
					tempBuff = Encoding.UTF8.GetBytes("DELETEGROUPMESSAGE%" + data[1] + "%" + nhomnhan);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
					string query = "select USERS.ID, USERS.TENTK " +
						"from MEMBER, USERS where MEMBER.IDUSERS = USERS.ID " +
						"and MEMBER.IDNHOM = @id";
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@id", nhomnhan);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (!reader.Read()) break;
						// groupid, userid, message
						foreach (var item in clientInvalid)
						{
							if (item.id_ == reader.GetString(0))
							{
								item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);

								break;
							}
						}
					}
					connection.Close();
				}
			}
			else if (data[0] == "GROUPACCEPT")
			{
				// goi nguoc group data ve cho user accept
				// luu vao database
				// goi ve cho tat ca thanh vien cho mot thang moi them vao
				try
				{
					string query = "select USERS.ID, USERS.TENTK " +
						"from MEMBER, USERS where MEMBER.IDUSERS = USERS.ID " +
						"and MEMBER.IDNHOM = @id";
					connection.Close();
					string message = string.Format("GROUPDATA%{0} {1}", data[1], data[2]);
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@id", data[1]);
					reader = command.ExecuteReader();
					// id_1 + name_1 + ... 
					while (reader.HasRows)
					{
						if (!reader.Read()) break;
						message += string.Format("%{0} {1}", reader.GetString(0), reader.GetString(1));
						foreach (var item in clientInvalid)
						{
							if (item.id_ == reader.GetString(0))
							{
								byte[] tempBuffer;
								tempBuffer = Encoding.UTF8.GetBytes(string.Format("NEWMEMBER%{0}%{1}%{2}", data[1], data[3], data[4]));
								packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuffer, "0");
								item.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
								break;
							}
						}
					}
					connection.Close();
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("insert into MEMBER values(@idgroup, @idmember)", connection);
					command.Parameters.AddWithValue("@idgroup", data[1]);
					command.Parameters.AddWithValue("@idmember", data[3]);
					command.ExecuteNonQuery();
					connection.Close();
					tempBuff = Encoding.UTF8.GetBytes(message);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
					client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
				}
				catch (Exception ex)
				{

				}
			}
			else if (data[0] == "LOADGROUPDATA")
			{
				// SQL command
				// SQL command
				try
				{
					string query = "select GROUPS.IDNHOM, TENNHOM from MEMBER, GROUPS " +
									"where MEMBER.IDNHOM = GROUPS.IDNHOM " +
									"and MEMBER.IDUSERS = @id";
					connection.Close();
					string message = "LOADGROUPDATA";
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@id", data[1]);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (!reader.Read()) break;
						message += string.Format("%{0} {1}", reader.GetString(0), reader.GetString(1));
						query = "select ID, TENTK from MEMBER, USERS where MEMBER.IDUSERS = USERS.ID and IDNHOM = @id";
						SqlConnection subConnect = new SqlConnection(connString);
						subConnect.Open();
						SqlCommand subCommand = new SqlCommand(query, subConnect);
						subCommand.Parameters.AddWithValue("@id", reader.GetString(0));
						SqlDataReader subReader = subCommand.ExecuteReader();
						while (subReader.HasRows)
						{
							if (!subReader.Read()) break;
							message += string.Format(" {0} {1}", subReader.GetString(0), subReader.GetString(1));
						}
						subConnect.Close();
					}
					connection.Close();
					tempBuff = Encoding.UTF8.GetBytes(message);
					packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
					client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.ToString());
				}
			}
			else if (data[0] == "SAVEAVATAR")
            {
				Package awaitPackage = new Package(client.id_, "0", 0, int.Parse(data[1]),
									"A", data[2], data[3], data[4],false);
				listAwaitPackage.Add(awaitPackage);
			}
		}
		public async Task SendFileToClient(byte[] package, UserClient client, string Style, string IDpackage)
		{
			int byteSent = 0;
			int byteLeft = package.Length;
			int nextPackageSize = 964;
			byte[] tempBuff = new byte[964];
			SmallPackage packageSend;
			while (byteLeft > 0)
			{

				if (byteLeft >= 964) Buffer.BlockCopy(package, byteSent, tempBuff, 0, 964);
				else Buffer.BlockCopy(package, byteSent, tempBuff, 0, byteLeft);

				packageSend = new SmallPackage(byteSent, package.Length,Style, tempBuff, IDpackage.ToString());

				client.client_.GetStream().WriteAsync(packageSend.Packing(), 0, packageSend.Packing().Length);
				byteSent += nextPackageSize;
				byteLeft -= nextPackageSize;
			}
		}
		public async Task WorkWithClient(UserClient client)
		{
			SmallPackage package;
			List<Package> listAwaitPackage = new List<Package>();
			try
			{
				while (true)
				{
					byte[] buff = new byte[1024];
					int nReturn = await client.client_.GetStream().ReadAsync(buff, 0, buff.Length);

					package = new SmallPackage();
					package.DividePackage(buff);

					if (nReturn == 0)
					{
						RemoveClient(client);
						string getId = client.id_;
						SendToAll(client, "OFFLINE%" + getId);
						clientInvalid.Remove(client);
						connection = new SqlConnection(connString);
						connection.Open();
						SqlCommand commandstatus = new SqlCommand(queryStatusOffline, connection);
						commandstatus.Parameters.AddWithValue("@id", getId);
						commandstatus.ExecuteNonQuery();
						break;
					}
					if (package.Style == "M")
					{
						await ProcessStyleMessage(client, package, listAwaitPackage);
					}
					else if (package.Style == "F")
					{
						foreach (var item in listAwaitPackage)
						{
							if (package.ID == item.IDpackage)
							{
								if (item.Ack + package.Data.Length > item.Length)
								{
									byte[] tempBuff = new byte[item.Length - item.Ack];
									Buffer.BlockCopy(package.Data, 0, tempBuff, 0, item.Length - item.Ack);
									package.Data = new byte[item.Length - item.Ack];
									tempBuff.CopyTo(package.Data, 0);
								}
								package.Data.CopyTo(item.Data, item.Ack);
								item.Ack = item.Ack + package.Data.Length;
								if (item.Ack == item.Length)
								{
									if (item.isPrivate)
									{
										Guid IDMessage = Guid.NewGuid();
										byte[] tempBuff = Encoding.UTF8.GetBytes("IDFILE%" + IDMessage.ToString());
										SmallPackage packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
										await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
										// Gửi ID của file về cho người gửi
										File.WriteAllBytes(@"..\..\filedata\" + IDMessage.ToString() + item.Extension, item.Data);
										// Lưu file vào trong thư mục của server
										connection.Close();
										string tinnhan = @"..\..\filedata\" + IDMessage.ToString() + item.Extension.ToString();
										this.connection = new SqlConnection(this.connString);
										this.connection.Open();
										this.command = new SqlCommand("insert into TINNHAN(MATINNHAN," +
																		" NGUOIGUI,NGUOINHAN, NOIDUNGTINNHAN," +
																		" LOAI) values(@id, @idnguoigui,@idnguoinhan," +
																		" @tinnhan, @loai)", connection);
										this.command.Parameters.Add(new SqlParameter("@id", IDMessage.ToString()));
										this.command.Parameters.Add(new SqlParameter("@idnguoigui", item.IDsend));
										this.command.Parameters.Add(new SqlParameter("@idnguoinhan", item.IDreceive));
										this.command.Parameters.Add(new SqlParameter("@tinnhan", tinnhan));
										this.command.Parameters.Add(new SqlParameter("@loai", 1));
										this.command.ExecuteNonQuery();
										this.connection.Close();
										// Lưu file dưới dạng là 1 tin nhắn trong Database Table TINNHAN
										foreach (var item2 in clientInvalid)
										{
											if (item2.id_ == item.IDreceive)
											{
												try
												{
													tempBuff = Encoding.UTF8.GetBytes("TEMPFILE%" + IDMessage.ToString() + "%" + client.id_ + "%" + item.FileName + "%Private");

													packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
													await item2.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
													break;
												}
												catch (Exception ex)
												{
													Debug.WriteLine(ex.ToString());
												}
											}
										}
										// Gửi 1 file tạm gồm tên file và id của file về cho người nhận
										listAwaitPackage.Remove(item);
									}
									else
									{
										Guid IDMessage = Guid.NewGuid();
										byte[] tempBuff = Encoding.UTF8.GetBytes("IDFILE%" + IDMessage.ToString());
										SmallPackage packageReceive = new SmallPackage(package.Seq, package.Length, "M", tempBuff, "0");
										await client.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
										// Gửi ID của file về cho người gửi
										File.WriteAllBytes(@"..\..\filedata\" + IDMessage.ToString() + item.Extension, item.Data);
										// Lưu file vào trong thư mục của server
										connection.Close();
										this.connection = new SqlConnection(this.connString);
										this.connection.Open();
										this.command = new SqlCommand("insert into TINNHAN(MATINNHAN," +
																		" NGUOIGUI, NOIDUNGTINNHAN," +
																		" LOAI, NHOMNHAN) values(@id, @idnguoigui," +
																		" @tinnhan, @loai,@nhomnhan)", connection);
										this.command.Parameters.Add(new SqlParameter("@id", IDMessage.ToString()));
										this.command.Parameters.Add(new SqlParameter("@idnguoigui", item.IDsend));
										this.command.Parameters.Add(new SqlParameter("@tinnhan", @"..\..\filedata\" + IDMessage.ToString() + item.Extension.ToString()));
										this.command.Parameters.Add(new SqlParameter("@loai", 1));
										this.command.Parameters.Add(new SqlParameter("@nhomnhan", item.IDreceive));
										this.command.ExecuteNonQuery();
										this.connection.Close();
										// Lưu file dưới dạng là 1 tin nhắn trong Database Table TINNHAN
										string query = "select USERS.ID, USERS.TENTK " +
														"from MEMBER, USERS where MEMBER.IDUSERS = USERS.ID " +
														"and MEMBER.IDNHOM = @id";
										connection = new SqlConnection(connString);
										connection.Open();
										command = new SqlCommand(query, connection);
										command.Parameters.AddWithValue("@id", item.IDreceive);
										reader = command.ExecuteReader();

										tempBuff = Encoding.UTF8.GetBytes("TEMPFILE%" + IDMessage.ToString() + "%" + item.IDsend + "%" + item.FileName + "%Public%" + item.IDreceive);
										packageReceive = new SmallPackage(1024, 1024, "M", tempBuff, "0");

										while (reader.HasRows)
										{
											if (!reader.Read()) break;
											foreach (var item2 in clientInvalid)
											{
												if (item2.id_ == reader.GetString(0))
												{
													try
													{
														await item2.client_.GetStream().WriteAsync(packageReceive.Packing(), 0, packageReceive.Packing().Length);
														break;
													}
													catch (Exception ex)
													{
														Debug.WriteLine(ex.ToString());
													}
												}
											}
										}
										connection.Close();

										// Gửi 1 file tạm gồm tên file và id của file về cho người nhận
										listAwaitPackage.Remove(item);
									}

								}
								break;
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
									byte[] tempBuff = new byte[item.Length - item.Ack];
									Buffer.BlockCopy(package.Data, 0, tempBuff, 0, item.Length - item.Ack);
									package.Data = new byte[item.Length - item.Ack];
									tempBuff.CopyTo(package.Data, 0);
								}
								package.Data.CopyTo(item.Data, item.Ack);
								item.Ack = item.Ack + package.Data.Length;
								if (item.Ack == item.Length)
								{
									string path = @"..\..\avatar\" + item.IDpackage + item.Extension;
                                    File.WriteAllBytes(path, item.Data);
                                    // Viết database lưu file đó vào bảng USERS tại địa chỉ ID của thằng đó
                                    string query = "UPDATE USERS SET SOURCEAVATAR = @SOURCE WHERE ID =@ID";
                                    connection = new SqlConnection(connString);
                                    connection.Open();
                                    command = new SqlCommand(query, connection);
                                    command.Parameters.AddWithValue("@SOURCE", path);
                                    command.Parameters.AddWithValue("@ID", client.id_);
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
							}
						}
					}
					System.Diagnostics.Debug.WriteLine("Received message: " + (Encoding.UTF8.GetString(package.Data).Trim('\0', '\t', '\n')));
					OnRaiseTextREceivedEvent(new TextReceivedEventArgs(
						client.client_.Client.RemoteEndPoint.ToString(),
						(Encoding.UTF8.GetString(package.Data).Trim('\0', '\t', '\n'))
					));
					Array.Clear(buff, 0, buff.Length);
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				string getId = client.id_;
				SendToAll(client, "OFFLINE%" + getId);
				clientInvalid.Remove(client);
				connection = new SqlConnection(connString);
				connection.Open();
				SqlCommand commandstatus = new SqlCommand(queryStatusOffline, connection);
				commandstatus.Parameters.AddWithValue("@id", getId);
				commandstatus.ExecuteNonQuery();
				OnRaiseTextREceivedEvent(new TextReceivedEventArgs(
						client.client_.Client.RemoteEndPoint.ToString(),
						"Offline" + getId ));
			}
		}
		public void RemoveClient(UserClient client)
		{
			if (clients.Contains(client))
			{
				clients.Remove(client);
				System.Diagnostics.Debug.WriteLine("Client removed, count: {0}", clients.Count);
			}
		}
		public void StopServer()
		{
			try
			{
				if (mListener != null)
					mListener.Stop();
				foreach (UserClient client in clients)
					client.client_.Close();
				clients.Clear();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
			}
		}
		public async Task SendToAll(UserClient clientFocus,string message)
		{
			if (string.IsNullOrEmpty(message))
				return;
			try
			{
				byte[] buffMessage = new byte[1024];
				byte[] tempBuff = Encoding.UTF8.GetBytes(message);
				SmallPackage tempPackage = new SmallPackage(buffMessage.Length, buffMessage.Length, "M", tempBuff, "0");
				buffMessage = tempPackage.Packing();

				foreach (UserClient client in clientInvalid)
				{
					if (client != clientFocus)
						client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}
		int bufferSize = 1024;
		public async Task ReceiveData(UserClient paramClient)
		{
			NetworkStream stream = paramClient.client_.GetStream();
			try
			{
				int byteRead;
				int allByteRead = 0;
				// Read length
				byte[] length = new byte[4];
				//byte[] extension = new byte[4];

				byteRead = stream.Read(length, 0, 4);
				//byteRead = stream.Read(extension, 0, 4);
				int dataLength = BitConverter.ToInt32(length, 0);
				//string ex = BitConverter.ToString(extension, 0);
				// Read data
				int byteLeft = dataLength;
				byte[] data = new byte[dataLength];

				while (byteLeft > 0)
				{
					int nextPackageSize = byteLeft > bufferSize ? bufferSize : byteLeft;
					byteRead = stream.Read(data, allByteRead, nextPackageSize);
					allByteRead += byteRead;
					byteLeft -= byteRead;
				}

				// Save image
				File.WriteAllBytes(@"C:\Users\datng\OneDrive\computer.png", data);

				// Report
				System.Diagnostics.Debug.WriteLine("File received");
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
			}
		}
	}
}
