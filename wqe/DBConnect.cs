using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wqe
{
    public class DBConnect
    {
        private MySqlConnection _connection;
        public DBConnect()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.201.12";
            builder.UserID = "ISP232_KutuzovPD";
            builder.Password = "saruda72";
            builder.Port = 3306;
            builder.Database = "ISP232_KutuzovPD_";
            builder.CharacterSet = "utf8";

            _connection = new MySqlConnection(builder.ConnectionString);
            _connection.Open();
        }

        public DataTable Select(string sql)
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, _connection);
            table.Load(command.ExecuteReader());
            return table;
        }
    }
}
