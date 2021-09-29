using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wqe.Entities;

namespace wqe.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddForm newForm = new AddForm();
            newForm.ShowDialog();
            UpdateTable();
        }
        public void UpdateTable()
        {
            dgvMain.Rows.Clear();

            DBConnect connection = new DBConnect();
            DataTable table = connection.Select("Select * from users");

            foreach (DataRow row in table.Rows)
            {
                User user = new User(row);
                dgvMain.Rows.Add(user.ID, user.Login, user.Password, user.Name);
            }
        }
    }
}
