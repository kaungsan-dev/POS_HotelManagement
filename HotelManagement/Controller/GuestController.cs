using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Controller
{
    class GuestController
    {
        Connect con = new Connect();

        // Select All Guest List
        public DataTable allGuestList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("customerId", Type.GetType("System.String"));
            dt.Columns.Add("customerName", Type.GetType("System.String"));
            dt.Columns.Add("mobile", Type.GetType("System.String"));
            dt.Columns.Add("nationality", Type.GetType("System.String"));
            dt.Columns.Add("gender", Type.GetType("System.String"));
            dt.Columns.Add("dateofbirth", Type.GetType("System.String"));
            dt.Columns.Add("address", Type.GetType("System.String"));

            MySqlCommand command = new MySqlCommand("select * from customer", con.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["customerId"] = table.Rows[i]["customerid"].ToString();
                dr["customerName"] = table.Rows[i]["customername"].ToString();
                dr["mobile"] = table.Rows[i]["mobile"].ToString();
                dr["nationality"] = table.Rows[i]["nationality"].ToString();
                dr["gender"] = table.Rows[i]["gender"].ToString();
                dr["dateofbirth"] = table.Rows[i]["dateofbirth"].ToString();
                dr["address"] = table.Rows[i]["address"].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
