using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Report.Employee
{
    public class Employee
    {
        private List<EmployeeList> employeeList;

        public Employee()
        {
            employeeList = new List<EmployeeList>();

            Connect con = new Connect();
            MySqlCommand command = new MySqlCommand("select * from employee", con.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string PID = row["ID"].ToString();
                int ID = Convert.ToInt32(PID);

                string Name = row["Name"].ToString();

                string Email = row["Email"].ToString();

                string PhNo = row["PhNo"].ToString();

                string Gender = row["Gender"].ToString();

                string Position = row["Position"].ToString();

                employeeList.Add(new EmployeeList(ID, Name, Email, PhNo, Gender, Position));
            }
        }

        public List<EmployeeList> GetEmployee()
        {
            return employeeList;
        }
    }
}
