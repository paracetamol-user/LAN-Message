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
        Group group;
        User user;
        public ucMember()
        {
            InitializeComponent();
            locationlabel(ref label1, panel4);
            locationlabel(ref labeladdmin, pnadmin);
            InitColor();
            SetName(user.Name);
            SetAvatar(user.AvatarPath);
            this.group = group;
            this.user = user;
            _loadadmin();
        }
        public ucMember(Group group, User user)
        {
            InitializeComponent();
            locationlabel(ref label1, panel4);
            locationlabel(ref labeladdmin, pnadmin);
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
                labeladdmin.Text = "(admin)";
                Showpaneladmin();
                if (user != Form1.me)
                {
                    Hidedeletemember();
                }

            }
            else
            {
                Hidepaneladmin();
            }
        }
        public void InitColor()
        {

            this.BackColor = Color.Transparent;
            label1.ForeColor = Form1.theme.TextColor;
            labeladdmin.ForeColor = Form1.theme.TextColor;
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
            pnLine1.BackColor = Form1.theme.LineColor;
            pnLine2.BackColor = Form1.theme.LineColor;
        }
        public void locationlabel(ref Label a, Panel b)
        {

            int y = (b.Height - a.Height) / 2;
            a.Location = new Point(a.Location.X, y);

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
            pnadmin.Size = new Size(pnadmin.Width, 0);
            pnadmin.Visible = false;
            locationlabel(ref label1, panel4);
            locationlabel(ref labeladdmin, pnadmin);
        }
        public void Showpaneladmin()
        {
            pnadmin.Size = new Size(pnadmin.Width, panel1.Height / 2 - 1);
            pnadmin.Visible = true;
            locationlabel(ref label1, panel4);
            locationlabel(ref labeladdmin, pnadmin);
        }
        public void Hidedeletemember()
        {
            pndeletemember.Visible = false;
        }
    }
}
