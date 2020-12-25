using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network;

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
			_InitControls();
		}

		private void _InitControls()
		{
			this.frmMain.PnRight.Controls.Add(this);
			this.Dock = DockStyle.Fill;
			this.BackColor = Color.Transparent;
			this.txtCreate.BackColor = Form1.theme.FocusColor;
			this.txtCreate.ForeColor = Form1.theme.TextColor;
			this.btnCreate.ForeColor = Form1.theme.TextColor;
			this.btnCreate.FlatAppearance.BorderColor = Form1.theme.TextColor;
			this.btnCreate.BackColor = Form1.theme.Menu;
			this.lbHeaderName.ForeColor = Form1.theme.TxtForeColor;
			this.pnLine.BackColor = Form1.theme.LineColor;
		}
		public void InitColor()
		{
			this.txtCreate.BackColor = Form1.theme.FocusColor;
			this.txtCreate.ForeColor = Form1.theme.TextColor;
			this.btnCreate.ForeColor = Form1.theme.TextColor;
			this.btnCreate.FlatAppearance.BorderColor = Form1.theme.TextColor;
			this.btnCreate.BackColor = Form1.theme.Menu;
			this.lbHeaderName.ForeColor = Form1.theme.TxtForeColor;
			this.pnLine.BackColor = Form1.theme.LineColor;
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

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (txtCreate.Text != "" && txtCreate.Text != null)
			{
				if (txtCreate.Text.Length > 32)
				{
					MessageBox.Show("Name is shorter than 32", "Name is not invalid", MessageBoxButtons.OK);
					return;
				}
				byte[] buff = Encoding.UTF8.GetBytes(string.Format("CREATEGR%{0}%{1}", txtCreate.Text, Form1.me.Id));
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "0");
				Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);

				this.txtCreate.Text = "";
				//btnCreate.Enabled = false;
			}
		}
	}
}
