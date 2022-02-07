using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    class function
    {
        //protected MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;username=root;database=myHotel;SSL Mode=None");
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=hotelmanagement");
        protected MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataSet getData(String query)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        public void setData(String query, String message)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void updateData(String query)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
        }

        public bool updateCustomer(int id, string name, Int64 contact, string nationality, string gender, string dob, string idProof, string address, string checkin)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand command = new MySqlCommand();
            string query = "update customer set customerName=@name, mobile=@contact, nationality=@nationality, gender=@gender, dateofbirth=@dob, idProof=@idProof, address=@address, checkin=@checkin where customerId=@id";
            command.CommandText = query;
            command.Connection = conn;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@contact", MySqlDbType.Int64).Value = contact;
            command.Parameters.Add("@nationality", MySqlDbType.VarChar).Value = nationality;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
            command.Parameters.Add("@idproof", MySqlDbType.VarChar).Value = idProof;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@checkin", MySqlDbType.VarChar).Value = checkin;
            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        public bool deleteCustomer(int id)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand command = new MySqlCommand();
            string query = "delete from customer where customerId=@id";
            command.CommandText = query;
            command.Connection = conn;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        public MySqlDataReader getForCombo(String query)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            conn.Open();
            command = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                return dataReader;
            }
            else
            {
                return null;
            }


        }
    }

}
