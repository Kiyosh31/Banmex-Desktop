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

        public static IList<Client> showAllClients(MySqlConnection Connection)
        {
            List<Client> clientList = new List<Client>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM client"), Connection);
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
