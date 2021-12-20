using HotelManagement.Controller;
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

namespace HotelManagement.AllUserControl
{
    public partial class UC_ManageAcc : UserControl
    {
        AccountController AC;
        public UC_ManageAcc()
        {
            InitializeComponent();
            AC = new AccountController();
        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_ManageAcc_Load(object sender, EventArgs e)
        {
            userAllList.DataSource = AC.getAccList();

            Connect con = new Connect();
            MySqlCommand command = new MySqlCommand();
            string query = "select * from register";

            command.CommandText = query;
            command.Connection = con.getConnection();
            con.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            con.closeConnection();
        }

        private void userAllList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxtBox.Text = userAllList.CurrentRow.Cells[0].Value.ToString();

            usernameTxtBox.Text = userAllList.CurrentRow.Cells[1].Value.ToString();
            passTxtBox.Text = userAllList.CurrentRow.Cells[2].Value.ToString();
            roleCombo.Text = userAllList.CurrentRow.Cells[3].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Equals(""))
            {
                MessageBox.Show("Plz select user to update", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (usernameTxtBox.Equals(""))
                {
                    MessageBox.Show("Username must be fill", "UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passTxtBox.Equals(""))
                {
                    MessageBox.Show("Password must be fill", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (roleCombo.Equals(""))
                {
                    MessageBox.Show("Role must be select", "Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = Convert.ToInt32(idTxtBox.Text);
                    string name = usernameTxtBox.Text;
                    string password = passTxtBox.Text;
                    string role = roleCombo.Text;

                    bool updateUser = AC.updateUser(id,name,password,role);

                    if (updateUser == true)
                    {
                        userAllList.DataSource = AC.getAccList();
                        MessageBox.Show("Update Successful", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idTxtBox.Clear();
                        usernameTxtBox.Clear();
                        passTxtBox.Clear();
                        roleCombo.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful Updated", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Equals(""))
            {
                MessageBox.Show("Plz select user to update", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (usernameTxtBox.Equals(""))
                {
                    MessageBox.Show("Username must be fill", "UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passTxtBox.Equals(""))
                {
                    MessageBox.Show("Password must be fill", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (roleCombo.Equals(""))
                {
                    MessageBox.Show("Role must be select", "Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = Convert.ToInt32(idTxtBox.Text);
                    string name = usernameTxtBox.Text;
                    string password = passTxtBox.Text;
                    string role = roleCombo.Text;

                    bool deleteUser = AC.deleteUser(id);

                    if (deleteUser == true)
                    {
                        userAllList.DataSource = AC.getAccList();
                        MessageBox.Show("Delete Successful", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        idTxtBox.Clear();
                        usernameTxtBox.Clear();
                        passTxtBox.Clear();
                        roleCombo.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful Deleted", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
