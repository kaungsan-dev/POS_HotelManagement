using HotelManagement.Report.Employee;
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
    public partial class testReport : Form
    {
        public testReport()
        {
            InitializeComponent();
        }

        private void testReport_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            employeeListBindingSource.DataSource = emp.GetEmployee();
            this.reportViewer1.RefreshReport();
        }
    }
}
