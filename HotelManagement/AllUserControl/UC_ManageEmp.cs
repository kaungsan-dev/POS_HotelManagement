using System;
using HotelManagement.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement.AllUserControl
{
    public partial class UC_ManageEmp : UserControl
    {
        EmployeeController EP;
        UC_ManageAcc manageAcc;
        public UC_ManageEmp()
        {
            InitializeComponent();
            EP = new EmployeeController();
            manageAcc = new UC_ManageAcc();
        }

        private void UC_ManageEmp_Load(object sender, EventArgs e)
        {
            empAllList.DataSource = EP.getEmployeeList();

            Connect con = new Connect();
            MySqlCommand command = new MySqlCommand();
            string query = "select * from employee";

            command.CommandText = query;
            command.Connection = con.getConnection();
            con.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            con.closeConnection();
        }

        private void empAllList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxtBox.Text = empAllList.CurrentRow.Cells[0].Value.ToString();

            empnameTxtBox.Text = empAllList.CurrentRow.Cells[1].Value.ToString();
            emailTxtBox.Text = empAllList.CurrentRow.Cells[2].Value.ToString();
            phTxtBox.Text = empAllList.CurrentRow.Cells[3].Value.ToString();
            genderCombo.Text = empAllList.CurrentRow.Cells[4].Value.ToString();
            positionTxtBox.Text = empAllList.CurrentRow.Cells[5].Value.ToString();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string EmpName = empnameTxtBox.Text;
                string Email = emailTxtBox.Text;
                string PhNo = phTxtBox.Text;
                string Gender = genderCombo.Text;
                string Position = positionTxtBox.Text;

                if (Position == "")
                {
                    MessageBox.Show("Please Fill Position", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PhNo.Equals("")){
                    MessageBox.Show("Please Fill PhNo", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Gender.Equals(""))
                {
                    MessageBox.Show("Please Fill Gender", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (EmpName.Equals(""))
                {
                    MessageBox.Show("Please Fill Employee", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Email.Equals(""))
                {
                    MessageBox.Show("Please Fill Email", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string empname = empnameTxtBox.Text;
                    string email = emailTxtBox.Text;
                    string phno = phTxtBox.Text;
                    string gender = genderCombo.Text;
                    string position = positionTxtBox.Text;
                    bool createEmp = EP.createEmployee(EmpName, Email, PhNo, Gender, Position);

                    if(createEmp == true)
                    {
                        empAllList.DataSource = EP.getEmployeeList();
                        MessageBox.Show("Create Successful", "Employee Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empnameTxtBox.Clear();
                        emailTxtBox.Clear();
                        phTxtBox.Clear();
                        genderCombo.SelectedIndex = -1;
                        positionTxtBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Fail! Please Check", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Equals(""))
            {
                MessageBox.Show("Must be select Employee", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (empnameTxtBox.Equals(""))
                {
                    MessageBox.Show("Employee Name must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (emailTxtBox.Equals(""))
                {
                    MessageBox.Show("Email must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phTxtBox.Equals(""))
                {
                    MessageBox.Show("Phone Number must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (genderCombo.Equals(""))
                {
                    MessageBox.Show("Must be select Gender", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (positionTxtBox.Equals(""))
                {
                    MessageBox.Show("Position must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = Convert.ToInt32(idTxtBox.Text);
                    string empName = empnameTxtBox.Text;
                    string email = emailTxtBox.Text;
                    string phno = phTxtBox.Text;
                    string gender = genderCombo.Text;
                    string position = positionTxtBox.Text;

                    bool updateEmp = EP.updateEmployee(id,empName,email,phno,gender,position);

                    if (updateEmp == true)
                    {
                        empAllList.DataSource = EP.getEmployeeList();
                        MessageBox.Show("Update Successful", "Employee Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idTxtBox.Clear();
                        empnameTxtBox.Clear();
                        emailTxtBox.Clear();
                        phTxtBox.Clear();
                        genderCombo.SelectedIndex = -1;
                        positionTxtBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful Updated", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Equals(""))
            {
                MessageBox.Show("Plz select Employee to update", "Select Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (empnameTxtBox.Equals(""))
                {
                    MessageBox.Show("Employee must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (emailTxtBox.Equals(""))
                {
                    MessageBox.Show("Email must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phTxtBox.Equals(""))
                {
                    MessageBox.Show("Ph Number must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (genderCombo.Equals(""))
                {
                    MessageBox.Show("Gender must be select", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (positionTxtBox.Equals(""))
                {
                    MessageBox.Show("Position must be fill", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = Convert.ToInt32(idTxtBox.Text);
                    string empName = empnameTxtBox.Text;
                    string email = emailTxtBox.Text;
                    string phno = phTxtBox.Text;
                    string gender = genderCombo.Text;
                    string position = positionTxtBox.Text;

                    bool deleteEmp = EP.deleteEmployee(id);

                    if(deleteEmp == true)
                    {
                        empAllList.DataSource = EP.getEmployeeList();
                        MessageBox.Show("Delete Successful", "Employee Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        idTxtBox.Clear();
                        empnameTxtBox.Clear();
                        emailTxtBox.Clear();
                        phTxtBox.Clear();
                        genderCombo.SelectedIndex = -1;
                        positionTxtBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful Deleted", "Employee Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
