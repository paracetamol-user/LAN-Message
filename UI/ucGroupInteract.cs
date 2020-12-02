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
	public partial class ucGroupInteract : UserControl
	{
		public UserUI parent;
		public ucGroupInteract()
		{
			InitializeComponent();
		}
		public ucGroupInteract(UserUI parent)
		{
			InitializeComponent();
			this.parent = parent;
		}
		public void SetAvatar(string path)
		{
			this.gunaPic.Image = Image.FromFile(path);
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
    }
}
