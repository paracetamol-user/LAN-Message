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
        FrmUser frmMain;
        User user;
        public ucInfoUser()
        {
            InitializeComponent();
			InitControls();
		}
		public ucInfoUser(FrmUser frmMain)
		{
			this.frmMain = frmMain;
			InitializeComponent();
			InitControls();
			locationlabel(ref lbName, pnavata_name);
			locationlabel(ref lbID, pnavata_name);
			locationpanel(ref panel1, pnavata_name);
			this.frmMain.Pncontaininfo.Controls.Add(this);
			this.Dock = DockStyle.Top;
			pnaddfile.Visible = false;
		}


		public void InitControls()
		{
			
			this.lbaddfriend.ForeColor = FrmMain.theme.TextColor;
			this.lbclearhistory.ForeColor = FrmMain.theme.TextColor;
			this.lbfilesent.ForeColor = FrmMain.theme.TextColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbID.ForeColor = FrmMain.theme.TextColor;
			this.lbRemove.ForeColor = FrmMain.theme.TextColor;
			this.pictureBoxMenu.Image = Image.FromFile(FrmMain.theme.pictureArrow);
			this.ChangeColorLine();
		}
		public void ChangeColorLine()
		{
			this.pnLine1.BackColor = FrmMain.theme.LineColor;
			this.pnLine2.BackColor = FrmMain.theme.LineColor;
			this.pnLine3.BackColor = FrmMain.theme.LineColor;
			this.pnLine6.BackColor = FrmMain.theme.LineColor;
			this.pnLine9.BackColor = FrmMain.theme.LineColor;
			this.pnLine11.BackColor = FrmMain.theme.LineColor;
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
				pnRemoveFriend.Visible = true;
			}
			else
			{
				pnRemoveFriend.Visible = false;
				pnaddfriend.Visible = true;
			}

		}
		public void _addfileinfilesent(List<ucFileShow> listfileShows)
		{
			pnaddfile.Controls.Clear();
			if (listfileShows.Count > 0)
			{
				for (int i = 0; i < listfileShows.Count; i++)
				{
					ucFileShow tam = new ucFileShow(listfileShows[i].user, listfileShows[i]._FileId, listfileShows[i]._FileName, listfileShows[i].ucParent);
					tam.Dock = DockStyle.Top;
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
			try
			{
				byte[] tempbuff = Encoding.UTF8.GetBytes("PENDING%" + FrmMain.me.Id + "%" + user.Id);
				SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
				FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		
        private void lbaddfriend_Click(object sender, EventArgs e)
        {
			this.SendAddFriendToServer();
			MessageBox.Show("Has sent friend request");
		}

        private void pnaddfriend_Click(object sender, EventArgs e)
        {
			this.SendAddFriendToServer();
			MessageBox.Show("Has sent friend request");
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
			Graphics g = panelMenu.CreateGraphics();
			if (pnaddfile.Visible == false)
			{
				pictureBoxMenu.Image = _xoayanh(pictureBoxMenu.Image, 90);
				pnaddfile.Visible = true;
				pnaddfile.AutoSize = true;
				pnfilesent.AutoSize = true;
				Pen pen = new Pen(FrmMain.theme.TextColor);
				g.DrawRectangle(pen, new Rectangle(pictureBoxMenu.Location.X - 1, pictureBoxMenu.Location.Y - 1, pictureBoxMenu.Width + 1, pictureBoxMenu.Height + 1));
			}
			else
			{
				pictureBoxMenu.Image = _xoayanh(pictureBoxMenu.Image, -90);
				pnaddfile.Visible = false;
				g.Clear(this.frmMain.BackColor);
			}
		}

        private void label3_Click(object sender, EventArgs e)
        {
			try
			{
				var temp = MessageBox.Show("Remove Friend", "Remove Friend", MessageBoxButtons.YesNo);
				if (temp == DialogResult.Yes)
				{
					byte[] tempbuff = Encoding.UTF8.GetBytes("REMOVEFRIEND%" + FrmMain.me.Id + "%" + user.Id);
					SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
					FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
				}
				FrmMain.frmFriend.RemoveFriend(frmMain.userUI);
				frmMain.userUI.DisableRemove();
				frmMain.userUI.EnableADD();
				this.user.IsFriend = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
    }
}
