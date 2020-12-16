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
	public partial class FrmContactBook : Form
	{
		public Form1 mainForm;
		public List<ucContact> listContact;
		public FrmContactBook()
		{
			InitializeComponent();
		}
		public FrmContactBook(Form1 mainForm)
		{
			this.mainForm = mainForm;
			this.listContact = new List<ucContact>();
			InitializeComponent();
			_InitControls();

			this.Dock = DockStyle.Fill;
			this.TopLevel = false;
			this.mainForm.PnRight.Controls.Add(this);
		}
		public void _InitControls()
		{
			this.BackColor = Form1.theme.BackColor;
			this.pnLine.BackColor = Form1.theme.LineColor;
			this.textBox1.BackColor = Form1.theme.Menu;
			this.textBox1.ForeColor = Form1.theme.TextColor;
			this.btnCreate.ForeColor = Form1.theme.TextColor;
			this.lbContactBook.ForeColor = Form1.theme.TextColor;
			foreach (var item in listContact)
			{
				item._InitControls();
			}
		}
		public void _AddUser(string IDcontact , User user)
		{
			foreach (var item in listContact)
			{
				if (item._ID == IDcontact)
				{
					item._AddUser(user);
					break;
				}
			}
		}
		public void _AddContactBook(ContactBook newContactBook)
		{
			ucContact newUcContact = new ucContact(newContactBook, this);
			listContact.Add(newUcContact);
			this.pnListContact.Controls.Add(newUcContact);
		}
		public void _RemoveContact(ucContact ucContact) 
		{
			this.pnListContact.Controls.Remove(ucContact);
			this.listContact.Remove(ucContact);
		}
	}
}
