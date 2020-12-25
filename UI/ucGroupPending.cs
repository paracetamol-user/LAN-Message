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

namespace UI
{
    public partial class ucGroupPending : UserControl
    {
        Panel pnParent;
        GroupUI uiParent;
        public ucGroupPending()
        {
            InitializeComponent();
        }
        public ucGroupPending(GroupUI groupUI, Panel pnPending)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.pnParent = pnPending;
            this.uiParent = groupUI;
            this.roundPicAvatar.Image = Image.FromFile(uiParent.group.AvatarPath);
            this.lbName.Text = uiParent.group.Name;
            this.lbId.Text = uiParent.group.ID;
            InitColor();
        }
        public ucGroupPending(string id , string name, Panel pnPending)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.pnParent = pnPending;
            this.roundPicAvatar.Image = Image.FromFile(uiParent.group.AvatarPath);
            this.lbName.Text = name;
            this.lbId.Text = id;
            this.lbId.ForeColor = FrmMain.theme.TextColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
        }
        public void InitColor()
        {
            this.lbId.ForeColor = FrmMain.theme.TextColor;
            this.lbName.ForeColor = FrmMain.theme.TextColor;
            this.picCheck.Image = Image.FromFile(FrmMain.theme.PictureCheck);
            this.picClose.Image = Image.FromFile(FrmMain.theme.PictureClose);
        }
        private void picMenu_Click(object sender, EventArgs e)
        {
            pnParent.Controls.Remove(this);
        }
        private void picCheck_Click(object sender, EventArgs e)
        {
            SendAcceptGroupInviteToServer();
            pnParent.Controls.Remove(this);
        }
        private async void SendAcceptGroupInviteToServer()
        {
            try
            {
                // goi len server gui thanh vien ve
                byte[] tempbuff = Encoding.UTF8.GetBytes("GROUPACCEPT%" + uiParent.group.ID + "%" + uiParent.group.Name + "%"
                                                                        + FrmMain.me.Id + "%" + FrmMain.me.Name);
                SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
                FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
                pnParent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
