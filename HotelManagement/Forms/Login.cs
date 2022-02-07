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

namespace HotelManagement.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regiForm = new Register();
            regiForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userNameLogin.Text;
            string pass = passLogin.Text;
            string role = roleLogin.Text;

            Connect con = new Connect();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            string query = "select * from register where Name = @user And Password = @pass And Role = @role";

            command.CommandText = query;
            command.Connection = con.getConnection();

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (user.Equals("") || pass.Equals("") || role.Equals(""))
            {
                MessageBox.Show("Fill Username, Password and Role", "Fill the field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Count > 0 )
            {
                // Control Permission
                if (role.Equals("Manager"))
                {
                    this.Hide();
                    Dashboard um = new Dashboard(this);
                    um.Show();
                    clearBtn.PerformClick();
                }
                else if (role.Equals("Reception"))
                {
                    this.Hide();
                    Dashboard1 df1 = new Dashboard1();
                    df1.Show();
                    clearBtn.PerformClick();
                }
            }
            else
            {
                errLbl.Visible = true;
                clearBtn.PerformClick();
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passLogin.PasswordChar = '\0';
            }
            else
            {
                passLogin.PasswordChar = '•';
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userNameLogin.Clear();
            passLogin.Clear();
            roleLogin.SelectedIndex = -1;
        }
    }
}
