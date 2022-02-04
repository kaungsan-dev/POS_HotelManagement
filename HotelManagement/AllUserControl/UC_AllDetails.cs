using HotelManagement.Controller;
using HotelManagement.Report.Employee;
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
    public partial class UC_AllDetails : UserControl
    {
        EmployeeController EP;

        Connect con = new Connect();
        String query;
        public UC_AllDetails()
        {
            InitializeComponent();
            EP = new EmployeeController();
        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(searchCombo.SelectedIndex == 0)
            {
                // New Code
                Employee emp = new Employee();
                this.reportViewer1.RefreshReport();
                EmployeeListBindingSource.DataSource = emp.GetEmployee();

                //detailGridView.DataSource = EP.getEmployeeList();

                //Connect con = new Connect();
                //MySqlCommand command = new MySqlCommand();
                //string query = "select * from employee";

                //command.CommandText = query;
                //command.Connection = con.getConnection();
                //con.openConnection();

                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //DataTable table = new DataTable();
                //adapter.SelectCommand = command;
                //adapter.Fill(table);
                //con.closeConnection();
            }
        }
    }
}
