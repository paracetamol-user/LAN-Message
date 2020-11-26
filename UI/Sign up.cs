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
        LoginForm login;
        public Sign_up()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
            {
                this.cbDate.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Ngày : 1 - 31 ngày
            }

            for (int i = 1; i <= 12; i++)
            {
                this.cbMonth.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Tháng : 1 - 12 tháng
            }

            int curYear = DateTime.Now.Year; // Lấy ra năm hiện tại
            for (int i = curYear; i >= 1900; i--)
            {
                this.cbYear.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Năm: 1900 - Năm hiên tại
            }
        }
        public Sign_up(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            for (int i = 1; i <= 31; i++)
            {
                this.cbDate.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Ngày : 1 - 31 ngày
            }

            for (int i = 1; i <= 12; i++)
            {
                this.cbMonth.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Tháng : 1 - 12 tháng
            }

            int curYear = DateTime.Now.Year; // Lấy ra năm hiện tại
            for (int i = curYear; i >= 1900; i--)
            {
                this.cbYear.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Năm: 1900 - Năm hiên tại
            }
        }

        public bool kiemtrangaysinh(ComboBox cbDate, ComboBox cdMonth, ComboBox cdYear)
        {
            if (cbDate.Text != "ngay" && cbMonth.Text != "thang" && cbYear.Text != "nam")
            {
                Ngay ngayhople = new Ngay();
                if(ngayhople.KiemTraHopLe(cbDate, cdMonth, cbYear)==1) return true;
                

            }
            return false;
        }
        public bool kiemtradulieu()
        {
            if(txtTen.Text=="User name" || txtMatkhau.Text=="Matkhau" || txtSodienthoai.Text=="Sodienthoai" || txtTendangnhap.Text=="Tendangnhap" )
            {
                return false;
            }
            if (cbDate.Text == "ngay" || cbMonth.Text == "thang" || cbYear.Text == "nam") return false;
            if (checkBox1.Checked == false && checkBox2.Checked == false) return false;
            return true;

            
        }
        private void ClearTextBox_Combobox()
        {
            
            txtTen.Text = "User name";
            txtTendangnhap.Text = "Ten dang nhap";
            txtMatkhau.Text = "Mat khau";
            txtSodienthoai.Text = "So dien thoai";
            cbDate.Text = "ngay";
            cbMonth.Text = "thang";
            cbYear.Text = "nam";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            
            txtTen.BorderStyle = BorderStyle.Fixed3D;
            txtTendangnhap.BorderStyle = BorderStyle.Fixed3D;
            txtMatkhau.BorderStyle = BorderStyle.Fixed3D;
            txtSodienthoai.BorderStyle = BorderStyle.Fixed3D;
        }

       

        

        private void txtTen_Enter(object sender, EventArgs e)
        {
            if (txtTen.Text == "User name")
            {
                txtTen.Clear();

            }
        }
        public bool kiemtrakytudacbiet(string a)
        {
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == '%') return true;
            }
            return false;
        }
        private void txtTen_Leave(object sender, EventArgs e)
        {
            Pen red = new Pen(Color.Red);
            Pen white = new Pen(Color.White);
            Graphics g = this.CreateGraphics();
            int variance = 1;
            if (txtTen.Text == "" || kiemtrakytudacbiet(txtTen.Text)==true)
            {
                txtTen.Text = "User name";
                txtTen.BorderStyle = BorderStyle.None;
                g.DrawRectangle(red, new Rectangle(txtTen.Location.X - variance, txtTen.Location.Y - variance, txtTen.Width + variance, txtTen.Height + variance));

            }
            else
            {
                g.DrawRectangle(white, new Rectangle(txtTen.Location.X - variance, txtTen.Location.Y - variance, txtTen.Width + variance, txtTen.Height + variance));
                txtTen.BorderStyle = BorderStyle.Fixed3D;
            }
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

        private void txtSodienthoai_Enter(object sender, EventArgs e)
        {
            if (txtSodienthoai.Text == "So dien thoai")
            {
                txtSodienthoai.Clear();

            }
        }

        private void txtSodienthoai_Leave(object sender, EventArgs e)
        {
            if (txtSodienthoai.Text == "")
            {
                txtSodienthoai.Text = "So dien thoai";

            }
            string sodienthoai = txtSodienthoai.Text;
            for (int i = 0; i < sodienthoai.Length; i++)
            {

                Pen red = new Pen(Color.Red);
                Pen white = new Pen(Color.White);
                Graphics g = this.CreateGraphics();
                int variance = 1;
                if (sodienthoai[i] < '0' || sodienthoai[i] > '9')
                {

                    txtSodienthoai.BorderStyle = BorderStyle.None;
                    txtSodienthoai.Text = "So dien thoai";


                    g.DrawRectangle(red, new Rectangle(txtSodienthoai.Location.X - variance, txtSodienthoai.Location.Y - variance, txtSodienthoai.Width + variance, txtSodienthoai.Height + variance));


                    break;
                }
                else
                {

                    g.DrawRectangle(white, new Rectangle(txtSodienthoai.Location.X - variance, txtSodienthoai.Location.Y - variance, txtSodienthoai.Width + variance, txtSodienthoai.Height + variance));
                    txtSodienthoai.BorderStyle = BorderStyle.Fixed3D;
                }

            }
        }

        private void cbDate_Enter(object sender, EventArgs e)
        {
            if (cbDate.Text == "ngay")
            {
                cbDate.Text = "";
            }
        }
        private void cbDate_Leave(object sender, EventArgs e)
        {
            if (cbDate.Text == "")
            {
                cbDate.Text = "ngay";
            }
            string chuoiso = cbDate.Text;
            for (int i = 0; i < chuoiso.Length; i++)
            {
                if (chuoiso[i] < '0' || chuoiso[i] > '9')
                {
                    cbDate.Text = "ngay";
                    break;
                }
            }
        }
        private void cbMonth_Enter(object sender, EventArgs e)
        {

            if (cbMonth.Text == "thang")
            {
                cbMonth.Text = "";

            }
        }
        private void cbMonth_Leave(object sender, EventArgs e)
        {
            if (cbMonth.Text == "")
            {
                cbMonth.Text = "thang";

            }
            string chuoiso = cbMonth.Text;
            for (int i = 0; i < chuoiso.Length; i++)
            {


                if (chuoiso[i] < '0' || chuoiso[i] > '9')
                {


                    cbMonth.Text = "thang";



                    break;
                }


            }

        }

        private void cbYear_Enter(object sender, EventArgs e)
        {
            if (cbYear.Text == "nam")
            {
                cbYear.Text = "";

            }
        }

        private void cbYear_Leave(object sender, EventArgs e)
        {
            if (cbYear.Text == "")
            {
                cbYear.Text = "nam";

            }
            string chuoiso = cbYear.Text;
            for (int i = 0; i < chuoiso.Length; i++)
            {


                if (chuoiso[i] < '0' || chuoiso[i] > '9')
                {


                    cbYear.Text = "nam";



                    break;
                }
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu() == false)
            {
                MessageBox.Show("Vui long nhap du lieu day du!");
            }
            else if (kiemtrangaysinh(cbDate, cbMonth, cbYear) == false)
            {
                MessageBox.Show("Ngay sinh khong hop le!");
                cbDate.Text = "ngay";
                cbMonth.Text = "thang";
                cbYear.Text = "nam";
            }
            else
            {
                bool tempGioitinh = true;
                if (checkBox2.Checked) tempGioitinh = false; 
                UserManager.UserVerification userVerification = new UserManager.UserVerification();
                string pass=userVerification.GetSHA256(txtMatkhau.Text);
                byte[] buff = new byte[1024];
                byte[] tempByte = System.Text.Encoding.ASCII.GetBytes("SIGNUP%" + this.txtTendangnhap.Text + "%" + pass + "%" + this.txtTen.Text +"%" +this.txtSodienthoai.Text + "%" + tempGioitinh.ToString());
                tempByte.CopyTo(buff, 0);
                LoginForm.server.GetStream().WriteAsync(buff, 0, buff.Length);
                string[] data = (await(LoginForm.client.ReadDataAsync(LoginForm.server))).Split(' ');
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox1.Checked = false;
        }

        private void Sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.login.Show();
        }
    }
}
