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
			dgv.CellFormatting += Dgv_CellFormatting;
		}
		public void AddData()
		{
			string query = "Select id,tentk,tinhtrang from users";
			SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString() );
			connection.Open();
			SqlCommand command = new SqlCommand(query, connection);
			command.CommandType = CommandType.Text;
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			connection.Close();
			dgv.DataSource = dt;

		   
			dgv.Columns[3].DefaultCellStyle.Format = "OnOff";
			for (int i = 0; i < dgv.Rows.Count - 1; i++)
			{
				string temp = dgv.Rows[i].Cells[3].Value.ToString();
				//if (dgv.Rows[i].Cells[3].Value.ToString() == "False") dgv.Rows[i].Cells[3].Value = false;
				dgv.Rows[i].Cells[0].Value = i.ToString();
			}
		}
		private void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == 3)
			{
				if (e.Value is bool)
				{
					bool value = (bool)e.Value;
					e.Value = (value) ? "On" : "Off";
					e.FormattingApplied = true;
				}
			}
		}

		private void ucData_Load(object sender, EventArgs e)
		{
			AddData();
		}

		private void btnRefesh_Click(object sender, EventArgs e)
		{
			AddData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//int count = dgv.SelectedRows.Count;
			//string ID;
			//string[] arr = { "tinnhan", "contactmember", "contactbook", "member", "groups", "friend", "users" };
			//for (int i = 0; i < count; i++)
			//{
			//	ID = dgv.SelectedRows[i].Cells[2].Value.ToString();
			//	string query = "delete from " + arr[i] + " where ;
			//	SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
			//	connection.Open();
			//	SqlCommand command = new SqlCommand(query, connection);
			//	command.CommandType = CommandType.Text;
			//	SqlDataAdapter da = new SqlDataAdapter(command);
			//	DataTable dt = new DataTable();
			//	da.Fill(dt);
			//	connection.Close();
			//	dgv.DataSource = dt;
			//}
		}
	}
}
