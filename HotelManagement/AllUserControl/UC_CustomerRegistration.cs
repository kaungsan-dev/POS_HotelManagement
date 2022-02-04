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
    public partial class UC_CustomerRegistration : UserControl
    {
        function fc = new function();
        String query, query1, query2;

        public void setComboBox(String query, ComboBox comboBox)
        {
            MySqlDataReader dataReader = fc.getForCombo(query);
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    comboBox.Items.Add(dataReader.GetString(i));
                }
            }

            dataReader.Close();

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType = '" + txtType.Text + "' and booked='No'";
            setComboBox(query, txtRoomNo);
            fc.closeConnection();
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        int roomId;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo = '" + txtRoomNo.Text + "'";
            DataSet ds = fc.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            roomId = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAllocateRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" &&
                          txtIdProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "")
            {
                String name = txtName.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIdProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;


                query1 = "insert into customer (customerName,mobile,nationality,gender,dateofbirth,idProof,address,checkin,roomid) values('" + name + "', " + contact + ",'" + nationality + "', '" + gender + "','" + dob + "', '" + idproof + "', '" + address + "', '" + checkin + "'," + roomId + ")";
                query2 = "update rooms set booked = 'Yes' where roomNo = '" + txtRoomNo.Text + "'";
                fc.setData(query1, "Room No " + txtRoomNo.Text + " Allocation Successful");
                fc.updateData(query2);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

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
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtType.SelectedIndex = -1;
            txtRoomNo.SelectedIndex = -1;
            txtPrice.ResetText();
        }
    }
}
