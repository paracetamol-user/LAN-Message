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
	public partial class ucNotification : UserControl
	{
		public string Text { get; set; }
		public ucNotification(string text)
		{
			InitializeComponent();
			Text = text;
			this.label1.Text = text;
			InitControl();
		}
		public void InitControl()
        {
			this.label1.ForeColor = FrmMain.theme.TxtForeColor;
			this.BackColor = FrmMain.theme.BackColor;
		}
	}
}
