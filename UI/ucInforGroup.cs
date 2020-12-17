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
namespace UI
{
    public partial class ucInforGroup : UserControl
    {
        GroupForm frmMain;
        private Group group;
        List<User> listmember;
        public ucInforGroup()
        {
            InitializeComponent();
            pnaddfile.Visible = false;
            pnaddmember.Visible = false;
            pnfile.AutoSize = true;
            pnmember.AutoSize = true;
        }
        public ucInforGroup(GroupForm frmMain)
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

            this.frmMain.Pncontaininfor.Controls.Add(this);
            this.Dock = DockStyle.Top;
            this.BackColor = Color.Transparent;
            //mau chu

            this.lbclearhistory.ForeColor = Form1.theme.TextColor;
            this.lbmember.ForeColor = Form1.theme.TextColor;
            this.lbName.ForeColor = Form1.theme.TextColor;
            this.lbID.ForeColor = Form1.theme.TextColor;
            this.label1.ForeColor = Form1.theme.TextColor;
            //mau line
            this.ChangeColorLine();
        }
        public void ChangeColorLine()
        {
            this.pnLine1.BackColor = Form1.theme.LineColor;
            this.pnLine2.BackColor = Form1.theme.LineColor;
            this.pnLine3.BackColor = Form1.theme.LineColor;
            this.pnLine5.BackColor = Form1.theme.LineColor;
            this.pnLine6.BackColor = Form1.theme.LineColor;
            this.pnLine7.BackColor = Form1.theme.LineColor;
            this.pnLine8.BackColor = Form1.theme.LineColor;
            this.pnLine9.BackColor = Form1.theme.LineColor;
            this.pnLine10.BackColor = Form1.theme.LineColor;
            this.pnLine11.BackColor = Form1.theme.LineColor;
            this.frmMain.PnLine1.BackColor = this.pnLine1.BackColor;
        }
        public void _LoadInforGroup(Group group, List<ucFileShow> listfileShows)
        {
            this.group = group;
            lbName.Text = "Name: "+group.Name;
            lbID.Text = "#"+group.ID;
            Image image = Image.FromFile(group.AvatarPath);
            ptbavata.Image = image;
            ptbavata.SizeMode = PictureBoxSizeMode.StretchImage;
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
        public void _addmember(List<User> listmember)
        {
            List<ucmemberform> listuser = new List<ucmemberform>();
            
            if (listmember != null)
            {

                for (int i = 0; i < listmember.Count; i++)
                {
                    ucmemberform tam = new ucmemberform(group, listmember[i]);
                    listuser.Add(tam);
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

       
        private void lbclearhistory_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete all message!", "Delete message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.frmMain._clearlistchat();
        }

        private void pnclearhistory_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete all message!", "Delete message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.frmMain._clearlistchat();
        }

        private void pictureBoxMenumember_Click_1(object sender, EventArgs e)
        {
            isclickmenumember = !isclickmenumember;
            Graphics g = panelMenumember.CreateGraphics();
            if (isclickmenumember)
            {
                pictureBoxMenumember.Image = _xoayanh(pictureBoxMenumember.Image, 90);
                pnaddmember.Visible = true;
                pnaddmember.AutoSize = true;
                Pen pen = new Pen(Form1.theme.TextColor);
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

        private void pictureBoxMenufile_Click_1(object sender, EventArgs e)
        {
            isclickmenufile = !isclickmenufile;
            Graphics g = panelMenufile.CreateGraphics();
            if (isclickmenufile)
            {
                pictureBoxMenufile.Image = _xoayanh(pictureBoxMenufile.Image, 90);
                pnaddfile.Visible = true;
                pnaddfile.AutoSize = true;
                Pen pen = new Pen(Form1.theme.TextColor);
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
    }
}
