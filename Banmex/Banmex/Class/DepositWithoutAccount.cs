using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banmex.Class
{
    public class DepositWithoutAccount
    {
        private int idDeposit;
        private int idEmployee;
        private int destinyAccount;
        private string date;
        private float quantity;
        private string name;
        private bool cancelTransaction;

        public DepositWithoutAccount(int idDeposit, int idEmployee, int destinyAccount, string date, float quantity, string name, bool cancelTransaction)
        {
            this.idDeposit = idDeposit;
            this.idEmployee = idEmployee;
            this.destinyAccount = destinyAccount;
            this.date = date;
            this.quantity = quantity;
            this.name = name;
            this.cancelTransaction = cancelTransaction;
        }


        //getters y setters (prop)
        public int IdDeposit { get { return idDeposit; } set { idDeposit = value; } }
        public int IdEmployee { get { return idEmployee; } set { idEmployee = value; } }
        public int idDestinty { get { return idDestinty; } set { idDestinty = value; } }
        public string Date { get { return date; } set { date = value; } }
        public float Quantity { get { return quantity; } set { quantity = value; } }
        public string Name { get { return name; } set { name = value; } }
        public bool CancelTransaction { get { return cancelTransaction; } set { cancelTransaction = value; } }

        //este metodo recupera todos los elementos no cancelados de la tabla deposito y los agrega a una lista con la forma de cliente
        //retorna la lista con todos los clientes activos
        public static IList<DepositWithoutAccount> showAllDeposits(MySqlConnection Connection)
        {
            List<DepositWithoutAccount> depositList = new List<DepositWithoutAccount>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM DepositWithoutAccount WHERE CancelTransaction = false"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DepositWithoutAccount deposit = new DepositWithoutAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetFloat(4), reader.GetString(5), reader.GetBoolean(6));
                depositList.Add(deposit);
            }

            return depositList;
        }
    }
}
