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
    public partial class Dashboard : Form
    {
        Login login = new Login();
        
        public Dashboard(Login _login)
        {
            InitializeComponent();
            login = _login;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
                login.Show();
            }
        }

        private void manageEmpBtn_Click(object sender, EventArgs e)
        {
            movingPanel.Left = manageEmpBtn.Left+15;
        }

        private void manageAccBtn_Click(object sender, EventArgs e)
        {
            movingPanel.Left = manageAccBtn.Left+5;
            uC_ManageAcc1.Visible = true;
            uC_ManageAcc1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_ManageAcc1.Visible = false;
        }
    }
}
