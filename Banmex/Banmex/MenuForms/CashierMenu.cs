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
            MakeTransaction transactionWindow = new MakeTransaction(Connection, idEmployee);
            transactionWindow.ShowDialog();
            this.Show();
        }

        private void cancelTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelTransaction cancelWindow = new CancelTransaction(Connection, idEmployee);
            cancelWindow.ShowDialog();
            this.Show();
        }
    }
}
