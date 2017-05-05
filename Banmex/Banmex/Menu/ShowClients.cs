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

            //Ajustar la tabla a la ventana
            clientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadData()
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

        private void ShowClients_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();
            ModifyClient modWindow = new ModifyClient(Connection, idClient);
            modWindow.ShowDialog();
            loadData();
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
                loadData();
            }
        }
    }
}
