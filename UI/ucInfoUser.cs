using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using User = UserManager.User;
using UserManager;
using Network;
namespace UI
{
    public partial class ucInfoUser : UserControl
    {
        UserForm frmMain;
        User user;
        public ucInfoUser()
        {
            InitializeComponent();
			InitControls();
		}
		public ucInfoUser(UserForm frmMain)
		{
			this.frmMain = frmMain;
			InitializeComponent();
			InitControls();

			locationlabel(ref lbName, pnavata_name);
			locationlabel(ref lbID, pnavata_name);
			locationpanel(ref panel1, pnavata_name);
			pnaddfile.Visible = false;
			
		}


		public void InitControls()
		{

			this.frmMain.Pncontaininfo.Controls.Add(this);
			this.Dock = DockStyle.Top;
			this.BackColor = Color.Transparent;
			//mau chu
			this.lbaddfriend.ForeColor = Form1.theme.TextColor;
			//this.lbaddgroup.ForeColor = Form1.theme.TextColor;
			this.lbclearhistory.ForeColor = Form1.theme.TextColor;
			//this.lbcreategroup.ForeColor = Form1.theme.TextColor;
			this.lbfilesent.ForeColor = Form1.theme.TextColor;
			this.lbName.ForeColor = Form1.theme.TextColor;
			this.lbID.ForeColor = Form1.theme.TextColor;
			//mau line
			this.ChangeColorLine();
		}
		public void ChangeColorLine()
		{
			this.pnLine1.BackColor = Form1.theme.LineColor;
			this.pnLine2.BackColor = Form1.theme.LineColor;
			this.pnLine3.BackColor = Form1.theme.LineColor;
			this.pnLine4.BackColor = Form1.theme.LineColor;
			this.pnLine5.BackColor = Form1.theme.LineColor;
			this.pnLine6.BackColor = Form1.theme.LineColor;
			//this.pnLine7.BackColor = Form1.theme.LineColor;
			//this.pnLine8.BackColor = Form1.theme.LineColor;
			this.pnLine9.BackColor = Form1.theme.LineColor;
			this.pnLine10.BackColor = Form1.theme.LineColor;
			this.pnLine11.BackColor = Form1.theme.LineColor;
			this.frmMain.PnLine1.BackColor = this.pnLine1.BackColor;
		}
		public void locationlabel(ref Label a, Panel b)
		{
			int x = b.Width / 2 - a.Width / 2;

			a.Location = new System.Drawing.Point(x, a.Location.Y);
		}
		public void locationpanel(ref Panel a, Panel b)
		{
			int x = b.Width / 2 - a.Width / 2;

			a.Location = new System.Drawing.Point(x, a.Location.Y);
		}
		public void _LoadInfoUser(User user, List<ucFileShow> listfileShows)
		{
			this.user = user;
			lbName.Text = "Name: " + user.Name;
			lbID.Text = "#" + user.Id;
			Image image = Image.FromFile(user.AvatarPath);
			ptbavata.Image = image;
			ptbavata.SizeMode = PictureBoxSizeMode.StretchImage;
			locationlabel(ref lbName, pnavata_name);
			locationlabel(ref lbID, pnavata_name);
			locationpanel(ref panel1, pnavata_name);

			_addfileinfilesent(listfileShows);
			if (user.IsFriend)
			{
				pnaddfriend.Visible = false;
			}
		}
		public void _addfileinfilesent(List<ucFileShow> listfileShows)
		{
			pnaddfile.Controls.Clear();
			if (listfileShows != null)
			{
				for (int i = 0; i < listfileShows.Count; i++)
				{


					ucFileShow tam = new ucFileShow(listfileShows[i]._FileId, listfileShows[i]._FileName);

					tam.Dock = DockStyle.Top;
					if (listfileShows[i]._User == Form1.me)
					{
						tam._DisableButDownLoad();
					}
					if (tam._FileName != "Deleted file")
					{
						pnaddfile.Controls.Add(tam);
					}
				}
			}
		}
		public void _clearfile()
		{
			pnaddfile.Controls.Clear();
		}
		public Image _xoayanh(Image image, float rotationAngle)
		{
			Bitmap bmp = new Bitmap(image.Width, image.Height);
			Graphics g = Graphics.FromImage(bmp);
			g.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
			g.RotateTransform(rotationAngle);
			g.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			g.DrawImage(image, new Point(0, 0));
			g.Dispose();
			return bmp;
		}

		public async void SendAddFriendToServer()
		{
			byte[] tempbuff = Encoding.UTF8.GetBytes("PENDING%" + Form1.me.Id + "%" + user.Id);
			SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
			Form1.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
		}
		bool isclickmenu = false;
		
        private void lbaddfriend_Click(object sender, EventArgs e)
        {
			this.SendAddFriendToServer();
			MessageBox.Show("Đã gửi lời mời kết bạn");
		}

        private void pnaddfriend_Click(object sender, EventArgs e)
        {
			this.SendAddFriendToServer();
			MessageBox.Show("Đã gửi lời mời kết bạn");
		}

        private void lbclearhistory_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Are you sure delete all message!", "Delete message", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
				this.frmMain._clearlistchat();
		}

        private void pnclearhistory_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Are you sure delete all message!", "Delete message", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
				this.frmMain._clearlistchat();
		}

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
			isclickmenu = !isclickmenu;
			Graphics g = panelMenu.CreateGraphics();
			if (isclickmenu)
			{

				pictureBoxMenu.Image = _xoayanh(pictureBoxMenu.Image, 90);
				pnaddfile.Visible = true;
				pnaddfile.AutoSize = true;
				pnfilesent.AutoSize = true;
				Pen pen = new Pen(Form1.theme.TextColor);
				g.DrawRectangle(pen, new Rectangle(pictureBoxMenu.Location.X - 1, pictureBoxMenu.Location.Y - 1, pictureBoxMenu.Width + 1, pictureBoxMenu.Height + 1));
			}
			else
			{

				pictureBoxMenu.Image = _xoayanh(pictureBoxMenu.Image, -90);
				pnaddfile.Visible = false;
				pnaddfile.AutoSize = false;
				pnfilesent.AutoSize = false;
				g.Clear(this.frmMain.BackColor);
			}
		}
    }
}
