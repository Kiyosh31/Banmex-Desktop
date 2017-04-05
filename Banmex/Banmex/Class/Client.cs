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
        private int idClient;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string address;
        private bool active;

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

        public static int addClient(MySqlConnection Connection, Client client)
        {
            MySqlCommand command = new MySqlCommand(
                String.Format("INSERT INTO client (FirstName, LastName, Phone, Email, Address, Active) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', true)", client.firstName, client.lastName, client.phone, client.email, client.address), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok
            /// if OK = 0 error
            return OK;
        }

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

        public static int modifyClient(MySqlConnection Connection, Client client)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE client SET FirstName = '{0}', LastName = '{1}', Phone = '{2}', Email = '{3}', Address = '{4}' , Active = true WHERE idClient = {5}", client.firstName, client.lastName, client.phone, client.email, client.address, client.idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int deleteClient(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE client SET Active = false WHERE idClient = {0}", idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

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

        public static int retrieveEmployee(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET Active = true WHERE idEmployee = '{0}'", idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }
    }
}
