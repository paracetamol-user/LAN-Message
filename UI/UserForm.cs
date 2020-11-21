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
        public UserForm(UserManager.User user)
        {
            InitializeComponent();
            this.Visible = false;
            this.user = user;
            this.id = 0;
            BoxChats = new List<Panel>();
            files = new List<FileInfo>();
        InitUserForm();
        }
        public void AddFileToListChat(string tempId, string tempName)
        {
            PanelFileDownLoad panelFileDownLoad = new PanelFileDownLoad();
            panelFileDownLoad._FileName = tempName;
            panelFileDownLoad._FileId = tempId;
            panelFileDownLoad.PanelListChat = this.panelListChat;
            panelFileDownLoad.User = this.user;
            panelFileDownLoad.Dock = DockStyle.Top;
            panelFileDownLoad.Init();
            this.panelListChat.Controls.Add(panelFileDownLoad);
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
        public async void SendMessage()
        {
            // Gửi tin nhắn qua server
            string data = "SEND%" + Form1.me.Id + "%" + user.Id + "%" + this.TextBoxEnterChat.Text;
            Form1.client.SendToServer(data);
            // tạo một panel chat 
            Panel tempPanel = new Panel();
            tempPanel.AutoSize = true;
            tempPanel = GetNewPanelBoxChat(Form1.me, this.TextBoxEnterChat.Text);
            //tempPanel.Dock = DockStyle.Top;
            this.panelListChat.Controls.Add(tempPanel);
            this.BoxChats.Add(tempPanel);
            //clear textbox nhập chat
            TextBoxEnterChat.Text = "";
        }
        public async void SendFile()
        {
            if (this.panelListFile.Controls.Count > 0)
            {
                foreach (var item in files)
                {
                    PanelFileDownLoad panelFileDownLoad = new PanelFileDownLoad();
                    panelFileDownLoad.Dock = DockStyle.Top;
                    panelFileDownLoad.User = user;
                    panelFileDownLoad._FileName = item.Name;
                    panelFileDownLoad.FileInfo = item;
                    this.panelListChat.Controls.Add(panelFileDownLoad);
                    //Gửi
                    byte[] data = File.ReadAllBytes(item.FullName);
         
                    byte[] package = new byte[data.Length];
                    data.CopyTo(package, 0);
                    
                    string str = "STARTFILE%" + item.Name+ "%" +data.Length.ToString()+"%"+ item.Extension + "%" +user.Id;      
                    await Form1.client.SendToServer(str);
           
                    await Form1.client.SendFileToServer(package);
                }
                
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
            SendFile();
           //SendMessage();
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
        public void AddItemInToListChat(string username , string str)
        {
            Panel tempPanel = new Panel();
            tempPanel = GetNewPanelBoxChat(user, str);
            this.panelListChat.Controls.Add(tempPanel);
            this.BoxChats.Add(tempPanel);
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
                        PanelFile x = new PanelFile(panelListFile,files, temp);
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
