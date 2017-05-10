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

        //metodo para cargar todos los datos a la tabla
        public void loadClientsData()
        {
            Connection.OpenConnection();
            //se genera una lista con todos los clientes activos
            clientsGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
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
            //se genera una lista con todos los clientes activos
            accountdGridView.DataSource = Class.Account.showAllAccounts(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.accountdGridView.Columns[0].HeaderCell.Value = "ID Cuenta";
            this.accountdGridView.Columns[1].HeaderCell.Value = "ID Cliente";
            this.accountdGridView.Columns[2].HeaderCell.Value = "Nip";
            this.accountdGridView.Columns[3].HeaderCell.Value = "Saldo";
            this.accountdGridView.Columns[4].HeaderCell.Value = "Credito Maximo";
            this.accountdGridView.Columns[5].HeaderCell.Value = "Dia de corte";
            this.accountdGridView.Columns[6].HeaderCell.Value = "Tipo de cuenta";
            this.accountdGridView.Columns[7].Visible = false;

            Connection.CloseConnection();
        }

        //metodo de carga de las tablas cuado se abre la ventana
        private void ShowClients_Load(object sender, EventArgs e)
        {
            loadClientsData();
            loadAccountsData();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            //validacion para la tabla clientes
            //si la tabla esta vacia mostrar mensaje de error
            if (clientsGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {
                //se toma el id del cliente
                string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();
                //se manda al metodo modificar con el id
                ModifyClient modWindow = new ModifyClient(Connection, idClient);
                //se muestra la ventana con los datos
                modWindow.ShowDialog();
                //se recargan las tablas cuando regresa a esta ventana
                loadClientsData();
                loadAccountsData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(clientsGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
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
            //validacion para la tabla clientes
            //si la tabla esta vacia mostrar mensaje de error
            if (accountdGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {
                string idClient = accountdGridView.CurrentRow.Cells[0].Value.ToString();
                ModifyAccount modWindow = new ModifyAccount(Connection, idClient);
                modWindow.ShowDialog();
                loadClientsData();
                loadAccountsData();
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            //validacion para la tabla clientes
            //si la tabla esta vacia mostrar mensaje de error
            if (accountdGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
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
}
