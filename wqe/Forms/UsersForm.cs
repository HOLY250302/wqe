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
            UpdateTable();
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
                int r = dgvMain.Rows.Add(user.ID, user.Login, user.Password, user.Name);
                dgvMain.Rows[r].Tag = user;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0)
                return;
            User u = dgvMain.SelectedRows[0].Tag as User;
            if(MessageBox.Show ("You want delete user " + u.Name + "?", "Delete user", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                u.Delete();
                UpdateTable();
            }
           
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
         //   if(dgvMain.SelectedRows.Count > 0)
          //  {
          //      User user = dgvMain.SelectedRows [0].Tag as User;
              //  new UserAddForm(user).ShowDialog();
            //    UpdateTable();
         //   }
        }
    }
}
