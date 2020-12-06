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
    public partial class ucGroupToAdd : UserControl
    {
        public ucGroupToAdd()
        {
            InitializeComponent();
        }
        public ucGroupToAdd(Group group)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.lbName.Text = group.Name;
            this.lbID.Text = group.ID;
        }
        private void ucGroupToAdd_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(242, 243, 245);
        }
        private void ucGroupToAdd_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
