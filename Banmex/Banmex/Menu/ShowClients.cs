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
    public partial class ShowClients : Form
    {
        Class.Connection Connection;

        public ShowClients(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            clientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountdGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadClientsData()
        {
            Connection.OpenConnection();
            clientsGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            this.clientsGridView.Columns[0].HeaderCell.Value = "ID";
            this.clientsGridView.Columns[1].HeaderCell.Value = "Nombre";
            this.clientsGridView.Columns[2].HeaderCell.Value = "Apellido";
            this.clientsGridView.Columns[3].HeaderCell.Value = "Teléfono";
            this.clientsGridView.Columns[4].HeaderCell.Value = "Correo";
            this.clientsGridView.Columns[5].HeaderCell.Value = "Dirección";
            this.clientsGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        public void loadAccountsData()
        {
            Connection.OpenConnection();
            accountdGridView.DataSource = Class.Account.showAllAccounts(Connection.myConnection);

            this.accountdGridView.Columns[0].HeaderCell.Value = "ID Cuenta";
            this.accountdGridView.Columns[1].HeaderCell.Value = "ID Cliente";
            this.accountdGridView.Columns[2].HeaderCell.Value = "NIP";
            this.accountdGridView.Columns[3].HeaderCell.Value = "Saldo";
            this.accountdGridView.Columns[4].HeaderCell.Value = "Credito Maximo";
            this.accountdGridView.Columns[5].HeaderCell.Value = "Dia de corte";
            this.accountdGridView.Columns[6].HeaderCell.Value = "Tipo de cuenta";
            this.accountdGridView.Columns[7].Visible = false;

            Connection.CloseConnection();
        }

        private void ShowClients_Load(object sender, EventArgs e)
        {
            loadClientsData();
            loadAccountsData();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();
            ModifyClient modWindow = new ModifyClient(Connection, idClient);
            modWindow.ShowDialog();
            loadClientsData();
            loadAccountsData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Client.deleteClient(Connection.myConnection, idClient);
                Connection.CloseConnection();

                MessageBox.Show("Eliminado exitosamente");
                loadClientsData();
                loadAccountsData();
            }
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();
            AddAccount addAccount = new AddAccount(Connection, idClient);
            addAccount.ShowDialog();
            loadClientsData();
            loadAccountsData();
        }

        private void modifyAccountButton_Click(object sender, EventArgs e)
        {
            string idClient = accountdGridView.CurrentRow.Cells[0].Value.ToString();
            ModifyAccount modWindow = new ModifyAccount(Connection, idClient);
            modWindow.ShowDialog();
            loadClientsData();
            loadAccountsData();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                string idAccount = accountdGridView.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Account.deleteAccount(Connection.myConnection, idAccount);
                Connection.CloseConnection();

                MessageBox.Show("Eliminado exitosamente");
                loadClientsData();
                loadAccountsData();
            }
        }
    }
}
