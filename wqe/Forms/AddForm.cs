using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wqe.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnect connect = new DBConnect();
            connect.Select($"INSERT INTO `users` (`user_login`, `user_password`, `user_name`) VALUES ('{tbLogin.Text}', '{tbPass.Text}', '{tbName.Text}');");
            Close();
        }
    }
}
