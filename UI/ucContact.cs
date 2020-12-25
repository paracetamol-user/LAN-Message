using Network;
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
		public FrmMain mainForm;
		public ucContact()
		{
			InitializeComponent();
		}
		public ucContact(ContactBook contactBook ,FrmContactBook frmContactBook , FrmMain mainForm)
		{
			this.contactBook = contactBook;
			this.mainForm = mainForm;
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
				listContact__User.Add(newContact__User);
				this.pnList.Controls.Add(newContact__User);
			}
		}
		public void _InitControls()
		{
			this.pnHeader.BackColor = FrmMain.theme.Menu;
			this.lbNameContact.ForeColor = FrmMain.theme.TextColor;
			this.pictureAdd.Image = Image.FromFile(FrmMain.theme.pictureAdd);
			this.pictureDelete.Image = Image.FromFile(FrmMain.theme.PictureMinus);
			this.pnLine.BackColor = FrmMain.theme.LineColor;
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
			this.contactBook._RemoveMember(ucContact__User.user);
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

		private void pictureDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =  MessageBox.Show("Are you sure remove this contact!", "Remove Contact", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				byte[] buff = Encoding.UTF8.GetBytes("DELETECONTACT%" + this._ID);
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "Server");
				FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);

				_RemoveThis();
			}
		}

		private void pictureAdd_Click(object sender, EventArgs e)
		{
			mainForm.frmADDMemberToContact.OpenAdd(this);
		}
	}
}
