using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wqe.Entities
{
    public class User
    {
        public int ID;
        public string Login;
        public string Password;
        public string Name;

        public User(DataRow row)
        {
            ID = Convert.ToInt32(row["user_id"]);
            Login = Convert.ToString(row["user_login"]);
            Password = Convert.ToString(row["user_password"]);
            Name = Convert.ToString(row["user_name"]);
        }
    }
}
