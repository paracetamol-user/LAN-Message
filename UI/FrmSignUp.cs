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

namespace UI
{
    public partial class Sign_up : Form
    {
        FrmLogin login;
        public Sign_up()
        {
            InitializeComponent();
            
        }
        public Sign_up(FrmLogin login)
        {
            InitializeComponent();
            this.login = login;
           
        }
        public bool kiemtramatkhau()
        {
            if(txtMatkhau.Text != txtNhaplaimatkhau.Text)
            {
                return false;
            }
            return true;
        }
        public bool kiemtradulieu()
        {
            if(txtNhaplaimatkhau.Text=="Nhap lai mat khau" || txtMatkhau.Text=="Mat khau"  || txtTendangnhap.Text=="Ten dang nhap" )
            {
                return false;
            }
            
            return true;

            
        }
        private void ClearTextBox_Combobox()
        {
           
            txtTendangnhap.Text = "Ten dang nhap";
            txtMatkhau.PasswordChar = '\0';
            txtMatkhau.Text = "Mat khau";
            txtNhaplaimatkhau.PasswordChar = '\0';
            txtNhaplaimatkhau.Text = "Nhap lai mat khau";

            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            
            txtNhaplaimatkhau.BorderStyle = BorderStyle.Fixed3D;
            txtTendangnhap.BorderStyle = BorderStyle.Fixed3D;
            txtMatkhau.BorderStyle = BorderStyle.Fixed3D;
           
        }

