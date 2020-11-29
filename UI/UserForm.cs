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
using Guna.UI2.WinForms;
using System.IO;

namespace UI
{
    public partial class UserForm : Form
    {
        private User user;
        private List<Panel> BoxChats;
        private int id;
        private int locationControl = 0;
        private List<FileInfo> files;
        private short LastInteracted;
        public UserForm(UserManager.User user)
        {
            InitializeComponent();
            this.Visible = false;
            this.user = user;
            this.id = 0;
            LastInteracted = 0;
            BoxChats = new List<Panel>();
            files = new List<FileInfo>();
            InitUserForm();
        }
        public void SetAvatar(string path)
        {
            
        }
        public void AddFileToListChat(User _user,string tempId, string tempName , short tempInteracted)
        {
            Panel tempPanel = new Panel();
            tempPanel.AutoSize = true;
            tempPanel.Dock = DockStyle.Top;
            //if (LastInteracted != tempInteracted || LastInteracted == 0)
            //{
                ucUserINChatBox UserInChatBox = new ucUserINChatBox(_user);
                ucFileShow fileshow = new ucFileShow(_user, tempId, tempName);
                if (_user == Form1.me) fileshow._DisableButDownLoad();
                fileshow.Dock = DockStyle.Top;
                UserInChatBox.Dock = DockStyle.Top;
                
                UserInChatBox._AddFileControl(fileshow);
                tempPanel.Controls.Add(UserInChatBox);
                this.panelListChat.Controls.Add(tempPanel);
                LastInteracted = tempInteracted;
            //}
            //else
            //{
            //    ucFileShow fileshow = new ucFileShow(user, tempId, tempName);
            //    fileshow.Dock = DockStyle.Top;
            //    tempPanel.Controls.Add(fileshow);
            //    tempPanel.Padding = new Padding(60, 0, 0, 0);
            //    this.panelListChat.Controls.Add(tempPanel);;
            //}
        }
        private Panel GetNewPanelBoxChat(User userfocus , string tinnhan)
        {
            Panel tempPanel = new Panel();
            
            Panel panelNameAndMess = new Panel();
            Panel infoUser = new Panel();
            Panel avatar = new Panel();
            Panel mess = new Panel();
            Panel option = new Panel();
            Label idmess = new Label(); idmess.Visible = false;
            idmess.Text = (id + 1).ToString();

            Guna2CirclePictureBox pictureAvatar = new Guna2CirclePictureBox();
            if (userfocus != Form1.me)  pictureAvatar.Image = Image.FromFile(@"..\..\images\123.jfif");
            else pictureAvatar.Image = Image.FromFile(@"..\..\images\avatar.jpg");
            pictureAvatar.Dock = DockStyle.Top;
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.Size = new Size(36, 36);

            avatar.Controls.Add(pictureAvatar);
            
            //
            Label name = new Label();
            name.Text = userfocus.Name;
            name.Dock = DockStyle.Fill;
            if (userfocus != Form1.me ) name.ForeColor = Color.DarkBlue;
            else name.ForeColor = Color.DarkRed;
            name.Font = new Font("Century", 11, FontStyle.Bold);
            infoUser.Controls.Add(name);
            
            //
            Label text = new Label();
            text.Dock = DockStyle.Fill;
            text.Text = tinnhan;
            text.ForeColor = Color.DimGray;
            text.Font = new Font("Conoloas", 9);
            text.AutoSize = false;
            mess.Controls.Add(text);

            //

            PictureBox pictureOption = new PictureBox();
            pictureOption.Image = Image.FromFile(@"..\..\images\menu (1).png");
            pictureOption.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOption.Size = new Size(20, 20);
            pictureOption.Dock = DockStyle.Top;
            option.Controls.Add(pictureOption);
            //
            avatar.Dock = DockStyle.Left;
            avatar.Width = 37;
            //avatar.BackColor = Color.Yellow;
            //
            infoUser.Dock = DockStyle.Top;
            infoUser.Padding = new Padding(5, 0, 20, 0);
            infoUser.Height = 20;
            mess.Dock = DockStyle.Top;
            mess.Padding = new Padding(5, 5, 20, 0);
            mess.AutoSize = false;
            //mess.BackColor = Color.DeepPink;
 
            panelNameAndMess.Controls.Add(mess);
            panelNameAndMess.Controls.Add(infoUser);
            panelNameAndMess.Dock = DockStyle.Fill;
            panelNameAndMess.AutoSize = true;
           // panelNameAndMess.BackColor = Color.Blue;
            //
            option.Dock = DockStyle.Right;
            option.Padding = new Padding(5, 10, 5, 0);
            //option.BackColor = Color.Green;
            option.Width = 20;
            // ENDING
            
            tempPanel.Controls.Add(panelNameAndMess);
            tempPanel.Controls.Add(option);
            tempPanel.Controls.Add(avatar);
            tempPanel.Dock = DockStyle.Top;
            tempPanel.Padding = new Padding(5,10,20,0);
            //tempPanel.BorderStyle = BorderStyle.FixedSingle;
            tempPanel.BackColor = Color.White;
            tempPanel.Height = 70;
            //tempPanel.AutoSize = true;
            return tempPanel;
        }
        public async Task SendMessage()
        {
            if (TextBoxEnterChat.Text != "")
            {
                // Gửi tin nhắn qua server
                byte[] buff = new byte[1024];
                byte[] tempbuff;
                tempbuff = System.Text.Encoding.UTF8.GetBytes("SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text);
                tempbuff.CopyTo(buff, 0);
                Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);

                // tạo một panel chat 
                this.AddItemInToListChat(Form1.me, this.TextBoxEnterChat.Text, 1);

                //clear textbox nhập chat
                TextBoxEnterChat.Text = "";
            }
        }
        public async Task SendFile()
        {
            if (this.panelListFile.Controls.Count > 0)
            {
                foreach (var item in files)
                {
                    AddFileToListChat(Form1.me, "-1", item.Name, 1);
                    //Gửi
                    byte[] data = File.ReadAllBytes(item.FullName);
                    int temp = 1024 - (data.Length % 1024);
                    byte[] package = new byte[data.Length + temp];
                    data.CopyTo(package, 0);
                    byte[] buff = new byte[1024];
                    byte[] tempbuff;
                    tempbuff = System.Text.Encoding.UTF8.GetBytes("STARTFILE%" + item.Name + "%" + data.Length.ToString() + "%" + item.Extension + "%" + user.Id);
                    tempbuff.CopyTo(buff, 0);
                    await Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
                    await Form1.client.SendFileToServer(package);
                }
                this.files.Clear();
                this.panelListFile.Controls.Clear();
                this.panelListFile.Visible = false;
            }
        }
        private void InitUserForm()
        {
            this.labelID.Text = "#"+user.Id;
            this.labelName.Text = user.Name;
            this.pictureBoxSend.Click += PictureBoxSend_Click;
        }

