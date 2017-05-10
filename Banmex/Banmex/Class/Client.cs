using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banmex.Class
{
    public class Client
    {
        //se declaran las variables como tipos de datos de la tabla en la db
        private int idClient;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string address;
        private bool active;

        //se reciben todos los datos y se establecen en las variables
        public Client(int idClient, string firstName, string lastName, string phone, string email, string address, bool active)
        {
            this.idClient = idClient;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.active = active;
        }

        //getters y setters (prop)
        public int IdClient { get { return idClient; } set { idClient = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public  string LastName { get { return lastName; } set { lastName = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public bool Active { get { return active; } set { active = value; } }

        //metodo para ingresar el cliente, recibe la conexion y un objeto cliente que contiene todos los datos necesarios
        //el metodo retorna un numero
        // 1 = ingresado correctamente
        public static int addClient(MySqlConnection Connection, Client client)
        {
            MySqlCommand command = new MySqlCommand(
                String.Format("INSERT INTO client (FirstName, LastName, Phone, Email, Address, Active) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', true)", client.firstName, client.lastName, client.phone, client.email, client.address), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok
            /// if OK = 0 error
            return OK;
        }

        //metodo para buscar un cliente, recibe la conexion y el id del cliente
        //cuando encuentra el cliente, lo guarda en un objeto y lo retorna
        public static Client searchClient(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client WHERE idClient = {0} AND Active = true", idClient), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Client client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6));
                return client;
            }
            Client e = null;
            return e;
        }

        //metodo para buscar el id de un cliente, recibe la conexion y el nombre del cliente
        //cuando encuentra el cliente, lo guarda en un objeto de tipo reader y lo retorna
        public static MySqlDataReader searchIdClient(MySqlConnection Connection, string clientName)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM Client WHERE FirstName = {0} AND Active = true", clientName), Connection);
            MySqlDataReader Reader = command.ExecuteReader();
            return Reader;
        }

        //este metodo modifica un cliente, recibe la conexion y un objeto cliente
        //el metodo retorna un numero
        // 1 = modificado correctamente
        public static int modifyClient(MySqlConnection Connection, Client client)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE client SET FirstName = '{0}', LastName = '{1}', Phone = '{2}', Email = '{3}', Address = '{4}' , Active = true WHERE idClient = {5}", client.firstName, client.lastName, client.phone, client.email, client.address, client.idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        //este metodo elimina un cliente, recibe la conexion y un id del cliente
        //el metodo retorna el numero de filas afectadas en la db
        // 1 = eliminado correctamente
        public static int deleteClient(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE client SET Active = false WHERE idClient = {0}", idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        //este metodo recupera todos los elementos activos de la tabla cliente y los agrega a una lista con la forma de cliente
        //retorna la lista con todos los clientes activos
        public static IList<Client> showAllClients(MySqlConnection Connection)
        {
            List<Client> clientList = new List<Client>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client WHERE Active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6));
                clientList.Add(client);
            }

            return clientList;
        }

        //este metodo recupera todos los elementos activos de la tabla cliente y los agrega a una lista con la forma de cliente
        //retorna la lista con todos los clientes activos
        public static int getClientNumber(MySqlConnection Connection)
        {
            List<Client> clientList = new List<Client>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                Client client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6));
                clientList.Add(client);

                count++;
            }

            return count;
        }

        //este metodo recupera todos los elementos inactivos de la tabla cliente y los agrega a una lista con la forma de cliente
        //retorna la lista con todos los clientes inactivos
        public static IList<Client> showDeletedClients(MySqlConnection Connection)
        {
            List<Client> clientList = new List<Client>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client WHERE Active = false"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6));
                clientList.Add(client);
            }

            return clientList;
        }

        //este metodo recupera los clientes eliminados de la db recibe la conexion y un id del cliente
        //el metodo retorna el numero de filas afectadas en la db
        // 1 = recuperado correctamente 
        public static int retrieveEmployee(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET Active = true WHERE idEmployee = '{0}'", idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        //este metodo elimina DEFINITIVAMENTE los clientes eliminados de la db recibe la conexion y un id del cliente
        //el metodo retorna el numero de filas afectadas en la db
        // 1 = eliminado correctamente 
        public static int deleteDefinetly(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("DELETE FROM Client WHERE idClient = '{0}'", idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        //metodo para obtener el ultimo id ingresado del cliente
        public static MySqlDataReader clientMaxId(MySqlConnection Connection)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(idClient) AS idClient FROM Client"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
