using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddFriendForm : Form
    {
        public static Panel panelListUserRight;
        public AddFriendForm()
        {
            InitializeComponent();
            panelListUserRight = new Panel();
            this.Controls.Add(panelListUserRight);
            this.InitPanelListUser();
        }


        private void gunaButtonOnline_Click(object sender, EventArgs e)
        {
            AddFriendForm.panelListUserRight.Controls.Clear();;
            for (int i = 0; i < Form1.UserUIs.Count; i++)
            {
                if (Form1.UserUIs[i].GetStatus() == true)
                {
                    Form1.UserUIs[i].AddInfoUserIntoPanel();
                }
            }
            
        }

        private void InitPanelListUser()
        {
            AddFriendForm.panelListUserRight.Dock = DockStyle.Fill;
            AddFriendForm.panelListUserRight.BackColor = Color.White;
            AddFriendForm.panelListUserRight.Padding = new Padding(30, 20, 0, 0);
            AddFriendForm.panelListUserRight.BringToFront();
        }

        private void gunaButtonAll_Click(object sender, EventArgs e)
        {
            AddFriendForm.panelListUserRight.Controls.Clear();

            for (int i = 0; i < Form1.UserUIs.Count; i++)
            {
                 Form1.UserUIs[i].AddInfoUserIntoPanel();
            
            }
        }
    }
}
