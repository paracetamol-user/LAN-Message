using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Server
{
    public partial class ucData : UserControl
    {
        public Panel pnM__Contain { get; set; }
        public ucData(Panel pnM__Contain)
        {
            InitializeComponent();
            this.pnM__Contain = pnM__Contain;
            this.Dock = DockStyle.Fill;
            this.pnM__Contain.Controls.Add(this);
        }
        public void AddData()
        {
            string query = "Select id,tentk,tinhtrang from users";
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Database Source"].ToString() );
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dgv.DataSource = dt;
        }
        private void ucData_Load(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
