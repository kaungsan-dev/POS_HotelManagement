using HotelManagement.Forms;
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

namespace HotelManagement
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string User = usernameTxtBox.Text;
            string Pass = passTxtBox.Text;
            string ConPass = conPassTxtBox.Text;
            string Role = roleCombo.Text;

            try
            {
                if (User.Equals("") && Pass.Equals("") && ConPass.Equals("") && Role.Equals("") )
                {
                    MessageBox.Show("Fill All Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (User.Equals(""))
                {
                    MessageBox.Show("Please Fill User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Pass.Equals(""))
                {
                    MessageBox.Show("Please Fill Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ConPass.Equals(""))
                {
                    MessageBox.Show("Please Fill Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Pass != ConPass)
                {
                    MessageBox.Show("Please Check Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Role.Equals(""))
                {
                    MessageBox.Show("Please Select Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Connect con = new Connect();
                    MySqlCommand command = new MySqlCommand();
                    string query = "insert into register(Name,Password,Role,UpdatedDate) values(@user, @password, @role, @updatedDate)";
                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = User;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Pass;
                    command.Parameters.Add("@role", MySqlDbType.VarChar).Value = Role;
                    command.Parameters.Add("@updatedDate", MySqlDbType.DateTime).Value = DateTime.Today;
                    //command.Parameters.Add("@updatedUser", MySqlDbType.VarChar).Value = User;

                    command.CommandText = query;
                    command.Connection = con.getConnection();
                    con.openConnection();

                    if (command.ExecuteNonQuery().Equals(1))
                    {
                        MessageBox.Show("User Created", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearBtn.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passTxtBox.PasswordChar = '\0';
                conPassTxtBox.PasswordChar = '\0';
            }
            else
            {
                passTxtBox.PasswordChar = '•';
                conPassTxtBox.PasswordChar = '•';
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTxtBox.Clear();
            passTxtBox.Clear();
            conPassTxtBox.Clear();
            roleCombo.SelectedIndex = -1;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
