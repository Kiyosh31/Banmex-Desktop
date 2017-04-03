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
        private int phone;
        private string rfc;

        public Client(int idClient, string firstName, string lastName, int phone, string rfc)
        {
            this.idClient = idClient;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.rfc = rfc;
        }

        public int IdClient { get { return idClient; } set { idClient = value; } }
        public string FirstName { get{ return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Phone{ get { return phone; } set { phone = value; } }
        public string Rfc{ get { return rfc; } set { rfc = value; } }

        public static int addClient(MySqlConnection Connection, Client client)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO client(firstName, lastName, phone, rfc, active) VALUES('{0}', '{1}', {2}, '{3}', true)", client.firstName, client.lastName, client.phone, client.rfc), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok
            /// if OK = 0 error
            return OK;
        }

        public static Client searchClient(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client WHERE idClient = {0} AND active = true", idClient), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Client client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                return client;
            }
            Client e = null;
            return e;
        }

        public static int modifyClient(MySqlConnection Connection, Client client)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE client SET firstName = '{0}', lastName = '{1}', phone = '{2}', rfc = '{3}', active = true WHERE idClient = {4}", client.firstName, client.lastName, client.phone, client.rfc, client.idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int deleteClient(MySqlConnection Connection, string idClient)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE client SET active = false WHERE idClient = {0}", idClient), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Client> showAllClients(MySqlConnection Connection)
        {
            List<Client> clientList = new List<Client>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client WHERE active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                clientList.Add(client);
            }

            return clientList;
        }
    }
}
