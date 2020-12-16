using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucContact : UserControl
	{
		public ContactBook contactBook { get; set; }
		public FrmContactBook FrmContactBook { get; set; }
		public List<ucContact__User> listContact__User; 
		public ucContact()
		{
			InitializeComponent();
		}
		public ucContact(ContactBook contactBook ,FrmContactBook frmContactBook)
		{
			this.contactBook = contactBook;
			this.FrmContactBook = frmContactBook;
			this.Dock = DockStyle.Top;
			listContact__User = new List<ucContact__User>();
			InitializeComponent();
			_InitControls();
			_LoadContact();
		}
		public void _LoadContact()
		{
			foreach (var item in contactBook.listMember)
			{
				ucContact__User newContact__User = new ucContact__User(item, this);
				this.pnList.Controls.Add(newContact__User);
			}
		}
		public void _InitControls()
		{
			this.lbNameContact.ForeColor = Form1.theme.TextColor;
			this.pictureAdd.Image = Image.FromFile(Form1.theme.pictureAdd);
			this.pictureClose.Image = Image.FromFile(Form1.theme.PictureClose);
			this.pnLine.BackColor = Form1.theme.LineColor;
			this.lbNameContact.Text = contactBook.Name;
			foreach (var item in listContact__User)
			{
				item._InitControls();
			}
		}
		public void _AddUcUser(User user)
		{
			ucContact__User newContacUser = new ucContact__User(user,this);
			listContact__User.Add(newContacUser);
			this.pnList.Controls.Add(newContacUser);
		}
		public void _AddUser(User newuser)
		{
			this.contactBook._AddMember(newuser);
			_AddUcUser(newuser);
		}
		public void _RemoveThis()
		{
			this.FrmContactBook._RemoveContact(this);
		}
		public void _RemoveContact__User(ucContact__User ucContact__User)
		{
			this.pnList.Controls.Remove(ucContact__User);
			this.listContact__User.Remove(ucContact__User);
		}
		public string _ID
		{
			get
			{
				return this.contactBook.ID;
			}
		} 
	}
}
