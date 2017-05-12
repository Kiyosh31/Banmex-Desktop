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
    public partial class ShowTransaction : Form
    {
        Class.Connection Connection = new Class.Connection();

        public ShowTransaction(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;

            //Ajustar la tabla a la ventana
            transactionGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //metodo cargar todo en la tabla
        public void loadData()
        {
            Connection.OpenConnection();
            transactionGridView.DataSource = Class.Transaction.showAllTransactions(Connection.myConnection);

            this.transactionGridView.Columns[0].HeaderCell.Value = "ID";
            this.transactionGridView.Columns[1].HeaderCell.Value = "Cuenta Origen";
            this.transactionGridView.Columns[2].HeaderCell.Value = "Cuenta Destino";
            this.transactionGridView.Columns[3].HeaderCell.Value = "Id Empleado";
            this.transactionGridView.Columns[4].HeaderCell.Value = "Fecha";
            this.transactionGridView.Columns[5].HeaderCell.Value = "Cantidad";
            this.transactionGridView.Columns[6].HeaderCell.Value = "Tipo de cuenta";
            this.transactionGridView.Columns[7].Visible = false;

            Connection.CloseConnection();
        }

        private void ShowTransaction_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //boton para la cencalacion de las transacciones
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //validacion si la tabla esta vacia
            if(transactionGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    //tomamos el id de la transaccion
                    string idTransaction = transactionGridView.CurrentRow.Cells[0].Value.ToString();

                    //establecemos la fecha de hoy para comparacion
                    DateTime date = DateTime.Today;
                    string today = date.ToString("dd/MM/yyyy");

                    //abrimos conexion
                    Connection.OpenConnection();
                    //generamos el query
                    MySqlCommand command = new MySqlCommand(String.Format("SELECT * from Transaction WHERE idTransaction = '{0}' AND CancelTransaction = false", idTransaction), Connection.myConnection);
                    MySqlDataReader reader = command.ExecuteReader();

                    //si existe el registro
                    if(reader.Read())
                    {
                        //creamos un objeto de tipo transaccion
                        Class.Transaction transaction = new Class.Transaction(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetFloat(5), reader.GetInt32(6), reader.GetBoolean(7));
                        //cerramos conexion
                        Connection.CloseConnection();

                        string transactionDate = transaction.Date;

                        //comparamos las fechas para la cancelacion
                        //if (today == transactionDate)
                        //{
                            //validacion de la cuenta a cancelar
                            //obtenga los fondos necesarios para regresar el dinero
                            if(haveBalance(transaction.OrigenAccount, transaction.Quantity))
                            {
                                MessageBox.Show("La cuenta no contiene el saldo necesario para esta transaccion");
                            }
                            else
                            {
                                Connection.OpenConnection();
                                //si la cancelacion es el mismo dia se cancela la transaccion
                                Class.Transaction.deleteTransaction(Connection.myConnection, idTransaction);
                                Connection.CloseConnection();

                                MessageBox.Show("Eliminado exitosamente");
                                this.Close();
                            }
                        //}
                       // else
                        //{
                            //MessageBox.Show("El tiempo de cancelacion expiro");
                            //this.Close();
                        //}
                    }
                }
            }
        }

        private bool haveBalance(int idAccount, float money)
        {
           bool answer = false;

            try
            {
                Connection.OpenConnection();
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * from Account WHERE idAccount = '{0}' AND Active = true", idAccount), Connection.myConnection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Class.Account account = new Class.Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                    Connection.CloseConnection();

                    if (account.Balance < money)
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                }
            }
            catch (Exception)
            {
                //exception
            }

            return answer;
        }
    }
}
