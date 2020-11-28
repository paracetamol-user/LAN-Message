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
	public partial class ucInterac : UserControl
	{
		public UserUI parent;
		public ucInterac()
		{
			InitializeComponent();
		}
		public ucInterac(UserUI Parent)
		{
			InitializeComponent();
			this.parent = Parent;
			this.lbName.Text = parent.user.Name;
			this.lbStatus.Text = parent.user.Status == false ? "Offline" : "Online";
		}
		public void Online()
		{
			this.lbStatus.Text = "Online";
		}
		public void Offline()
		{
			this.lbStatus.Text = "Offline";
		}
		public void ChangeColorWhenClick()
		{
			
			this.BackColor = Color.FromArgb(242, 243, 245);
		}
		public void ChangeColorWhenNonClick()
		{
			this.BackColor = Color.White;
		}
		private void ucInterac_Click(object sender, EventArgs e)
		{
			this.parent.ShowChatForm();
			if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
			else if (Form1.userUIForcus == null)
			{
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
		}
		private void ucInterac_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
			
		}
		private void ucInterac_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
		
		}
		private void gunaPic_Click(object sender, EventArgs e)
		{
			this.parent.ShowChatForm();
			if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
			else if (Form1.userUIForcus == null)
			{
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
		}
		private void pnContainStatus_Click(object sender, EventArgs e)
		{
			this.parent.ShowChatForm();
			if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
			else if (Form1.userUIForcus == null)
			{
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
		}
		private void pnContrainName_Click(object sender, EventArgs e)
		{
			this.parent.ShowChatForm();
			if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
			else if (Form1.userUIForcus == null)
			{
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
		}
		private void lbName_Click(object sender, EventArgs e)
		{
			this.parent.ShowChatForm();
			if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
			else if (Form1.userUIForcus == null)
			{
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
		}
		private void lbStatus_Click(object sender, EventArgs e)
		{
			this.parent.ShowChatForm();
			if (Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id)
			{
				Form1.userUIForcus.ucInterac.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
			else if (Form1.userUIForcus == null)
			{
				this.ChangeColorWhenClick();
				Form1.userUIForcus = parent;
			}
		}
		private void picClose_Click(object sender, EventArgs e)
		{
			this.parent.panelINTERACTED.Controls.Remove(this);
		}
		private void gunaPic_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
			
		}
		private void pnContainStatus_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
			
		}
		private void pnContrainName_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
			
		}
		private void lbStatus_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
		  
		}
		private void lbName_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
		   
		}
		private void picClose_MouseMove(object sender, MouseEventArgs e)
		{
			ChangeColorWhenClick();
			
		}
		private void gunaPic_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
		   
		}
		private void lbStatus_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
  
		}
		private void lbName_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
		   
		}
		private void pnContrainName_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
			
		}
		private void pnContainStatus_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
			
		}
		private void picClose_MouseLeave(object sender, EventArgs e)
		{
			if ((Form1.userUIForcus != null && Form1.userUIForcus.GetId() != this.parent.user.Id) || Form1.userUIForcus == null)
				ChangeColorWhenNonClick();
		  
		}
	}
}
