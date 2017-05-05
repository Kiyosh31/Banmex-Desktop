using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
