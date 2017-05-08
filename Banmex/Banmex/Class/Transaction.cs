using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banmex.Class
{
    public class Transaction
    {
        private int idTransaction;
        private int origenAccount;
        private int destinyAccount;
        private int employee_idEmployee;
        private string date;
        private float quantity;
        private int accountType;
        private bool cancelTransaction;

        public Transaction(int idTransaction, int origenAccount, int destinyAccount, int employee_idEmployee, string date, float quantity, int accountType, bool cancelTransaction)
        {
            this.idTransaction = idTransaction;
            this.origenAccount = origenAccount;
            this.destinyAccount = destinyAccount;
            this.employee_idEmployee = employee_idEmployee;
            this.date = date;
            this.quantity = quantity;
            this.accountType = accountType;
            this.cancelTransaction = cancelTransaction;
        }

        //getters y setters (prop)
        public int IdTransaction { get { return idTransaction; } set { idTransaction = value; } }
        public int OrigenAccount { get { return origenAccount; } set { origenAccount = value; } }
        public int DestinyAccount { get { return destinyAccount; } set { destinyAccount = value; } }
        public int Employee_IdEmployee { get { return employee_idEmployee; } set { employee_idEmployee = value; } }
        public string Date { get { return date; } set { date = value; } }
        public float Quantity { get { return quantity; } set { quantity = value; } }
        public int AccountType { get { return accountType; } set { accountType = value; } }
        public bool Canceltransaction { get { return cancelTransaction; } set { cancelTransaction = value; } }


        //metodo para ingresar una transaccion, recibe la conexion y un objeto transaccion que contiene todos los datos necesarios
        //el metodo retorna un numero
        // 1 = ingresado correctamente
        public static int addTransaction(MySqlConnection Connection, Transaction transaction)
        {
            MySqlCommand command = new MySqlCommand(
                String.Format("INSERT INTO transaction (OrigenAccount, DestinyAccount, Employee_idEmployee, Date, Quantity, AccountType) VALUES ({0}, {1}, {2}, {3}, {4}, {5})", transaction.origenAccount, transaction.destinyAccount, transaction.employee_idEmployee, transaction.date, transaction.quantity, transaction.accountType), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok
            /// if OK = 0 error
            return OK;
        }

        //este metodo recupera todos los elementos realizados de la tabla transaction y los agrega a una lista con la forma de transaction
        //retorna la lista con todas las transacciones canceladas
        public static IList<Transaction> showAllTransactions(MySqlConnection Connection)
        {
            List<Transaction> transactionsList = new List<Transaction>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM Transaction WHERE CancelTransaction = false"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Transaction transaction = new Transaction(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetFloat(5), reader.GetInt32(6), reader.GetBoolean(7));
                transactionsList.Add(transaction);
            }

            return transactionsList;
        }

        //este metodo recupera todos los elementos cancelados de la tabla transaction y los agrega a una lista con la forma de transaction
        //retorna la lista con todas las transacciones canceladas
        public static IList<Transaction> showAllCanceled(MySqlConnection Connection)
        {
            List<Transaction> canceledList = new List<Transaction>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM Transaction WHERE CancelTransaction = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Transaction transaction = new Transaction(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetFloat(5), reader.GetInt32(6), reader.GetBoolean(7));
                canceledList.Add(transaction);
            }

            return canceledList;
        }

        //este metodo cancela una transaccion, recibe la conexion y un id de la transaccions
        //el metodo retorna el numero de filas afectadas en la db
        // 1 = eliminado correctamente
        public static int deleteTransaction(MySqlConnection Connection, string idTransaction)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE Transaction SET CancelTransaction = true WHERE idTransaction = {0}", idTransaction), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }
    }
}
