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
	public partial class ucUserINChatBox : UserControl
	{
		public User user;
		public UserForm parent;
		public ucMessShow ucmessshow;
		public bool isTurnOnEdit;
		public ucUserINChatBox()
		{
			InitializeComponent();
		}
		public ucUserINChatBox(User _user , UserForm parent)
		{
			InitializeComponent();
			isTurnOnEdit = false;
			this.user = _user;
			this.parent = parent;
			this.labelName.Text = user.Name;
			if (this.user == Form1.me)
			{
				pictureBox1.Image = Image.FromFile(Form1.me.AvatarPath);
			}
			else pictureBox1.Image = Image.FromFile(user.AvatarPath);
		}
		public void InitColor()
		{
			this.labelName.ForeColor = Form1.theme.TextColor;
			this.BackColor = Color.Transparent;
		}
		public User _User
		{
			set
			{
				this.user = value;
			}
		}
		public void _AddFileControl(ucFileShow filecontrol)
		{
			this.panelAddMessage.Controls.Add(filecontrol);
		}
		public void _AddMessControl(ucMessShow messcontrol)
		{
			this.panelAddMessage.Controls.Add(messcontrol);
			this.ucmessshow = messcontrol;
		}
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (parent.messageFocus != this)
			{
				
				if (parent.messageFocus != null)
				{
					parent.messageFocus.BackColor = Color.Transparent;
					parent.messageFocus.pnMenu.Visible = false;
				}
				this.BackColor = Form1.theme.Menu;
				if (user == Form1.me)
				{
					this.pnMenu.Visible = true;
				}
				parent.messageFocus = this;
			}
		}
		private void picEdit_Click(object sender, EventArgs e)
		{
			if (!isTurnOnEdit)
			{
				ucEditMessage ucEdit = new ucEditMessage(this, ucmessshow);
				this._AddEditControls(ucEdit);
				ucEdit.Dock = DockStyle.Top;
				ucmessshow.Visible = false;
				isTurnOnEdit = true;
			}	
		}

		public void _AddEditControls(ucEditMessage ucEdit)
		{
			this.panelAddMessage.Controls.Add(ucEdit);
		}
		public void _RemoveEditControls(ucEditMessage ucEdit)
		{
			this.panelAddMessage.Controls.Remove(ucEdit);
		}
		public void EnablePnMenu()
        {
			this.pnMenu.Visible = true;
		}
		public void DisablePnMenu()
		{
			this.pnMenu.Visible = false;
		}
		public bool EditMess(string oldMess ,string newMess)
        {
			if (oldMess == ucmessshow.GetText())
            {
				ucmessshow.SetText(newMess);
				return true;
            }
			return false;
        }
	}
}
