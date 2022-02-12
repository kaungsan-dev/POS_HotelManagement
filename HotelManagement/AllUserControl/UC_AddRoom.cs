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
    public partial class UC_AddRoom : UserControl
    {
        function fc = new function();
        String query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fc.getData(query);
            DataGridView.DataSource = ds.Tables[0];

        }

        
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        
        
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo,roomType,bed,price) values ('" + roomno + "', '" + type + "', '" + bed + "'," + price + ")";
                fc.setData(query, "Room Added.");
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UC_AddRoom_Leave_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
        int id;
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtRoomNo.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtType.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBed.Text = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String roomNo = txtRoomNo.Text;
                    String type = txtType.Text;
                    String bed = txtBed.Text;
                    Int64 price = Convert.ToInt64(txtPrice.Text);

                    bool updateRoom = fc.updateRoom(id, roomNo, type, bed, price);

                    if (updateRoom)
                    {
                        UC_AddRoom_Load(this, null);
                        clearAll();
                        MessageBox.Show("Room Updated", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bool deleteRoom = fc.deleteRoom(id);

                    if (deleteRoom)
                    {
                        UC_AddRoom_Load(this, null);
                        clearAll();
                        MessageBox.Show("Room Updated", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
