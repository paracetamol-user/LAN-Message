using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
    public partial class ucUserINChatBox : UserControl
    {
        private User user;
        public ucUserINChatBox()
        {
            InitializeComponent();
        }
        public ucUserINChatBox(User _user)
        {
            InitializeComponent();
            this.user = _user;
            this.labelName.Text = user.Name;
            if (this.user == Form1.me)
            {
                pictureBox1.Image = Image.FromFile(Form1.me.AvatarPath);
            }
            else pictureBox1.Image = Image.FromFile(user.AvatarPath);
        }
        public User _User
        {
            set
            {
                this.user = value;
            }
        }
        public void _AddFileControl(ucFileShow filecontrol)
        {
            this.panelAddMessage.Controls.Add(filecontrol);
        }
        public void _AddMessControl(ucMessShow messcontrol)
        {
            this.panelAddMessage.Controls.Add(messcontrol);
        }
    }
}
