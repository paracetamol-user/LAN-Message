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
		public ServerUI serverUI { get; set; }
		public ucData(Panel pnM__Contain , ServerUI serverUI)
		{
			InitializeComponent();
			this.pnM__Contain = pnM__Contain;
			this.serverUI = serverUI;
			this.Dock = DockStyle.Fill;
			this.pnM__Contain.Controls.Add(this);
			dgv.CellFormatting += Dgv_CellFormatting;
		}
		public void AddData()
		{
			string query = "Select id,username,status from users";
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
            int count = dgv.SelectedRows.Count;
            string ID;
            string query;
            string status;
            string[] arr = { "tinnhan", "contactmember", "contactbook", "member", "groups", "friend", "users" };
            for (int i = 0; i < count; i++)
            {
                ID = dgv.SelectedRows[i].Cells[1].Value.ToString();
                status = dgv.SelectedRows[i].Cells[3].Value.ToString();
                if (status == "False")
                {
					SqlCommand command;
					SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "delete from message where sender = @IDSENDER or receiver = @IDREVEIVER";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@IDSENDER", ID);
					command.Parameters.AddWithValue("@IDREVEIVER", ID);
					command.ExecuteNonQuery();
					connection.Close();

				    connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "select ID from contactbook where IDUSER = @ID";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", ID);
					var reader = command.ExecuteReader();
					while (reader.HasRows)
                    {
						if (!reader.Read()) break;
						SqlConnection subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
						subconnection.Open();
						SqlCommand subcommand = new SqlCommand("delete from contactmember where ID = @id", subconnection);
						subcommand.Parameters.AddWithValue("@id", reader.GetString(0));
						subcommand.ExecuteNonQuery();
						subconnection.Close();
					}
					connection.Close();

					connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "delete from contactbook where IDUSER = @ID";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", ID);
					command.ExecuteNonQuery();
					connection.Close();

					connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "delete from friend where ID = @ID or IDFRIEND = @IDFRIEND ";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", ID);
					command.Parameters.AddWithValue("@IDFRIEND", ID);
					command.ExecuteNonQuery();
					connection.Close();

					connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "select * from groups where IDADMIN = @IDADMIN ";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@IDADMIN", ID);
					 reader = command.ExecuteReader(); 
					while (reader.HasRows)
                    {
						if (!reader.Read()) break;
						string idGroup = reader.GetString(0);
						string subQuery = "select count(*) from member where IDGROUP = @idgroup ";
						SqlConnection subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
						subconnection.Open();
						SqlCommand subcommand = new SqlCommand(subQuery, subconnection);
						subcommand.Parameters.AddWithValue("@idgroup", idGroup);
						var countMember = (int)subcommand.ExecuteScalar();
						subconnection.Close();
						if (countMember > 1)
                        {
							string newHost = "";
							subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
							subconnection.Open();
							subcommand = new SqlCommand("select IDUSERS from MEMBER where IDGROUP = @id", subconnection);
							subcommand.Parameters.AddWithValue("@id", idGroup);
							SqlDataReader subReader = subcommand.ExecuteReader();
							while (subReader.HasRows)
							{
								if (!subReader.Read()) break;
								if (subReader.GetString(0) != ID)
								{
									newHost = subReader.GetString(0);
									break;
								}
							}
							subconnection.Close();
							// tìm thằng đầu tiên khác host
							subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
							subconnection.Open();
							subcommand = new SqlCommand("Update groups set IDADMIN = @id where IDGROUP = @idnhom", subconnection);
							subcommand.Parameters.AddWithValue("@id", newHost);
							subcommand.Parameters.AddWithValue("@idnhom", idGroup);
							subcommand.ExecuteNonQuery();
							subconnection.Close();
							// thêm nó là host mới
								
							subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
							subconnection.Open();
							subcommand = new SqlCommand("delete from member where IDGROUP = @IDGROUP and IDUSERS = @iduser", subconnection);
							subcommand.Parameters.AddWithValue("@idnhom", idGroup);
							subcommand.Parameters.AddWithValue("@iduser", ID);
							subcommand.ExecuteNonQuery();
							subconnection.Close();
							// xoa nguoi dung trong group
								
							// gui thong bao xoa nguoi dung ve cho server
						}
						else
                        {
							string queryRemoveMember = "delete from member where IDGROUP = @idnhom";
							subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
							subconnection.Open();
							subcommand = new SqlCommand(queryRemoveMember, subconnection);
							subcommand.Parameters.AddWithValue("@idnhom", idGroup);
							subcommand.ExecuteNonQuery();
							subconnection.Close();

							queryRemoveMember = "delete from MESSAGE where RECEIVINGGROUP = @id";
							subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
							subconnection.Open();
							subcommand = new SqlCommand(queryRemoveMember, subconnection);
							subcommand.Parameters.AddWithValue("@id", idGroup);
							subcommand.ExecuteNonQuery();
							subconnection.Close();

							queryRemoveMember = "delete from groups where IDGROUP = @idnhom";
							subconnection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
							subconnection.Open();
							subcommand = new SqlCommand(queryRemoveMember, subconnection);
							subcommand.Parameters.AddWithValue("@idnhom", idGroup);
							subcommand.ExecuteNonQuery();
							subconnection.Close();
						}
					}
					connection.Close();
					connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "delete from member where IDUSERS = @id";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@id", ID);
					command.ExecuteNonQuery();
					connection.Close();
					
					connection = new SqlConnection(ConfigurationManager.AppSettings["Data Source"].ToString());
					connection.Open();
					query = "delete from users where ID = @id";
					command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@id", ID);
					command.ExecuteNonQuery();
					connection.Close();
				serverUI.RemoveUser(ID);
                }

            }
        }
    }
}
