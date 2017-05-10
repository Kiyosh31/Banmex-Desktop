using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banmex.Class
{
    public class Account
    {
        private int idAccount;
        private int Client_idClient;
        private string nip;
        private float balance;
        private float maximumCredit;
        private string cutOffDay;
        private int accountType;
        private bool active;

        public Account(int idAccount, int Client_idClient, string nip, float balance, float maximumCredit, string cutOffDay, int accountType, bool active)
        {
            this.idAccount = idAccount;
            this.Client_idClient = Client_idClient;
            this.nip = nip;
            this.balance = balance;
            this.maximumCredit = maximumCredit;
            this.cutOffDay = cutOffDay;
            this.accountType = accountType;
            this.active = active;
        }


        //getters y setters (prop)
        public int IdAccount { get { return idAccount; } set { idAccount = value; } }
        public int Client_IdClient { get { return Client_idClient; } set { Client_idClient = value; } }
        public string Nip { get { return nip; } set { nip = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
        public float MaximumCredit { get { return maximumCredit; } set { maximumCredit = value; } }
        public string CutOffDay { get { return cutOffDay; } set { cutOffDay = value; } }
        public int AccountType { get { return accountType; } set { accountType = value; } }
        public bool Active { get { return active; } set { active = value; } }


        //metodo para ingresar la cuenta, recibe la conexion y un objeto cuenta que contiene todos los datos necesarios
        //el metodo retorna el numero de filas afectadas en la db
        // 1 = ingresado correctamente
        public static int addAccount(MySqlConnection Connection, Account account)
        {
            MySqlCommand command = new MySqlCommand(
                String.Format("INSERT INTO account (Client_idClient, NIP, Balance, MaximumCredit, CutOffDay, AccountType, Active) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, true)", account.Client_idClient, account.nip, account.balance, account.maximumCredit, account.cutOffDay, account.accountType), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok
            /// if OK = 0 error
            return OK;
        }

        //este metodo recupera todos los elementos activos de la tabla cuentas y los agrega a una lista con la forma de cuenta
        //retorna la lista con todas las cuentas activos
        public static IList<Account> showAllAccounts(MySqlConnection Connection)
        {
            List<Account> accountList = new List<Account>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM Account WHERE Active = true ORDER BY Client_idClient"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Account account = new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                accountList.Add(account);
            }

            return accountList;
        }

        //metodos para buscar una cuenta, recibe la conexion y el id de la cuenta
        //cuando encuentra la cuenta, lo guarda en un objeto y lo retorna
        public static Account searchAccount(MySqlConnection Connection, string idAccount)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM account WHERE idAccount = {0} AND Active = true", idAccount), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Account account = new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                return account;
            }
            Account e = null;
            return e;
        }

        //metodos para buscar el id de una cuenta, recibe la conexion y el id de un cliente
        //cuando encuentra la cuenta, lo guarda en un objeto y lo retorna
        public static int searchIdAccount(MySqlConnection Connection, string idClient)
        {
            int idAccount = 0;

            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM account WHERE Client_idClient = {0} AND Active = true", idClient), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Account account = new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                
                if(account.Client_idClient == Convert.ToInt32(idClient))
                {
                    idAccount = account.idAccount;
                }
            }

            return idAccount;
        }

        //este metodo elimina una cuenta, recibe la conexion y un id de la cuenta
        //el metodo retorna el numero de filas afectadas en la db
        // 1 = eliminado correctamente
        public static int deleteAccount(MySqlConnection Connection, string idAccount)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE Account SET Active = false WHERE idAccount = {0}", idAccount), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        //este metodo modifica una cuenta, recibe la conexion y un objeto cuenta
        //el metodo retorna un numero
        // 1 = modificado correctamente
        public static int modifyAccount(MySqlConnection Connection, Account account)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE Account SET NIP = '{0}', Balance = {1}, MaximumCredit = {2}, CutOffDay = '{3}', AccountType = {4} , Active = true WHERE idAccount = {5}", account.nip, account.balance, account.maximumCredit, account.cutOffDay, account.AccountType, account.idAccount), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }
    }
}
