using Network;
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


        string connString = @"Data Source=Paracetamol;Initial Catalog=LANCHAT;Integrated Security=True";
        string queryLogin = "select * from USERS";
        string queryStatusOnline = "UPDATE USERS SET TINHTRANG = 1 WHERE ID = @id";
        string queryStatusOffline = "UPDATE USERS SET TINHTRANG = 0 WHERE ID = @id";
        string queryMessage = "insert into TINNHAN values(@id,@idnguoigui,@idnguoinhan,@tinnhan,@loai)";
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
		private async Task<bool> RespondToClient(UserClient client, string received, byte[] buff, InfoByte infoByte, int nReturn)
		{
			string[] data = received.Split('%');
			byte[] buffMessage = new byte[1024];
			bool check = true;
			if (data[0] == "SIGNUP")
			{
				try
				{
					string idEnd = "";
				   
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(queryLogin,connection);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						if (data[1] == reader.GetString(1))
						{
							byte[] tempBuff = Encoding.UTF8.GetBytes("SIGNUPNO");
							tempBuff.CopyTo(buffMessage, 0);
							await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
							return true;
						}
						idEnd = reader.GetString(0);
					}
					int.TryParse(idEnd,out idfocus);
					idfocus++;
					connection.Close();
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand("INSERT INTO USERS VALUES (@id , @tendangnhap , @matkhau, @hoten ,@sdt, @gioitinh, @tinhtrang,@source)", connection);
					command.Parameters.AddWithValue("@id", idfocus.ToString());
					command.Parameters.AddWithValue("@tendangnhap", data[1]);
					command.Parameters.AddWithValue("@matkhau", data[2]);
					command.Parameters.AddWithValue("@hoten", data[3]);
					command.Parameters.AddWithValue("@sdt", data[4]);
					command.Parameters.AddWithValue("@gioitinh", data[5] == "True" ? 0 : 1   );
					command.Parameters.AddWithValue("@tinhtrang", 0);
					command.Parameters.AddWithValue("@source", "Default");
					command.ExecuteNonQuery();
					byte[] tempBuffer = Encoding.UTF8.GetBytes("SIGNUPOKE");
					tempBuffer.CopyTo(buffMessage, 0);
					client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
					SendToAll(client, "ADDUSER%" + idfocus.ToString() +"%"+ data[1]);
					return true;
					connection.Close();
				}
				catch (Exception ex)
				{
					return true;
				}
				return true;
			}
			else if (data[0] == "LOGIN")
			{
				try
				{
					connection = new SqlConnection(connString);
					connection.Open();
					command = new SqlCommand(queryLogin, connection);
					reader = command.ExecuteReader();
					while (reader.HasRows)
					{
						if (reader.Read() == false) break;
						if (data[1] == reader.GetString(1) && data[2] == reader.GetString(2))
						{
							byte[] tempBuff = Encoding.UTF8.GetBytes("LOGINOKE " + reader.GetString(0));
							tempBuff.CopyTo(buffMessage, 0);
							await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
							client.id_ = reader.GetString(0);
							clientInvalid.Add(client);
							SendToAll(client, "ONLINE%" + client.id_.ToString());
							//string temp = queryStatusOnline + client.id_.ToString();
							connection.Close();
							connection = new SqlConnection(connString);
							connection.Open();
							SqlCommand commandstatus = new SqlCommand(queryStatusOnline, connection);
							commandstatus.Parameters.AddWithValue("@id", client.id_);
							commandstatus.ExecuteNonQuery();
							connection.Close();
							check = false;
							break;
						}
					}
					if (check != false)
					{
						buffMessage = Encoding.UTF8.GetBytes("LOGIN ERR");
						await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
					return true;
				}
				return true;
			}
			else if (data[0] == "LOADUSERDATA")
			{
				try
				{
					byte[] tempbuff;
					connection.Close();
					/// Gửi tên và id mọi người về cho client;
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
					buffMessage = new byte[1024];
					tempbuff = Encoding.UTF8.GetBytes(arr);
					tempbuff.CopyTo(buffMessage, 0);
					await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
					/// Gửi Ai là bạn về cho client 
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
					buffMessage = new byte[1024];
					tempbuff = Encoding.UTF8.GetBytes(arr);
					tempbuff.CopyTo(buffMessage, 0);
					await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
					/// Gửi Avatar cho client
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
							long temp = 1024 - (fi.Length % 1024);
							byte[] package = new byte[fi.Length + temp];
							byte[] packagetemp = File.ReadAllBytes(path);
							packagetemp.CopyTo(package, 0);
							tempbuff = Encoding.UTF8.GetBytes(string.Format("AVATAR%{0}%{1}%{2}", reader.GetString(0), fi.Length, fi.Extension));
							buffMessage = new byte[1024];
							tempbuff.CopyTo(buffMessage, 0);
							await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
							await SendFileToClient(package, client);
						}
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}
				return true;
			}
			else if (data[0] == "SEND") //"SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text;
								   // SEND  + Id của thằng gửi + ID thằng nhận + tin nhắn
			{
				int i = 0;
				foreach (var item in clientInvalid)
				{
					if (item.id_.ToString() == data[2])
					{
						try
						{
							byte[] tempbuff;
							buffMessage = new byte[1024];
							tempbuff = Encoding.UTF8.GetBytes("MESSAGE" + "%" + data[3] + "%" + data[1]);
							tempbuff.CopyTo(buffMessage, 0);
							await item.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
							return true;
						}
						catch (Exception ex)
						{
							Debug.WriteLine(ex.ToString());
						}
					}
					i++;
				   
				}
				return true;
			}
			else if (data[0] == "SENDFILE") // SENDFILE - FILEID - FILENAME - ID THẰNG GỬI LÊN
			{
				string queryFINDSOURCE = "SELECT * FROM TINNHAN";
				string FILEID = data[1];
				string FILENAME = data[2];
				string ID = data[3];
				string path = "";
				string IDNGUOIGUI= "";
				connection = new SqlConnection(this.connString);
				connection.Open();
				command = new SqlCommand(queryFINDSOURCE, connection);
				//command.Parameters.AddWithValue("@MATINNHAN", FILEID.ToString());
				reader = command.ExecuteReader();
				while (reader.HasRows)
				{
					if (reader.Read() == false) break;
					if (reader.GetString(0) == FILEID)
					{
						path = reader.GetString(3).ToString();
						IDNGUOIGUI = reader.GetString(2).ToString();
						break;
					}
				}
				connection.Close();
				FileInfo fileInfo = new FileInfo(path);
				byte[] fileData = File.ReadAllBytes(fileInfo.FullName);
				byte[] tempbuff;
				tempbuff = Encoding.UTF8.GetBytes("FILE" + "%" + FILEID + "%" + FILENAME + "%"+ fileData.Length.ToString()+"%" + fileInfo.Extension.ToString()+"%" + IDNGUOIGUI);
				tempbuff.CopyTo(buffMessage, 0);
				await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
				
				int temp = 1024 - (fileData.Length % 1024);
				byte[] package = new byte[fileData.Length + temp];
				fileData.CopyTo(package, 0);
				SendFileToClient(package, client);
				return true;
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


				buffMessage = Encoding.UTF8.GetBytes(messageToClient);
				await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

				return true;
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

				buffMessage = Encoding.UTF8.GetBytes(messageToClient);
				await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

				return true;
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
							byte[] tempbuff = Encoding.UTF8.GetBytes("ACCEPTFRIEND%" + data[1]);
							buffMessage = new byte[1024];
							tempbuff.CopyTo(buffMessage, 0);
							await item.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
							break;
						}
					}
				}
				catch (Exception ex)
                {

                }
				return true;
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
						byte[] tempbuff = Encoding.UTF8.GetBytes("REMOVEFRIEND%" + data[1]);
						buffMessage = new byte[1024];
						tempbuff.CopyTo(buffMessage, 0);
						await item.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
						break;
					}
				}
				
				return true;
			}
			else if (data[0] == "PENDING")
            {
				byte[] tempbuff = Encoding.UTF8.GetBytes("PENDING%" + data[1]);
				buffMessage = new byte[1024];
				tempbuff.CopyTo(buffMessage, 0);
                foreach (var item in clientInvalid)
                {
					if (item.id_ == data[2])
                    {
						await item.client_.GetStream().WriteAsync(buffMessage,0,buffMessage.Length);
						break;
					}
                }
				return true;
            }
			return false;
		}
		private async Task SendFileToClient(byte[] package , UserClient client)
		{
			int byteSent = 0;
			int byteLeft = package.Length;
			int nextPackageSize = 1024;
			while (byteLeft>0)
			{
				//if (byteLeft > 1024) nextPackageSize = 1024;
				//else nextPackageSize = byteLeft;
				client.client_.GetStream().WriteAsync(package, byteSent, nextPackageSize);
				byteSent += nextPackageSize;
				byteLeft-=nextPackageSize;
			}
		}
		public async Task WorkWithClient(UserClient client)
		{
			NetworkStream stream = null;
			StreamReader reader = null;
			InfoByte infoByte = new InfoByte();
			byte[] dataFile = null;
			bool isFile = false;
			bool isAvatar = false;
			try
			{
				stream = client.client_.GetStream();
				reader = new StreamReader(stream);
				while (true)
				{
					byte[] buff = new byte[1024];
					int nReturn = await stream.ReadAsync(buff, 0, buff.Length);
					if (nReturn == 0)
					{
						RemoveClient(client);
						break;
					}
					string received = System.Text.Encoding.UTF8.GetString(buff, 0, nReturn).Trim('\0','\t','\r','\n');
					// Nếu trả về true là server có phản hồi với client
					bool temp = await RespondToClient(client, received, buff, infoByte, nReturn);
					// Nếu temp là false thì thực hiện các thao tác gửi file và nhận file
					if (temp == false)
					{
						string[] data = received.Split('%');
						if (data[0] == "STARTFILE") // Bất đầu nhận file truyền qua người dùng khác
						{
							isFile = true;
							infoByte = new InfoByte();
							infoByte.Name = data[1];
							infoByte.Length = int.Parse(data[2]);
							infoByte.Extension = data[3];
							infoByte.ID = data[4];   
							dataFile = new byte[infoByte.Length]; // không gian lưu cái file chuẩn bị gửi lên
	   
						}else
						if (data[0] == "SAVEAVATAR")// Bắt đầu nhận avatar từ client
						{
							isAvatar = true;
							infoByte = new InfoByte();
							infoByte.Name = data[2];
							infoByte.Length = int.Parse(data[3]);
							infoByte.Extension = data[4];
							infoByte.ID = data[1];
							dataFile = new byte[infoByte.Length];
						}
						else // khong phải hành động -> gói tin
						{
							if (buff.Length + infoByte.AllByteRead > infoByte.Length)
							{
								Array.Resize(ref buff,1024 - (buff.Length + infoByte.AllByteRead - infoByte.Length));
							}
							buff.CopyTo(dataFile, infoByte.AllByteRead);
							infoByte.AllByteRead = infoByte.AllByteRead + buff.Length;
							if (infoByte.AllByteRead == infoByte.Length) // khi nhan du du lieu -> file
							{
								if (isFile)
                                {
									isFile = false;
									// tạo id
									Guid Createid = Guid.NewGuid();
									// Lưu File trong Filedata
									File.WriteAllBytes(@"..\..\filedata\" + Createid.ToString() + infoByte.Extension, dataFile);
									// them du lieu vao data base
									this.connection = new SqlConnection(this.connString);
									this.connection.Open();
									this.command = new SqlCommand(queryMessage, connection);
									this.command.Parameters.Add(new SqlParameter("@id", Createid.ToString()));
									this.command.Parameters.Add(new SqlParameter("@idnguoigui", client.id_));
									this.command.Parameters.Add(new SqlParameter("@idnguoinhan", infoByte.ID));
									this.command.Parameters.Add(new SqlParameter("@tinnhan", @"..\..\filedata\" + Createid.ToString() + infoByte.Extension.ToString()));
									this.command.Parameters.Add(new SqlParameter("@loai", 1));
									this.command.ExecuteNonQuery();
									this.connection.Close();
									int i = 0;
									// Gửi cho client 1 file tạm của file gồm tên và extesion, id file
									foreach (var item in clientInvalid)
									{
										if (item.id_.ToString() == infoByte.ID)
										{
											try
											{
												byte[] buffMessage = new byte[1024];
												byte[] bufferSendToClintReceive = System.Text.Encoding.UTF8.GetBytes("TEMPFILE%" + Createid.ToString() + "%" + client.id_ + "%" + infoByte.Name);
												bufferSendToClintReceive.CopyTo(buffMessage, 0);
												await item.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
												break;
											}
											catch (Exception ex)
											{
												Debug.WriteLine(ex.ToString());
											}
										}
										i++;
									}
								}
                                else if (isAvatar)
                                {
									isAvatar = false;
									string path = @"..\..\avatar\" + infoByte.ID + infoByte.Extension;
									File.WriteAllBytes(path, dataFile);
									// Viết database lưu file đó vào bảng USERS tại địa chỉ ID của thằng đó
									string query = "UPDATE USERS SET SOURCEAVATAR = @SOURCE WHERE ID =@ID";
									connection = new SqlConnection(connString);
									connection.Open();
									command = new SqlCommand(query, connection);
									command.Parameters.AddWithValue("@SOURCE", path);
									command.Parameters.AddWithValue("@ID", infoByte.ID);
									command.ExecuteNonQuery();
									connection.Close();
								}
							}
						}
					}
					System.Diagnostics.Debug.WriteLine("Received message: " + received);
					OnRaiseTextREceivedEvent(new TextReceivedEventArgs(
						client.client_.Client.RemoteEndPoint.ToString(),
						received
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
			}
		}
		private void RemoveClient(UserClient client)
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
				byte[] temp;
				temp = Encoding.UTF8.GetBytes(message);
				temp.CopyTo(buffMessage, 0); 
				foreach (UserClient client in clientInvalid)
				{
					if (client != clientFocus)
					await client.client_.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}
		// FTP 
		int bufferSize = 1024;
		private async Task ReceiveData(UserClient paramClient)
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
