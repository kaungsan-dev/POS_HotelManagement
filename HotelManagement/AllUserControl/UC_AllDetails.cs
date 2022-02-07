using HotelManagement.Controller;
using HotelManagement.Report.Employee;
using HotelManagement.Report.Guest;
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
                reportViewer1.BringToFront();
                EmployeeListBindingSource.DataSource = emp.GetEmployee();
            }
            else if(searchCombo.SelectedIndex == 1)
            {
                reportViewer2.BringToFront();
                Guest guest = new Guest();
                this.reportViewer2.RefreshReport();
                GuestListBindingSource.DataSource = guest.GetGuest();
            }
        }
    }
}
