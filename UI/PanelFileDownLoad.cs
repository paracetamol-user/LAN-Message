using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UserManager;

namespace UI
{
    public partial class PanelFileDownLoad : UserControl
    {
        private Panel panelListChat;
        private FileInfo fileInfo;
        private string fileName;
        private string fileId;
        public User user;
        public PanelFileDownLoad()
        {
            InitializeComponent();
        }
        public void Init()
        {
            this.labelName.Text = this.user.Name;
            this.labelFileName.Text = fileName;
            if (user == Form1.me)
            {
                this.pictureBox1.Image = Image.FromFile(@"..\..\images\avatar.png");
            }else this.pictureBox1.Image = Image.FromFile(@"..\..\images\123.jfif");
        }
        public FileInfo FileInfo
        {
            get
            {
                return this.fileInfo;
            }
            set
            {
                this.fileInfo = value;
            }
        }
        public User User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }
        public Panel PanelListChat
        {
            get
            {
                return this.panelListChat;
            }
            set
            {
                this.panelListChat = value;
            }
        }
        public string _FileId
        {
            get
            {
                return this.fileId;
            }
            set
            {
                this.fileId = value;
            }
        }
        public void ChangeIconCheck()
        {
            this.pictureBoxClose.Image = Image.FromFile(@"..\..\images\check (1).png");
        }
        public string _FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        private async void pictureBoxClose_Click(object sender, EventArgs e)
        {
            string str = "SENDFILE%" + this.fileId + "%" + this.fileName + "%" + user.Id;
            await Form1.client.SendToServer(str);
        }
    }
}
