
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
    public partial class ucGroupAll : UserControl
    {
        private GroupUI Parent;
        private Panel pnParent;
        public ucGroupAll()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.lbId.ForeColor = FrmMain.theme.TextColor;
            this.lbName.ForeColor = FrmMain.theme.TextColor;
            this.pnLine.BackColor = FrmMain.theme.LineColor;
            this.picAdd.Image = Image.FromFile(FrmMain.theme.PictureMenu);
            this.picChat.Image = Image.FromFile(FrmMain.theme.PictureMessage);
        }
        public ucGroupAll(Group group, GroupUI groupUI)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.Parent = groupUI;
            this.lbName.Text = group.Name;
            this.lbId.Text = "#" + group.ID;
            using (FileStream fs = new FileStream(group.AvatarPath, FileMode.Open, FileAccess.Read))
            {
                this.roundPicAvatar.Image = Image.FromStream(fs);
                fs.Dispose();
            }
            InitControls();
        }
        public void InitControls()
        {
            this.lbId.ForeColor = FrmMain.theme.TextColor;
            this.lbName.ForeColor = FrmMain.theme.TextColor;
            this.pnLine.BackColor = FrmMain.theme.LineColor;
            this.picAdd.Image = Image.FromFile(FrmMain.theme.PictureMenu);
            this.picChat.Image = Image.FromFile(FrmMain.theme.PictureMessage);
            
        }
        private void picChat_Click(object sender, EventArgs e)
        {
            this.Parent.ShowChatForm();
            this.Parent.AddGroupInteracted();
        }
        public void SetAvatar(string path)
        {
            //gunaPic.Image = Image.FromFile(path);
        }

        private void gunaPic_MouseClick(object sender, MouseEventArgs e)
        {
            this.Parent.ShowChatForm();
            this.Parent.AddGroupInteracted();
            if (FrmMain.interactFocus != null)
            {
                FrmMain.interactFocus.ChangeColorWhenNonClick();
            }
            this.Parent.ucGroupInteract.ChangeColorWhenClick();
            FrmMain.interactFocus = this.Parent.ucGroupInteract;
        }
        private void picAdd_Click(object sender, EventArgs e)
        {
            this.Parent.cmns.BackColor = FrmMain.theme.Menu;
            Parent.cmns.Items[0].ForeColor = FrmMain.theme.TxtForeColor;
            Parent.cmns.Items[1].ForeColor = FrmMain.theme.TxtForeColor;
            this.Parent.cmns.Show(MousePosition);
        }
    }
}
