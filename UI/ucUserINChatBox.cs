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
		public string ID;
		public User user;
		public UserForm parent;
		public ucMessShow ucmessshow;
		public ucFileShow ucfileshow;
		public bool isTurnOnEdit;
		public bool acceptFocus;
		public bool isFile;
		public ucUserINChatBox()
		{
			InitializeComponent();
		}
		public ucUserINChatBox(User _user , UserForm parent)
		{
			InitializeComponent();
			acceptFocus = true;
			isTurnOnEdit = false;
			isFile = false;
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
			isFile = true;
			this.panelAddMessage.Controls.Add(filecontrol);
			this.ucfileshow = filecontrol;
		}
		public void _AddMessControl(ucMessShow messcontrol)
		{
			isFile = false;
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
				if (user == Form1.me && acceptFocus == true)
				{
					this.pnMenu.Visible = true;
					if (isFile)
					{
						this.pnEdit.Visible = false;
					}
				}
				parent.messageFocus = this;
			}
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
		public void EditMessage(string newMess)
		{
				ucmessshow.SetText(newMess);
		}
		public void DeleteMessage(string IDMess)
		{
			if (ucmessshow!=null)
			{
					ucmessshow.DeleteMessage();
			}
			else 
				ucfileshow.DeleteMessage();
		}
		private void picDelete_Click(object sender, EventArgs e)
		{
			DialogResult temp = MessageBox.Show("Are you sure delete this message", "Delete Message", MessageBoxButtons.OKCancel);
			if (temp == DialogResult.OK)
			{
				if (isFile)
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("DELETEMESSAGE%" + this.ID + "%" + parent.user.Id);
					byte[] buff = new byte[1024];
					tempbuff.CopyTo(buff, 0);
					Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
					this.ucfileshow.DeleteMessage();
				}
				else
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("DELETEMESSAGE%" + this.ID + "%" + parent.user.Id);
					byte[] buff = new byte[1024];
					tempbuff.CopyTo(buff, 0);
					Form1.server.GetStream().WriteAsync(buff, 0, buff.Length);
					this.ucmessshow.DeleteMessage();
				}
					
				acceptFocus = false;
			}	
		}
		private void picEdit_Click(object sender, EventArgs e)
		{
			if (!isTurnOnEdit)
			{
				ucEditMessage ucEdit = new ucEditMessage(this, ucmessshow);
				this.panelAddMessage.Controls.Add(ucEdit);
				ucEdit.Dock = DockStyle.Top;
				ucmessshow.Visible = false;
				isTurnOnEdit = true;
			}
		}
	}
}