       public bool kiemtrakytudacbiet(string a)
        {
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == '%') return true;
            }
            return false;
        }
       
        private void txtTendangnhap_Enter(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "Ten dang nhap")
            {
                txtTendangnhap.Clear();

            }
        }

        private void txtTendangnhap_Leave(object sender, EventArgs e)
        {
            Pen red = new Pen(Color.Red);
            Pen white = new Pen(Color.White);
            Graphics g = this.CreateGraphics();
            int variance = 1;
            if (txtTendangnhap.Text == "" || kiemtrakytudacbiet(txtTendangnhap.Text)==true)
            {
                txtTendangnhap.Text = "Ten dang nhap";
                txtTendangnhap.BorderStyle = BorderStyle.None;
                g.DrawRectangle(red, new Rectangle(txtTendangnhap.Location.X - variance, txtTendangnhap.Location.Y - variance, txtTendangnhap.Width + variance, txtTendangnhap.Height + variance));

            }
            else
            {
                g.DrawRectangle(white, new Rectangle(txtTendangnhap.Location.X - variance, txtTendangnhap.Location.Y - variance, txtTendangnhap.Width + variance, txtTendangnhap.Height + variance));

                txtTendangnhap.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "Mat khau")
            {
                txtMatkhau.Clear();
                txtMatkhau.PasswordChar = '*';

            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            Pen red = new Pen(Color.Red);
            Pen white = new Pen(Color.White);
            Graphics g = this.CreateGraphics();
            int variance = 1;
            if (txtMatkhau.Text == "" || kiemtrakytudacbiet(txtMatkhau.Text)==true)
            {
                txtMatkhau.PasswordChar = '\0';
                txtMatkhau.Text = "Mat khau";

                txtMatkhau.BorderStyle = BorderStyle.None;
                g.DrawRectangle(red, new Rectangle(txtMatkhau.Location.X - variance, txtMatkhau.Location.Y - variance, txtMatkhau.Width + variance, txtMatkhau.Height + variance));



            }
            else
            {
                g.DrawRectangle(white, new Rectangle(txtMatkhau.Location.X - variance, txtMatkhau.Location.Y - variance, txtMatkhau.Width + variance, txtMatkhau.Height + variance));
                txtMatkhau.BorderStyle = BorderStyle.Fixed3D;
                txtMatkhau.PasswordChar = '*';
            }
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu() == false)
            {
                MessageBox.Show("Vui long nhap du lieu day du!");
            }
            else
            if(kiemtramatkhau()==false)
            {
                MessageBox.Show("Mat khau khong trung khop!");
                txtNhaplaimatkhau.PasswordChar = '\0';
                txtNhaplaimatkhau.Text = "Nhap lai mat khau";
            }
            else
            {
               
               try
                {
                    UserManager.UserVerification userVerification = new UserManager.UserVerification();
                    string pass = userVerification.GetSHA256(txtMatkhau.Text);

                    byte[] tempbuff = Encoding.UTF8.GetBytes("SIGNUP%" + this.txtTendangnhap.Text + "%" + pass);
                    SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
                    await FrmLogin.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);

                    byte[] buffReceive = new byte[1024];
                    await FrmLogin.server.GetStream().ReadAsync(buffReceive, 0, buffReceive.Length);
                    SmallPackage packageReceive = new SmallPackage();
                    packageReceive.DividePackage(buffReceive);

                    string[] data = (Encoding.UTF8.GetString(packageReceive.Data).Trim('\0', '\t', '\n')).Split('%');
                    if (data[0].Trim('\0', '\r', '\n') == "SIGNUPOKE")
                    {
                        MessageBox.Show("SIGN UP successfully");
                        this.login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tai khoan da ton tai");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

       
        private void Sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.login.Show();
        }

        private void txtNhaplaimatkhau_Enter(object sender, EventArgs e)
        {
            if (txtNhaplaimatkhau.Text == "Nhap lai mat khau")
            {
                txtNhaplaimatkhau.Clear();
                txtNhaplaimatkhau.PasswordChar = '*';
            }
        }

        private void txtNhaplaimatkhau_Leave(object sender, EventArgs e)
        {
            Pen red = new Pen(Color.Red);
            Pen white = new Pen(Color.White);
            Graphics g = this.CreateGraphics();
            int variance = 1;
            if (txtNhaplaimatkhau.Text == "" || kiemtrakytudacbiet(txtNhaplaimatkhau.Text) == true)
            {
                txtNhaplaimatkhau.PasswordChar = '\0';
                txtNhaplaimatkhau.Text = "Nhap lai mat khau";

                txtNhaplaimatkhau.BorderStyle = BorderStyle.None;
                g.DrawRectangle(red, new Rectangle(txtNhaplaimatkhau.Location.X - variance, txtNhaplaimatkhau.Location.Y - variance, txtNhaplaimatkhau.Width + variance, txtNhaplaimatkhau.Height + variance));



            }
            else
            {
                g.DrawRectangle(white, new Rectangle(txtNhaplaimatkhau.Location.X - variance, txtNhaplaimatkhau.Location.Y - variance, txtNhaplaimatkhau.Width + variance, txtNhaplaimatkhau.Height + variance));
                txtNhaplaimatkhau.BorderStyle = BorderStyle.Fixed3D;
                txtNhaplaimatkhau.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.login.Show();
            this.Close();
        }

        private async  void txtNhaplaimatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kiemtradulieu() == false)
                {
                    MessageBox.Show("Vui long nhap du lieu day du!");
                }
                else
                if (kiemtramatkhau() == false)
                {
                    MessageBox.Show("Mat khau khong trung khop!");
                    txtNhaplaimatkhau.PasswordChar = '\0';
                    txtNhaplaimatkhau.Text = "Nhap lai mat khau";
                }
                else
                {

                    try
                    {
                        UserManager.UserVerification userVerification = new UserManager.UserVerification();
                        string pass = userVerification.GetSHA256(txtMatkhau.Text);

                        byte[] tempbuff = Encoding.UTF8.GetBytes("SIGNUP%" + this.txtTendangnhap.Text + "%" + pass);
                        SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
                        await FrmLogin.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);

                        byte[] buffReceive = new byte[1024];
                        await FrmLogin.server.GetStream().ReadAsync(buffReceive, 0, buffReceive.Length);
                        SmallPackage packageReceive = new SmallPackage();
                        packageReceive.DividePackage(buffReceive);

                        string[] data = (Encoding.UTF8.GetString(packageReceive.Data).Trim('\0', '\t', '\n')).Split('%');
                        if (data[0].Trim('\0', '\r', '\n') == "SIGNUPOKE")
                        {
                            MessageBox.Show("SIGN UP successfully");
                            this.login.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tai khoan da ton tai");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}
