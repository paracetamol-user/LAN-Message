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
		public string Name { get; set; }
		public bool Status { get; set; }
		public string Message { get; set; }
		public UserUI UserUI { get; set; }
		public GroupUI GroupUI { get; set; }
		public bool isGroup { get; set; }
		public bool isMove { get; set; }
		public ucInterac(){}
		public ucInterac(string Name , bool Status , string Message)
		{
			InitializeComponent();
			this.Name = Name;
			this.Status = Status;
			this.Message = Message;
			this.lbName.Text = Name;
			this.lbMess.Text = Message;
			if (this.Status == true) this.Online();
			else this.Offline();
		}
		public ucInterac(string Name, bool Status)
		{
			InitializeComponent();
			this.Name = Name;
			this.Status = Status;
			this.lbName.Text = Name; 
			if (this.Status == true) this.Online();
			else this.Offline();
		}
		public ucInterac(string Name, string Message)
		{
			InitializeComponent();
			this.Name = Name;
			this.Message = Message;
			this.lbName.Text = Name;
			this.lbMess.Text = Message;
			this.lbMess.Visible = true;
			this.Offline();
		}
		public ucInterac(string Name)
		{
			InitializeComponent();
			this.lbName.Text = Name;
			this.Offline();
		}
		public void ResetPicture()
        {
			this.picClose.Image = Image.FromFile(Form1.theme.PictureClose);
        }
		public void InitColor()
		{
			this.lbName.ForeColor = Form1.theme.TextColor;
			this.lbMess.ForeColor = Form1.theme.TextMenuColor;
			this.BackColor = Color.Transparent;
			this.picClose.Image = Image.FromFile(Form1.theme.PictureClose);
		}
		public void SetAvatar(string path)
		{
			this.roundPicAvatar.Image = Image.FromFile(path);
		}
		public void Online()
		{
			this.Status = true;
			picStatus.Image = Image.FromFile(Form1.theme.pictureCircleOnline);
			picStatus.Visible = true;
		}
		public void Offline()
		{
			this.Status = false;
			picStatus.Image = Image.FromFile(Form1.theme.pictureCircleOffline);
			picStatus.Visible = true;
		}
		public void AddMessage(string mess)
        {
			if (!this.lbMess.Visible) this.lbMess.Visible = true;
			this.lbMess.Text = mess;
			this.Message = mess;
        }
		public void ChangeColorWhenClick()
		{
			this.BackColor = Form1.theme.FocusColor;
		}
		public void ChangeColorWhenNonClick()
		{
			this.BackColor = Color.Transparent;
		}
		public void SetUser(UserUI userUI)
        {
			this.isGroup = false;
			this.UserUI = userUI;
        }
		public void SetGroup(GroupUI groupUI)
        {
			this.isGroup = true;
			this.GroupUI = groupUI;
			this.picStatus.Visible = true;
			picStatus.Image = Image.FromFile(Form1.theme.pictureCircleOnline);
		}
		private void pnContain_Click(object sender, EventArgs e)
		{
			if (isGroup)
			{
				GroupUI.ShowChatForm();
			}
			else
            {
				UserUI.ShowChatForm();
			}
			if (Form1.interactFocus != null && Form1.interactFocus != this)
			{
				Form1.interactFocus.ChangeColorWhenNonClick();
				this.ChangeColorWhenClick();
				Form1.interactFocus = this;
			}
			else if (Form1.interactFocus == null)
			{
				this.ChangeColorWhenClick();
				Form1.interactFocus = this;
			}
		}
        private void picClose_Click(object sender, EventArgs e)
        {
			if (isGroup)
            {
				GroupUI.panelINTERACTED.Controls.Remove(this);
            }
			else UserUI.panelINTERACTED.Controls.Remove(this);
		}
    }
}
