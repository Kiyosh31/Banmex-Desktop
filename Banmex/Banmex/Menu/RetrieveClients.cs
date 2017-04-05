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
    public partial class RetrieveClients : Form
    {
        Class.Connection Connection;

        public RetrieveClients(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;

            //Ajustar la tabla a la ventana
            clientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadData()
        {
            Connection.OpenConnection();
            clientsGridView.DataSource = Class.Client.showDeletedClients(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void RetrieveClients_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea restaurar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Employee.retrieveEmployee(Connection.myConnection, idClient);
                Connection.CloseConnection();

                MessageBox.Show("Restaurado exitosamente");
                loadData();
            }
        }        
    }
}
