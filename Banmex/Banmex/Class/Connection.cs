using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banmex.Class
{
    class Connection
    {
        public MySqlConnection myConnection;

        public Connection()
        {
            myConnection = new MySqlConnection("server = 127.0.0.1; port = 3306; database = banmex; Uid = root; pwd = root");
        }

        public bool OpenConnection()
        {
            try
            {
                myConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                myConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
