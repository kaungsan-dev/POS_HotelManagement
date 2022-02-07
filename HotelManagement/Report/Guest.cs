using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Report.Guest
{
    public class Guest
    {
        private List<GuestList> guestList;

        public Guest()
        {
            guestList = new List<GuestList>();

            Connect con = new Connect();
            MySqlCommand command = new MySqlCommand("select * from customer", con.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                string PID = row["customerId"].ToString();
                int customerId = Convert.ToInt32(PID);

                string customerName = row["customerName"].ToString();

                string mobile = row["mobile"].ToString();

                string nationality = row["nationality"].ToString();

                string gender = row["gender"].ToString();

                string dateofbirth = row["dateofbirth"].ToString();

                string address = row["address"].ToString();

                guestList.Add(new GuestList(customerId, customerName, mobile, nationality, gender, dateofbirth, address));
            }
        }

        public List<GuestList> GetGuest()
        {
            return guestList;
        }
    }
}