        private async void PictureBoxSend_Click(object sender, EventArgs e)
        {
            await SendFile();
            await SendMessage();
        }

        public UserForm()
        {
            InitializeComponent();
            this.Visible = false;
        }
        public void HideForm()
        {
            this.Visible = false;
        }
        public void ShowForm()
        {
            this.Visible = true;
        }
        public void AddItemInToListChat(User user,string str , short tempInteracted)
        {
            Panel tempPanel = new Panel();
            tempPanel.Dock = DockStyle.Top;
            tempPanel.AutoSize = true;
           // tempPanel.BorderStyle = BorderStyle.FixedSingle;
            //if (LastInteracted != tempInteracted || LastInteracted == 0)
            //{
                ucUserINChatBox UserInChatBox = new ucUserINChatBox(user);
                ucMessShow messShow = new ucMessShow(str);
                messShow.Dock = DockStyle.Top;
                UserInChatBox.Dock = DockStyle.Top;
                UserInChatBox._AddMessControl(messShow);
                tempPanel.Controls.Add(UserInChatBox);
                this.panelListChat.Controls.Add(tempPanel);
                LastInteracted = tempInteracted;
            //}
            //else if (LastInteracted == tempInteracted)
            //{
            //    ucMessShow messShow = new ucMessShow(str);
            //    messShow.Dock = DockStyle.Top;
            //    tempPanel.Controls.Add(messShow);
            //    tempPanel.Padding = new Padding(60, 0, 0, 0);
            //    this.panelListChat.Controls.Add(tempPanel); ;
            //}
            
            this.panelListChat.Controls.Add(tempPanel);
        }
        public void AddFrom(Panel panelRight)
        {
            panelRight.Controls.Add(this);
        }

        private void TextBoxEnterChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                        usFileTemp x = new usFileTemp(panelListFile,files, temp);
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

    }
}
