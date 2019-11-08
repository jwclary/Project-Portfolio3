using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// directive to connect to Mysql
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace ClaryJason_CE02
{
    class DBUtilities
    {
        // methof to build the connection string
        public static string BuildConnectionString()
        {
            // variables to holds the IP address and the port number
            string serverIP = "127.0.0.1";
            string port = "8889";
            string database = "MobileDev";

            return $"server= {serverIP};userid=root;password=root;database={database};port={port}";
        }

        // method to connect to the Mysql database
        public static MySqlConnection Connect(string myConnString)
        {
            // we'll create the connection object to send back
            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn.ConnectionString = myConnString;
                conn.Open();
                // DEBUG: MessageBox to indicate that the connection was successful
                MessageBox.Show("Connected!");
            }
            catch (MySqlException e)
            {
                // check for possible errors being thrown
                switch (e.Number)
                {
                    case 1042:
                        MessageBox.Show("Can't resolve host address.\n\n" + myConnString);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                    default:
                        // MessageBox with the exception error message
                        MessageBox.Show(e.ToString() + "\n\n" + myConnString);
                        break;
                }
            }

            // return the connection object
            return conn;
        }
    }
}

