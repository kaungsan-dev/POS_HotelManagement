using HotelManagement.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Controller
{
    class EmployeeController
    {
        Connect con = new Connect();

        // Select All Employee List
        public DataTable getEmployeeList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Email", Type.GetType("System.String"));
            dt.Columns.Add("PhNo", Type.GetType("System.String"));
            dt.Columns.Add("Gender", Type.GetType("System.String"));
            dt.Columns.Add("Position", Type.GetType("System.String"));
            dt.Columns.Add("CreatedUser", Type.GetType("System.String"));

            MySqlCommand command = new MySqlCommand("select * from employee", con.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = table.Rows[i]["id"].ToString();
                dr["Name"] = table.Rows[i]["name"].ToString();
                dr["Email"] = table.Rows[i]["email"].ToString();
                dr["PhNo"] = table.Rows[i]["phno"].ToString();
                dr["Gender"] = table.Rows[i]["gender"].ToString();
                dr["Position"] = table.Rows[i]["position"].ToString();
                dr["CreatedUser"] = table.Rows[i]["createduser"].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        // Create Employee
        public bool createEmployee(string EmpName, string Email, string PhNo, string Gender, string Position)
        {
            var createdDate = DateTime.Now;
            string createdUser = "Admin";

            MySqlCommand command = new MySqlCommand();
            string query = "insert into employee(Name, Email, Phno, Gender, Position, CreatedDate, CreatedUser) values (@Name, @Email, @PhNo, @Gender, @Position, @CreatedDate, @CreatedUser)";
            command.CommandText = query;
            command.Connection = con.getConnection();

            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = EmpName;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@PhNo", MySqlDbType.VarChar).Value = PhNo;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@Position", MySqlDbType.VarChar).Value = Position;
            command.Parameters.Add("@CreatedDate", MySqlDbType.DateTime).Value = createdDate;
            command.Parameters.Add("@CreatedUser", MySqlDbType.VarChar).Value = createdUser;

            con.openConnection();

            if (command.ExecuteNonQuery().Equals(1))
            {
                con.closeConnection();
                return true;
            }
            else
            {
                con.closeConnection();
                return false;
            }
        }

        // Update Employee
        public bool updateEmployee(int ID, string Name, string Email, string PhNo, string Gender, string Position)
        {
            var updatedDate = DateTime.Now;

            MySqlCommand command = new MySqlCommand();
            string query = "update employee set Name=@Name, Email=@Email, PhNo=@PhNo, Gender=@Gender, Position=@Position, UpdatedDate=@UpdatedDate where ID=@ID";
            command.CommandText = query;
            command.Connection = con.getConnection();

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@PhNo", MySqlDbType.VarChar).Value = PhNo;
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@Position", MySqlDbType.VarChar).Value = Position;
            command.Parameters.Add("@UpdatedDate", MySqlDbType.Datetime).Value = updatedDate;

            con.openConnection();

            if (command.ExecuteNonQuery().Equals(1))
            {
                con.closeConnection();
                return true;
            }
            else
            {
                con.closeConnection();
                return false;
            }
        }

        // Delete Employee
        public bool deleteEmployee(int ID)
        {
            MySqlCommand command = new MySqlCommand();
            string query = "delete from employee where ID = @ID";
            command.CommandText = query;
            command.Connection = con.getConnection();

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

            con.openConnection();

            if (command.ExecuteNonQuery().Equals(1))
            {
                con.closeConnection();
                return true;
            }
            else
            {
                con.closeConnection();
                return false;
            }
        }
    }
}
