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

        public CashierMenu(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
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
            MakeTransaction transactionWindow = new MakeTransaction(Connection);
            transactionWindow.ShowDialog();
            this.Show();
        }
    }
}
