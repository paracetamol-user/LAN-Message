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
    public partial class ucGroupAll : UserControl
    {
        private GroupUI parent;
        private Panel pnParent;
        public ucGroupAll()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }
        public ucGroupAll(Group group, GroupUI groupUI)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.parent = groupUI;
            this.lbName.Text = group.Name;
            this.lbId.Text = "#" + group.ID;
        }
        private void picChat_Click(object sender, EventArgs e)
        {
            this.parent.ShowChatForm();
            this.parent.AddGroupInteracted();
        }
        public void SetAvatar(string path)
        {
            gunaPic.Image = Image.FromFile(path);
        }
    }
}
