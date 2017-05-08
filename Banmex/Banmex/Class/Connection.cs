using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banmex.Class
{
    public class Connection
    {
        //se declara un MySQLsqlConnection como objeto
        public MySqlConnection myConnection;

        public Connection()
        {
            //recibimos los datos de la db y como conectarse a ella
            myConnection = new MySqlConnection("server = 127.0.0.1; port = 3306; database = banmex; Uid = root; pwd = root");
        }

        public bool OpenConnection()
        {
            //se intenta abrir una conexion con la db y se retorna verdadero
            try
            {
                myConnection.Open();
                return true;
            }
            //en caso contrario se retorna falso y presentamos una excepcion
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool CloseConnection()
        {
            //Se intenta cerrar la conexion con la db y se retorna verdadero
            try
            {
                myConnection.Close();
                return true;
            }
            //Se intenta cerrar la conexion con la db y se retorna falso
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
