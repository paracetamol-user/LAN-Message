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

namespace UI
{
	public partial class ucGroupInteract : UserControl
	{
		public GroupUI parent;
		public ucGroupInteract()
		{
			InitializeComponent();
		}
		public ucGroupInteract(GroupUI parent)
		{
			InitializeComponent();
			this.parent = parent;
			this.lbName.Text = parent.group.Name;
			this.lbStatus.Text = parent.group.ID;
			using (FileStream fs = new FileStream(parent.group.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
	
			this.lbStatus.ForeColor = FrmMain.theme.TextColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
		}
		public void ChangeTheme()
		{
			this.lbStatus.ForeColor = FrmMain.theme.TextColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
		}
		public void SetAvatar(string path)
		{
			using (FileStream fs = new FileStream(parent.group.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				this.roundPicAvatar.Image = Image.FromStream(fs);
				fs.Dispose();
			}
		}
		public void ChangeColorWhenClick()
		{
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
		public void ChangeColorWhenNonClick()
		{
			this.BackColor = Color.White;
		}
		private void ucGroupInteract_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
		}
		private void ucGroupInteract_MouseLeave(object sender, EventArgs e)
		{

		}

        private void gunaPic_MouseClick(object sender, MouseEventArgs e)
        {
			this.parent.groupForm.Show();
			this.parent.groupForm.BringToFront();
        }
    }
}
