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
	public partial class FrmContactBook : Form
	{
		public FrmMain mainForm;
		public List<ucContact> listContact;
		public FrmContactBook()
		{
			InitializeComponent();
		}
		public FrmContactBook(FrmMain mainForm)
		{
			this.mainForm = mainForm;
			this.listContact = new List<ucContact>();
			InitializeComponent();
			_InitControls();

			this.Dock = DockStyle.Fill;
			this.TopLevel = false;
			this.mainForm.PnRight.Controls.Add(this);
		}
		public void _RemoveUser(string id)
        {
			foreach (var item in listContact)
			{
                foreach (var item2 in item.listContact__User)
                {
					if (item2.user.Id == id)
                    {
						item._RemoveContact__User(item2);
						break;
                    }
                }

			}
		}
		public void _InitControls()
		{
			this.BackColor = FrmMain.theme.BackColor;
			this.pnLine.BackColor = FrmMain.theme.LineColor;
			this.textBox1.BackColor = FrmMain.theme.FocusColor;
			this.textBox1.ForeColor = FrmMain.theme.TextColor;
			this.btnCreate.ForeColor = FrmMain.theme.TextColor;
			this.lbContactBook.ForeColor = FrmMain.theme.TextColor;
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
			ucContact newUcContact = new ucContact(newContactBook, this , mainForm);
			listContact.Add(newUcContact);
			this.pnListContact.Controls.Add(newUcContact);
		}
		public void _RemoveContact(ucContact ucContact) 
		{
			this.pnListContact.Controls.Remove(ucContact);
			this.listContact.Remove(ucContact);
		}

		private async void btnCreate_Click(object sender, EventArgs e)
		{
			try
            {
				byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("CREATECB%{0}", this.textBox1.Text));
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", tempBuff, "Server");
				FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
				textBox1.Clear();
			}
			catch
            {
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
	}
}
