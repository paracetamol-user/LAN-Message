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
            this.gunaPic.Image = Image.FromFile(uiParent.group.AvatarPath);
            this.lbName.Text = uiParent.group.Name;
            this.lbId.Text = uiParent.group.ID;
        }
        private void pnContain_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(242, 243, 245);
        }
        private void pnContain_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
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
            byte[] tempbuff = Encoding.UTF8.GetBytes("ACCEPTGROUP%" + Form1.me.Id + "%" );
            byte[] buff = new byte[1024];
            tempbuff.CopyTo(buff, 0);
            await Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
        }
    }
}
