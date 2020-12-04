using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucMessShow : UserControl
	{
		private string mess;
		private string idMess;
		private User user;
		public ucMessShow()
		{
			InitializeComponent();
		}
		public ucMessShow(string mess , User user)
		{
			InitializeComponent();
			this.user = user;
			this.label1.Text = mess;
			this.ScaleLabel();
			//if (user == Form1.me)
			//{
			//	this.BackColor = Form1.theme.MyMess;
			//}
   //         else
   //         this.BackColor = Form1.theme.PeopleMess;
		}
		public void ChangeTheme()
        {
			this.label1.ForeColor = Form1.theme.TextColor;
			//if (user == Form1.me)
			//{
			//	this.BackColor = Form1.theme.MyMess;
			//}
			//else
			//	this.BackColor = Form1.theme.PeopleMess;
			this.BackColor = Color.Transparent;
		}
		public void ScaleLabel()
		{
			Size lblTextSize() => TextRenderer.MeasureText(label1.Text, label1.Font);
			Size s = lblTextSize();
			while (true)
			{
				if (label1.Width < s.Width)
				{
					label1.Height = label1.Height +  (int)label1.Font.Size;
					s.Width = s.Width - label1.Width;
				}
				else break;
			}
		}
	}
}
