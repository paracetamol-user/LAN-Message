using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ucGroup : UserControl
    {
        Form1 frmMain;
        List<GroupUI> GroupUIs;
        public ucGroup()
        {
            InitializeComponent();
        }
        public ucGroup(Form1 frmMain, List<GroupUI> GroupUIs)
        {
            this.frmMain = frmMain;
            this.GroupUIs = GroupUIs;
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.frmMain.PnRight.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Transparent;
            this.txtCreate.BackColor = Form1.theme.Menu;
            this.txtCreate.ForeColor = Form1.theme.TextColor;
            this.btnCreate.ForeColor = Form1.theme.TextColor;
            this.btnCreate.FlatAppearance.BorderColor = Form1.theme.TextColor;
            this.btnCreate.BackColor = Form1.theme.Menu;
        }
        public void _LoadGroup()
        {
            this.pnListGr.Controls.Clear();
            foreach (var item in GroupUIs)
            {
                this.pnListGr.Controls.Add(item.ucGroupAll);
            }
        }
        public void _AddGr(ucGroupAll Group)
        {
            
        }
    }
}
