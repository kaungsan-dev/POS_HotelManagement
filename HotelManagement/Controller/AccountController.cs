using HotelManagement.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Controller
{
    class AccountController
    {
        Connect con = new Connect();

        public DataTable getAccList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Password", Type.GetType("System.String"));
            dt.Columns.Add("Role", Type.GetType("System.String"));
            //dt.Columns.Add("UpdatedUser", Type.GetType("System.String"));

            MySqlCommand command = new MySqlCommand("select * from register", con.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = table.Rows[i]["id"].ToString();
                dr["Name"] = table.Rows[i]["name"].ToString();
                dr["Password"] = table.Rows[i]["password"].ToString();
                dr["Role"] = table.Rows[i]["role"].ToString();
                //dr["UpdatedUser"] = table.Rows[i]["updateduser"].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        // Update User
        public bool updateUser(int id, string name, string password, string role)
        {
            //string updateUser = name;
            var updateTime = DateTime.Today;

            MySqlCommand command = new MySqlCommand();
            string query = "update register set Name = @Name, Password = @Password, Role = @Role, UpdatedDate = @UpdatedDate where ID = @ID";
            command.CommandText = query;
            command.Connection = con.getConnection();

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@Role", MySqlDbType.VarChar).Value = role;
            command.Parameters.Add("@UpdatedDate", MySqlDbType.DateTime).Value = updateTime;
            //command.Parameters.Add("@UpdatedUser", MySqlDbType.Int32).Value = updateUser;

            con.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                con.closeConnection();
                return true;
            }
            else
            {
                con.closeConnection();
                return false;
            }
        }

        // Delete User
        public bool deleteUser (int id)
        {
            MySqlCommand command = new MySqlCommand();
            string query = "delete from register where ID = @id";
            command.CommandText = query;
            command.Connection = con.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            con.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                con.closeConnection();
                return true;
            }
            else
            {
                con.closeConnection();
                return false;
            }
        }
    }
}
