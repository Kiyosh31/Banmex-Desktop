using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Client_IdClient { get { return Client_IdClient; } set { Client_IdClient = value; } }
        public string Nip { get { return nip; } set { nip = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
        public float MaximumCredit { get { return maximumCredit; } set { maximumCredit = value; } }
        public string CutOffDay { get { return CutOffDay; } set { CutOffDay = value; } }
        public int AccountType { get { return accountType; } set { accountType = value; } }
        public bool Active { get { return active; } set { active = value; } }
    }
}
