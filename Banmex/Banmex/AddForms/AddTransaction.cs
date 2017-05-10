using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.AddForms
{
    public partial class AddTransaction : Form
    {
        Class.Connection Connection;
        int idEployee;

        public AddTransaction(Class.Connection Connection, int idEmployee)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idEployee = idEmployee;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            origenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            destinationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadOrigenData()
        {
            Connection.OpenConnection();

            //se genera una lista con todos los clientes activos
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

        private void loadDestinationData()
        {
            Connection.OpenConnection();

            //se genera una lista con todos los clientes activos
            destinationGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.destinationGridView.Columns[0].HeaderCell.Value = "ID";
            this.destinationGridView.Columns[1].HeaderCell.Value = "Nombre";
            this.destinationGridView.Columns[2].HeaderCell.Value = "Apellido";
            this.destinationGridView.Columns[3].Visible = false;
            this.destinationGridView.Columns[4].Visible = false;
            this.destinationGridView.Columns[5].Visible = false;
            this.destinationGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            loadOrigenData();
            loadDestinationData();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(origenDataGridView.Rows.Count == 0 || destinationGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else if(origenDataGridView.CurrentRow.Cells[0].Value == destinationGridView.CurrentRow.Cells[0].Value)
            {
                MessageBox.Show("No se puede transferir a la misma cuenta");
            }
            else if(quantityTextBox.Text == "" || accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //Abrimos conexion con la db
                Connection.OpenConnection();

                //tomamos el id del cliente origen
                string idOrigen = origenDataGridView.CurrentRow.Cells[0].Value.ToString();

                //tomamos el id del cliente destino
                string idDestination = destinationGridView.CurrentRow.Cells[0].Value.ToString();

                //establecemos el tipo de cuenta
                int type;
                if(accountTypeComboBox.SelectedIndex == 0)
                {
                    // 0 = Credito
                    type = 0;
                }
                else
                {
                    //1 = Debito
                    type = 1;
                }

                //establecemos la fecha de la transaccion
                DateTime today = DateTime.Today;
                string date = today.ToString("yyyyMMdd");

                //creamos el objeto de tipo transaccion
                Class.Transaction transaction = new Class.Transaction(1, Convert.ToInt32(idOrigen), Convert.ToInt32(idDestination), idEployee, date, float.Parse(quantityTextBox.Text), type, false);

                //intentamos ingresar a la db
                if(Class.Transaction.addTransaction(Connection.myConnection, transaction) == 1)
                {
                    //cerramos conexion
                    Connection.CloseConnection();


                }
            }
        }
    }
}
