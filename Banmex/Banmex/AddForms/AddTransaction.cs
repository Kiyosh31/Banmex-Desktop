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
                MessageBox.Show("Las tablas estan vacias");
            }
            else if(origenDataGridView.CurrentRow.Cells[0].Value.ToString() == destinationGridView.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("No se puede transferir a la misma cuenta");
            }
            else if(quantityTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //Abrimos conexion con la db
                Connection.OpenConnection();
                //tomamos el id del cliente origen
                string idOrigenClient = origenDataGridView.CurrentRow.Cells[0].Value.ToString();
                //obtenemos el id de la cuenta
                int idOrigen = Class.Account.searchIdAccount(Connection.myConnection, idOrigenClient);
                //cerramos la conexion a la db
                Connection.CloseConnection();


                //abrimos conexion a db
                Connection.OpenConnection();
                //tomamos el id del cliente destino
                string idDestinationClient = destinationGridView.CurrentRow.Cells[0].Value.ToString();
                //obtenemos el id de la cuenta
                int idDestination = Class.Account.searchIdAccount(Connection.myConnection, idDestinationClient);
                //ceramos conexion a db
                Connection.CloseConnection();

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

                //abrimos conexion
                Connection.OpenConnection();
                //realizamos el query para la cuenta
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * from Account WHERE idAccount = '{0}' AND Active  = true", idOrigen), Connection.myConnection);
                MySqlDataReader reader = command.ExecuteReader();

                //si la cuenta existe entramos
                if(reader.Read())
                {
                    //se genera un objeto de tipo cuenta con todos los datos de la cuenta origen
                    Class.Account valAccount = new Class.Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                    //se cierra la conexion
                    Connection.CloseConnection();

                    //validacion si el saldo de la cuenta es menor a la cantidad se genera un mensaje de error
                    if(valAccount.Balance < Convert.ToInt32(quantityTextBox.Text))
                    {
                        MessageBox.Show("La cuenta origen no tiene el saldo suficiente");
                    }
                    else
                    {
                        //abrimos conexion a db
                        Connection.OpenConnection();
                        //establecemos la fecha de la transaccion
                        DateTime today = DateTime.Today;
                        string date = today.ToString("yyyyMMdd");

                        //creamos el objeto de tipo transaccion
                        Class.Transaction transaction = new Class.Transaction(1, idOrigen, idDestination, idEployee, date, float.Parse(quantityTextBox.Text), type, false);

                        //intentamos ingresar a la db
                        if (Class.Transaction.addTransaction(Connection.myConnection, transaction) == 1)
                        {
                            //cerramos conexion
                            Connection.CloseConnection();

                            MessageBox.Show("Se ha transferido el dinero");
                            this.Close();
                        }
                    }
                }
            }
        }

        //metodo validacion ingreso solo numeros
        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

                MessageBox.Show("Favor de ingresar un dato valido");
            }
        }
    }
}
