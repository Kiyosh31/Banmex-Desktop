using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.Menu
{
    public partial class CashierMenu : Form
    {
        Class.Connection Connection = new Class.Connection();
        int idEmployee;

        public CashierMenu(Class.Connection Connection, int idEmployee)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idEmployee = idEmployee;
        }

        private void showClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowClients ClientsWindow = new ShowClients(Connection);
            ClientsWindow.ShowDialog();
            this.Show();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient addWindow = new AddClient(Connection);
            addWindow.ShowDialog();
            this.Show();
        }

        private void retrieveClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RetrieveClients retrieveWindow = new RetrieveClients(Connection);
            retrieveWindow.ShowDialog();
            this.Show();
        }

        private void makeTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForms.AddTransaction addTransaction = new AddForms.AddTransaction(Connection, idEmployee);
            addTransaction.ShowDialog();
            this.Show();
        }

        private void cancelTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowTransaction showTransaction = new ShowTransaction(Connection);
            showTransaction.ShowDialog();
            this.Show();
        }

        private void canceledTransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelForms.CancelTransaction canceledTransaction = new CancelForms.CancelTransaction(Connection);
            canceledTransaction.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForms.AddDeposit addDeposit = new AddForms.AddDeposit(Connection, idEmployee);
            addDeposit.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForms.ShowDeposit showDeposit = new ShowForms.ShowDeposit(Connection);
            showDeposit.ShowDialog();
            this.Show();
        }

        private void cancelDepositButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelForms.CancelDeposit cancelDeposit = new CancelForms.CancelDeposit(Connection);
            cancelDeposit.ShowDialog();
            this.Show();
        }
    }
}
