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
using System.Drawing.Drawing2D;
using Network;
using System.IO;

namespace UI
{
	public partial class ucInfoGroup : UserControl
	{
		
		FrmGroup frmMain;
		private Group group;
		List<User> listmember;
		public FrmADD frmADD;
		FrmMain mainForm;
		public ucInfoGroup()
		{
			InitializeComponent();
			pnaddfile.Visible = false;
			pnaddmember.Visible = false;
			
			pnfile.AutoSize = true;
			pnmember.AutoSize = true;
			this.mainForm = this.frmMain.GroupUI.MAINFORM;
			this.frmADD = new FrmADD(mainForm);
		}
		public ucInfoGroup(FrmGroup frmMain)
		{
			this.frmMain = frmMain;
			InitializeComponent();
			InitControls();
			locationlabel(ref lbName, pnavata_name);
			locationlabel(ref lbID, pnavata_name);
			locationpanel(ref panel1, pnavata_name);
			pnaddfile.Visible = false;
			pnaddmember.Visible = false;
			
			pnfile.AutoSize = true;
			pnmember.AutoSize = true;
			
			this.mainForm = this.frmMain.GroupUI.MAINFORM;
			this.frmADD = new FrmADD(mainForm);
			this.frmMain.Pncontaininfor.Controls.Add(this);
			this.Dock = DockStyle.Top;
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
		public void InitControls()
		{
			this.lbclearhistory.ForeColor = FrmMain.theme.TextColor;
			this.lbmember.ForeColor = FrmMain.theme.TextColor;
			this.lbName.ForeColor = FrmMain.theme.TextColor;
			this.lbID.ForeColor = FrmMain.theme.TextColor;
			this.label1.ForeColor = FrmMain.theme.TextColor;
			this.label2.ForeColor = FrmMain.theme.TextColor;
			this.label3.ForeColor = FrmMain.theme.TextColor;
			
			pictureBoxMenufile.Image = Image.FromFile(FrmMain.theme.pictureArrow);
			pictureBoxMenumember.Image = Image.FromFile(FrmMain.theme.pictureArrow);
			//mau line
			this.ChangeColorLine();
		}
		public void ChangeColorLine()
		{
			this.pnLine1.BackColor = FrmMain.theme.LineColor;
			this.pnLine2.BackColor = FrmMain.theme.LineColor;
			this.pnLine6.BackColor = FrmMain.theme.LineColor;
			this.pnLine8.BackColor = FrmMain.theme.LineColor;
			this.pnLine11.BackColor = FrmMain.theme.LineColor;
			this.pnLine12.BackColor = FrmMain.theme.LineColor;
			this.frmMain.PnLine1.BackColor = FrmMain.theme.LineColor ;
			this.pnLine3.BackColor = FrmMain.theme.LineColor;
		}
		public void _LoadInfoGroup(Group group, List<ucFileShow> listfileShows)
		{
			this.group = group;
			lbName.Text = "Name: " + group.Name;
			lbID.Text = "#" + group.ID;
			using (FileStream fs = new FileStream(group.AvatarPath, FileMode.Open, FileAccess.Read))
			{
				ptbavata.Image = Image.FromStream(fs);
				fs.Dispose();
			}
			locationlabel(ref lbName, pnavata_name);
			locationlabel(ref lbID, pnavata_name);
			locationpanel(ref panel1, pnavata_name);

			_addfileinfilesent(listfileShows);

			listmember = new List<User>(group.GetMembers());
			_addmember(listmember);
			
		}
		public void _addfileinfilesent(List<ucFileShow> listfileShows)
		{
			pnaddfile.Controls.Clear();
			if (listfileShows.Count > 0)
			{
				for (int i = 0; i < listfileShows.Count; i++)
				{
					ucFileShow tam = new ucFileShow(listfileShows[i].user,listfileShows[i]._FileId, listfileShows[i]._FileName, listfileShows[i].ucParent);
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
		public void _addmember(List<User> listmember)
		{
			List<ucMember> listuser = new List<ucMember>();
			
			
			if (listmember != null)
			{
			  
				for (int i = 0; i < listmember.Count; i++)
				{

					if(listmember[i] != group.admin)
					{
						ucMember tam = new ucMember(group, listmember[i]);
						
						listuser.Add(tam);
					}
				}
				for (int i = 0; i < listmember.Count; i++)
				{

					if (listmember[i] == group.admin)
					{
						ucMember tam = new ucMember(group, listmember[i]);
						listuser.Add(tam);
					}

				}
			}
			pnaddmember.Controls.Clear();

			if (listuser != null)
			{
				for (int i = 0; i < listuser.Count; i++)
				{
					pnaddmember.Controls.Add(listuser[i]);
					
					listuser[i].Dock = DockStyle.Top;
				}
			}
			
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


		bool isclickmenumember = false;
		bool isclickmenufile = false;
	   

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

		private void pictureBoxMenumember_Click(object sender, EventArgs e)
		{
			isclickmenumember = !isclickmenumember;
			Graphics g = panelMenumember.CreateGraphics();
			if (isclickmenumember)
			{
				pictureBoxMenumember.Image = _xoayanh(pictureBoxMenumember.Image, 90);
				pnaddmember.Visible = true;
				pnaddmember.AutoSize = true;
				
				
				Pen pen = new Pen(FrmMain.theme.TextColor);
				g.DrawRectangle(pen, new Rectangle(pictureBoxMenumember.Location.X - 1, pictureBoxMenumember.Location.Y - 1, pictureBoxMenumember.Width + 1, pictureBoxMenumember.Height + 1));
			}
			else
			{
				pictureBoxMenumember.Image = _xoayanh(pictureBoxMenumember.Image, -90);
				pnaddmember.Visible = false;
				pnaddmember.AutoSize = false;
			   
				g.Clear(this.frmMain.BackColor);
			}
		}

		private void pictureBoxMenufile_Click(object sender, EventArgs e)
		{
			isclickmenufile = !isclickmenufile;
			Graphics g = panelMenufile.CreateGraphics();
			if (isclickmenufile)
			{
				pictureBoxMenufile.Image = _xoayanh(pictureBoxMenufile.Image, 90);
				pnaddfile.Visible = true;
				pnaddfile.AutoSize = true;
				Pen pen = new Pen(FrmMain.theme.TextColor);
				g.DrawRectangle(pen, new Rectangle(pictureBoxMenufile.Location.X - 1, pictureBoxMenufile.Location.Y - 1, pictureBoxMenufile.Width + 1, pictureBoxMenufile.Height + 1));
			}
			else
			{
				pictureBoxMenufile.Image = _xoayanh(pictureBoxMenufile.Image, -90);
				pnaddfile.Visible = false;
				pnaddfile.AutoSize = false;
				g.Clear(this.frmMain.BackColor);
			}
		}

		private void pnthemthanhvien_Click(object sender, EventArgs e)
		{
			mainForm.frmADD.InitControls();
			mainForm.frmADD.InitAddGroupForm(group);
			mainForm.frmADD.Show();
			mainForm.frmADD.BringToFront();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			mainForm.frmADD.InitControls();
			mainForm.frmADD.InitAddGroupForm(group);
			mainForm.frmADD.Show();
			mainForm.frmADD.BringToFront();
		}

        private void label3_Click(object sender, EventArgs e)
        {
			try
			{
				DialogResult rs = MessageBox.Show("Are you sure Out this Group", "Remove Group", MessageBoxButtons.YesNo);
				if (rs == DialogResult.Yes)
				{
					byte[] buff = Encoding.UTF8.GetBytes("OUTGR%" + group.ID + "%" + (group.admin == FrmMain.me ? "true" : "false") + "%" + FrmMain.me.Id);
					SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "0");
					FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);

					frmMain.GroupUI.Dispose();
					mainForm.GroupUIs.Remove(frmMain.GroupUI);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
			
		}

    }
}
