using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
	public partial class ucSearch : UserControl
	{
		private List<UserUI> UserUIs;
		//private List<GrUI> GrUis;
		private Panel pnContain;
		private bool isOnline;
		private bool isFriend;
		private bool isGr;
		public ucSearch()
		{
			InitializeComponent();
		}
		public ucSearch(List<UserUI> userUIs , Panel pnContain,bool isOnline, bool isFriend)
		{
			InitializeComponent();
			this.textBox1.BackColor = FrmMain.theme.FocusColor;
			this.textBox1.ForeColor = FrmMain.theme.TextColor;
			this.picSearch.Image = Image.FromFile(FrmMain.theme.PictureSearch);
			this.UserUIs = userUIs;
			this.pnContain = pnContain;
			this.Dock = DockStyle.Fill;
			this.isOnline = isOnline;
			this.isFriend = isFriend;
			this.isGr = false;
		}
        public void ResetTheme()
		{
			this.textBox1.BackColor = FrmMain.theme.FocusColor;
			this.textBox1.ForeColor = FrmMain.theme.TxtForeColor;
			this.picSearch.Image = Image.FromFile(FrmMain.theme.PictureSearch);
		}
		public bool IsFriend
		{
			set
			{
				this.isFriend = value;
			}
		}
		public bool IsOnline
		{
			set
			{
				this.isOnline = value;
			}
		}
		private void picSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				pnContain.Visible = false;
			}
			else
			{
				string text = RemoveUnicode(textBox1.Text);
				EnableUser(text);
				pnContain.Show();
				pnContain.BringToFront();
			}
		}
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (string.IsNullOrEmpty(textBox1.Text))
				{
					pnContain.Visible = false;
					e.SuppressKeyPress = true;
				}
				else
                {
					string text = RemoveUnicode(textBox1.Text);
					EnableUser(text);
					pnContain.Show();
					pnContain.BringToFront();
					e.SuppressKeyPress = true;
				}
			}
			
		}
		public void EnableUser(string text)
		{
			foreach (var item in UserUIs)
			{
				if (!pnContain.Contains(item.ucSearch))
				{
					item.AddUserIntoPanelListSearch(pnContain);
				}
				if (item.user.Name.Contains(text))
				{
					if (isOnline && item.user.Status)
					{
						item.ucSearch.Visible = true;
					}
					else if (!isOnline)
					{
						item.ucSearch.Visible = true;
					}
				}
				else item.ucSearch.Visible = false;
			}
		}
		public static string RemoveUnicode(string text)
		{
			string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
			"đ",
			"é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
			"í","ì","ỉ","ĩ","ị",
			"ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
			"ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
			"ý","ỳ","ỷ","ỹ","ỵ",};
			string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
			"d",
			"e","e","e","e","e","e","e","e","e","e","e",
			"i","i","i","i","i",
			"o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
			"u","u","u","u","u","u","u","u","u","u","u",
			"y","y","y","y","y",};
			for (int i = 0; i < arr1.Length; i++)
			{
				text = text.Replace(arr1[i], arr2[i]);
				text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
			}
			return text;
		}
	}
}
