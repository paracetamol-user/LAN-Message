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
using Network;

namespace UI
{
	public partial class ucUserINChatBox : UserControl
	{
		public string ID { get; set; }
		public string IDParent { get; set; }
		public User User {get;set;}
		public ucMessShow ucmessshow;
		public ucFileShow ucfileshow;
		public ucVoiceMessage ucVoiceMessage;
		public bool isTurnOnEdit;
		public bool acceptFocus;
		public bool isFile;
		public ucUserINChatBox()
		{
			InitializeComponent();
		}
		public ucUserINChatBox(User _User , string idParent)
		{
			InitializeComponent();
			acceptFocus = true;
			isTurnOnEdit = false;
			isFile = false;
			this.User = _User;
			this.IDParent = idParent;
			this.labelName.Text = User.Name;
			if (this.User == Form1.me)
			{
				roundPicAvatar.Image = Image.FromFile(Form1.me.AvatarPath);
			}
			else roundPicAvatar.Image = Image.FromFile(User.AvatarPath);
			this.labelName.ForeColor = Form1.theme.TextColor;
			this.BackColor = Color.Transparent;
		}
		public void InitColor()
		{
			this.labelName.ForeColor = Form1.theme.TextColor;
			this.BackColor = Color.Transparent;
		}
		public void EnableMenu()
        {
			this.pnMenu.Visible = true;
        }
		public void DisableMenu()
        {
			this.pnMenu.Visible = false;
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
		public void _AddVoiceMessage(ucVoiceMessage voiceMessage)
        {
			isFile = false;
			this.panelAddMessage.Controls.Add(voiceMessage);
			this.ucVoiceMessage = voiceMessage;
        }
		public void _RemoveEditControls(ucEditMessage ucEdit)
		{
			this.panelAddMessage.Controls.Remove(ucEdit);
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
				if (this.User.Id != Form1.me.Id)
                {
					this.Visible = false;
                } 
				else if (isFile)
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("DELETEMESSAGE%" + this.ID + "%" + IDParent);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
					this.ucfileshow.DeleteMessage();
					this.DisableEdit();
					this.DisableDelete();
				}
				else
				{

					byte[] tempbuff = Encoding.UTF8.GetBytes("DELETEMESSAGE%" + this.ID + "%" + IDParent);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
					this.ucmessshow.DeleteMessage();
					this.DisableEdit();
					this.DisableDelete();
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
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (Form1.chatBoxFocus != this)
			{
				if (Form1.chatBoxFocus != null)
				{
					Form1.chatBoxFocus.DisableMenu();
				}
				Form1.chatBoxFocus = this;
				this.EnableMenu();
				this.pnMenu.Visible = true;
			}
			else return;
		}
		public void DisableEdit()
        {
			this.picEdit.Visible = false;
        }
		public void DisableDelete()
        {
			this.picDelete.Visible = false;
        }
	}
}
