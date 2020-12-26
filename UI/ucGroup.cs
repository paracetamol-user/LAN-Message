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
		FrmMain frmMain;
		List<GroupUI> GroupUIs;
		public ucGroup()
		{
			InitializeComponent();
		}
		public ucGroup(FrmMain frmMain, List<GroupUI> GroupUIs)
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
			this.txtCreate.BackColor = FrmMain.theme.FocusColor;
			this.txtCreate.ForeColor = FrmMain.theme.TextColor;
			this.btnCreate.ForeColor = FrmMain.theme.TextColor;
			this.btnCreate.FlatAppearance.BorderColor = FrmMain.theme.TextColor;
			this.btnCreate.BackColor = FrmMain.theme.Menu;
			this.lbHeaderName.ForeColor = FrmMain.theme.TxtForeColor;
			this.pnLine.BackColor = FrmMain.theme.LineColor;
		}
		public void InitColor()
		{
			this.txtCreate.BackColor = FrmMain.theme.FocusColor;
			this.txtCreate.ForeColor = FrmMain.theme.TextColor;
			this.btnCreate.ForeColor = FrmMain.theme.TextColor;
			this.btnCreate.FlatAppearance.BorderColor = FrmMain.theme.TextColor;
			this.btnCreate.BackColor = FrmMain.theme.Menu;
			this.lbHeaderName.ForeColor = FrmMain.theme.TxtForeColor;
			this.pnLine.BackColor = FrmMain.theme.LineColor;
		}
		public void _LoadGroup()
		{
			this.pnListGr.Controls.Clear();
			foreach (var item in GroupUIs)
			{
				this.pnListGr.Controls.Add(item.ucGroupAll);
			}
		}
		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtCreate.Text))
                {
					MessageBox.Show("Please enter group name!", "Error create group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					if (txtCreate.Text.Length > 32)
					{
						MessageBox.Show("Name is shorter than 32", "Name is not invalid", MessageBoxButtons.OK);
						return;
					}
					else
                    {
						byte[] buff = Encoding.UTF8.GetBytes(string.Format("CREATEGR%{0}%{1}", txtCreate.Text, FrmMain.me.Id));
						SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "0");
						FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
						this.txtCreate.Text = "";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

        private void txtCreate_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
            {
				try
				{
					if (string.IsNullOrEmpty(txtCreate.Text))
					{
						MessageBox.Show("Please enter group name!", "Error create group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						if (txtCreate.Text.Length > 32)
						{
							MessageBox.Show("Name is shorter than 32", "Name is not invalid", MessageBoxButtons.OK);
							return;
						}
						else
						{
							byte[] buff = Encoding.UTF8.GetBytes(string.Format("CREATEGR%{0}%{1}", txtCreate.Text, FrmMain.me.Id));
							SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "0");
							FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
							this.txtCreate.Text = "";
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

		}
    }
}
