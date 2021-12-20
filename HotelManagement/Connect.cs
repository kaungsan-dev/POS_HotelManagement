using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    class Connect
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=hotelmanagement");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State.Equals(System.Data.ConnectionState.Closed))
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State.Equals(System.Data.ConnectionState.Open))
            {
                connection.Close();
            }
        }
    }
}
