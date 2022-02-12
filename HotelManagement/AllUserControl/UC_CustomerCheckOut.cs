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

    public partial class UC_CustomerCheckOut : UserControl
    {
        function fc = new function();
        String query;
        String query2;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "SELECT customer.customerId, customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateofbirth,customer.idProof,customer.address,customer.checkin, rooms.roomNo,rooms.roomType,rooms.bed,rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where checkedout = 'NO'";
            DataSet ds = fc.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            this.guna2DataGridView1.Refresh();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT customer.customerId, customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateofbirth,customer.idProof,customer.address,customer.checkin, rooms.roomNo,rooms.roomType,rooms.bed,rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where customerName like '" + txtName.Text + "%' and checkedout = 'NO'";
            DataSet ds = fc.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {

                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String checkedoutdate = txtCheckOutDate.Text;
                    query = "update customer set checkedout = 'YES', checkout='" + checkedoutdate + "' where customerId=" + id + "";
                    query2 = "update rooms set booked = 'No' where roomNo = '" + txtRoomNo.Text + "'";
                    fc.setData(query, "CheckedOut Successfully");
                    fc.updateData(query2);
                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            query = "SELECT customer.customerId, customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateofbirth,customer.idProof,customer.address,customer.checkin, rooms.roomNo,rooms.roomType,rooms.bed,rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where customerName like '" + txtName.Text + "%' and checkedout = 'NO'";
            DataSet ds = fc.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
