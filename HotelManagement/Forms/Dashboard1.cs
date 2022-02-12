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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {
           uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
            btnAddRoom.PerformClick();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
              uC_AddRoom1.Visible = true;
              uC_AddRoom1.BringToFront();
        }

        private void btnGuestRegistration_Click(object sender, EventArgs e)
        {
         uC_CustomerRegistration1.Visible = true;
         uC_CustomerRegistration1.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
           uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
