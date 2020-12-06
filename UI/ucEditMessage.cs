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
	public partial class ucEditMessage : UserControl
	{
		private ucUserINChatBox pnparent;
		private ucMessShow ucmessshow;
		public ucEditMessage()
		{
			InitializeComponent();
		}
		public ucEditMessage(ucUserINChatBox ucUserINChatBox , ucMessShow ucMessShow)
		{
			InitializeComponent();
			this.pnparent = ucUserINChatBox;
			this.ucmessshow = ucMessShow;
			this.lbCancel.ForeColor = Form1.theme.TxtForeColor;
			this.lbSave.ForeColor = Form1.theme.TxtForeColor;
			this.textBox1.BackColor = Form1.theme.BackColor;
			this.textBox1.ForeColor = Form1.theme.TxtForeColor;
			this.textBox1.Text = ucMessShow.GetText();
			this.Visible = true;
		}

		private void lbCancel_Click(object sender, EventArgs e)
		{
			ucmessshow.Visible = true;
			pnparent._RemoveEditControls(this);
			pnparent.isTurnOnEdit = false;
		}

		private void lbSave_Click(object sender, EventArgs e)
		{
			byte[] tempbuff = Encoding.UTF8.GetBytes("EDITMESSAGE%"+ Form1.me.Id+"%"+pnparent.parent.user.Id+ "%" + ucmessshow.GetText() + "%" + textBox1.Text);
			byte[] buff = new byte[1024];
			tempbuff.CopyTo(buff, 0);
			Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
			ucmessshow.Visible = true;
			ucmessshow.SetText(textBox1.Text);
			pnparent._RemoveEditControls(this);
			pnparent.isTurnOnEdit = false;

			
		}
	}
}
