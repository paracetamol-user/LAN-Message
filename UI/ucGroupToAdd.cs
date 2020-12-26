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
		public Group group { get; set; }
		public bool isAdd { get; set; }
		public ucGroupToAdd()
		{
			InitializeComponent();
		}
		public ucGroupToAdd(Group group)
		{
			InitializeComponent();
			this.Dock = DockStyle.Top;
			this.label1.Text = group.Name;
			this.label2.Text = "#" + group.ID;
			this.group = group;
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.label2.ForeColor = FrmMain.theme.TextColor;
			this.button1.ForeColor = FrmMain.theme.TextColor;
			this.roundPicAvatar.Image = Image.FromFile(group.AvatarPath);
		}
		public void InitColor()
		{
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.label2.ForeColor = FrmMain.theme.TextColor;
			this.button1.ForeColor = FrmMain.theme.TextColor;
		}
		public void Reset()
        {
			button1.Text = "ADD";
			isAdd = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
			if (button1.Text == "ADD")
			{
				isAdd = true;
				button1.Text = "CANCEL";
			}
			else
			{
				isAdd = false;
				button1.Text = "ADD";
			}
		}
    }
}
