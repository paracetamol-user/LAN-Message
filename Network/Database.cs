using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public class Database
    {
        private string connString;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;
        public Database()
        {
            this. connString = @"Server=DESKTOP-TSN7OH7;Database=LANCHAT;Integrated Security=True;User ID=sa;Password=1";
            this.connection = new SqlConnection(connString);
        }
        public void Close()
        {
            connection.Close();
        }
        public void Open()
        {
            connection.Open();
        }
        public void SetOnline(string id)
        {
            string queryOnline = "UPDATE USERS SET TINHTRANG = 1 WHERE ID = @id";
            this.connection = new SqlConnection(connString);
            this.connection.Open();
            SqlCommand command = new SqlCommand(queryOnline, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
