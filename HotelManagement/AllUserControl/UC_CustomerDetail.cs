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
    public partial class UC_CustomerDetail : UserControl
    {
        function fc = new function();
        String query;

        public UC_CustomerDetail()
        {
            InitializeComponent();
        }

        private void UC_CustomerDetail_Load(object sender, EventArgs e)
        {
            query = "select * from customer";
            DataSet ds = fc.getData(query);
            DataGridView.DataSource = ds.Tables[0];
        }
        int id;
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContact.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNationality.Text = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGender.Text = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDob.Text = DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtIdProof.Text = DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtAddress.Text = DataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
              

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" &&
                txtIdProof.Text != "" && txtAddress.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String name = txtName.Text;
                    Int64 contact = Convert.ToInt64(txtContact.Text);
                    String nationality = txtNationality.Text;
                    String gender = txtGender.Text;
                    String dob = txtDob.Text;
                    String idProof = txtIdProof.Text;
                    String address = txtAddress.Text;
                  

                    bool updateCustomer = fc.updateCustomer(id, name, contact, nationality, gender, dob, idProof, address);

                    if (updateCustomer)
                    {
                        UC_CustomerDetail_Load(this, null);
                        clearAll();
                        MessageBox.Show("Customer Updated", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" &&
              txtIdProof.Text != "" && txtAddress.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bool deleteCustomer = fc.deleteCustomer(id);

                    if (deleteCustomer)
                    {
                        UC_CustomerDetail_Load(this, null);
                        clearAll();
                        MessageBox.Show("Customer Deleted", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
         
        }

        private void UC_CustomerDetail_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            query = "select * from customer";
            DataSet ds = fc.getData(query);
            DataGridView.DataSource = ds.Tables[0];
        }
    }
}
