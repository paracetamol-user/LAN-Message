using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
namespace UI
{
    public partial class ucMember : UserControl
    {
        public Group group;
        public User user;
        public ucMember()
        {
            InitializeComponent();
            InitColor();
            SetName(user.Name);
            SetAvatar(user.AvatarPath);
            _loadadmin();
        }
        public ucMember(Group group, User user)
        {
            InitializeComponent();
            InitColor();
            SetName(user.Name);
            SetAvatar(user.AvatarPath);
            this.group = group;
            this.user = user;
            _loadadmin();
        }
        public void _loadadmin()
        {
            if (group.admin == user)
            {
                labeladdmin.Text = "(Admin)";
                Showpaneladmin();
                Hidedeletemember();
            }
            else
            {
                Hidepaneladmin();
            }
            if (group.admin != FrmMain.me) Hidedeletemember();
        }
        public void InitColor()
        {
            this.BackColor = Color.Transparent;
            label1.ForeColor = FrmMain.theme.TextColor;
            labeladdmin.ForeColor = FrmMain.theme.TextColor;
            this.pictureBoxdeletemember.Image = Image.FromFile(FrmMain.theme.PictureClose);
        }
        public Label labeladmin
        {
            get
            {
                return this.labeladdmin;
            }
            set
            {
                this.labeladdmin = value;
            }
        }

        public void changecolorline()
        {
            pnLine1.BackColor = FrmMain.theme.LineColor;
            pnLine2.BackColor = FrmMain.theme.LineColor;
        }
        public void SetName(string name)
        {
            label1.Text = name;
        }
        public void SetAvatar(string path)
        {
            roundpicturebox1.Image = Image.FromFile(path);
            roundpicturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void Hidepaneladmin()
        {
            pnadmin.Visible = false;

        }
        public void Showpaneladmin()
        {
            pnadmin.Visible = true;
        }
        public void Hidedeletemember()
        {
            pndeletemember.Visible = false;
        }

        private void pictureBoxdeletemember_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes("KICKMEMBER%" + group.ID + "%" + user.Id);
                SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buffer, "Server");
                FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
                group.RemoveMember(user.Id);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }
    }
}
