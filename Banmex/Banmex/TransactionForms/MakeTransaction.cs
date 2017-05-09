using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banmex.Menu
{
    public partial class MakeTransaction : Form
    {
        Class.Connection Connection = new Class.Connection();
        int idEmployee;

        public MakeTransaction(Class.Connection Connection, int idEmployee)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idEmployee = idEmployee;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            origenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            destinationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadOrigenData()
        {
            //llenamos origenComboBox y destinationComboBox con los nombres de los clientes
            Connection.OpenConnection();
            //se genera una lista con todas las cuentas activas de los clientes
            origenDataGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.origenDataGridView.Columns[0].HeaderCell.Value = "ID";
            this.origenDataGridView.Columns[1].HeaderCell.Value = "Nombre";
            this.origenDataGridView.Columns[2].HeaderCell.Value = "Apellido";
            this.origenDataGridView.Columns[3].Visible = false;
            this.origenDataGridView.Columns[4].Visible = false;
            this.origenDataGridView.Columns[5].Visible = false;
            this.origenDataGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        public void loadDestinationData()
        {
            //llenamos origenComboBox y destinationComboBox con los nombres de los clientes
            Connection.OpenConnection();
            //se genera una lista con todas las cuentas activas de los clientes
            destinationDataGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.destinationDataGridView.Columns[0].HeaderCell.Value = "ID";
            this.destinationDataGridView.Columns[1].HeaderCell.Value = "Nombre";
            this.destinationDataGridView.Columns[2].HeaderCell.Value = "Apellido";
            this.destinationDataGridView.Columns[3].Visible = false;
            this.destinationDataGridView.Columns[4].Visible = false;
            this.destinationDataGridView.Columns[5].Visible = false;
            this.destinationDataGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        private void MakeTransaction_Load(object sender, EventArgs e)
        {
            loadOrigenData();
            loadDestinationData();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            if(quantityTextBox.Text == "" || accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if(origenDataGridView.Rows.Count == 0 && destinationDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Las tablas estan vacias");
            }
            else if(origenDataGridView.CurrentRow.Cells[0].Value == destinationDataGridView.CurrentRow.Cells[0].Value)
            {
                MessageBox.Show("No se puede transferir a la misma cuenta");
            }
            else
            {
                Connection.OpenConnection();

                //establecemos la fecha para la transaccion
                string date = DateTime.Now.ToString("yyyyMMdd");

                //convertimos los textbox a float
                float quantity = float.Parse(quantityTextBox.Text);

                //obtenemos el id del cliente
                string selectedOrigen = origenDataGridView.CurrentRow.Cells[0].Value.ToString();
                string selectedDestination = destinationDataGridView.CurrentRow.Cells[0].Value.ToString();

                //obtenemos el id de la cuenta a traves del id del cliente
                Class.Account origenAccount = Class.Account.searchIdAccount(Connection.myConnection, selectedOrigen);
                Class.Account destinationAccount = Class.Account.searchIdAccount(Connection.myConnection, selectedDestination);



                //validation de tipo de cuenta
                int accountType;
                if (accountTypeComboBox.SelectedIndex == 0)
                {
                    // 0 = Credito
                    accountType = 0;
                }
                else
                {
                    // 1 = Debito
                    accountType = 1;
                }

                //creamos un objeto de tipo transaction y le mandamos los valores
                Class.Transaction transaction = new Class.Transaction(1, 1, 1, idEmployee, date, quantity, accountType, false);
                //agregamos la transaccion a la base de datos
                Class.Transaction.addTransaction(Connection.myConnection, transaction);
                Connection.CloseConnection();
            }
        }

        
    }
}
