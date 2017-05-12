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

namespace Banmex.ShowForms
{
    public partial class ShowDeposit : Form
    {
        Class.Connection Connection = new Class.Connection();

        public ShowDeposit(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            cancelDepositDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadData()
        {
            Connection.OpenConnection();
            //se genera una lista con todos los clientes activos
            cancelDepositDataGridView.DataSource = Class.DepositWithoutAccount.showAllDeposits(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.cancelDepositDataGridView.Columns[0].HeaderCell.Value = "ID Deposito";
            this.cancelDepositDataGridView.Columns[1].HeaderCell.Value = "Id Empleado";
            this.cancelDepositDataGridView.Columns[2].HeaderCell.Value = "Cuenta Destino";
            this.cancelDepositDataGridView.Columns[3].HeaderCell.Value = "Fecha de deposito";
            this.cancelDepositDataGridView.Columns[4].HeaderCell.Value = "Cantidad";
            this.cancelDepositDataGridView.Columns[5].HeaderCell.Value = "Nombre";
            this.cancelDepositDataGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        private void ShowDeposit_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(cancelDepositDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string idDeposit = cancelDepositDataGridView.CurrentRow.Cells[0].Value.ToString();

                    //comparamos la fecha de hoy con la fecha del deposito
                    //establecemos la fecha de hoy para comparacion
                    DateTime date = DateTime.Today;
                    string today = date.ToString("yyyyMMdd");


                    Connection.OpenConnection();
                    MySqlCommand command = new MySqlCommand(String.Format("SELECT * from DepositWithoutAccount WHERE idDepositWithoutAccount = '{0}' AND CancelTransaction = false", idDeposit), Connection.myConnection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.Read())
                    {
                        Class.DepositWithoutAccount deposit = new Class.DepositWithoutAccount(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetFloat(4), reader.GetString(5), reader.GetBoolean(6));
                        Connection.CloseConnection();

                        string depositDay = deposit.Date;

                        //validacion la fecha sea la misma para eliminar
                        //if(today == depositDay)
                        //{
                            //validacion del deposito a cancelar
                            //obtenga los fondos necesarios para regresar el dinero
                            if (haveBalance(deposit.DestinyAccount, deposit.Quantity))
                            {
                                MessageBox.Show("La cuenta no contiene el saldo necesario para esta transaccion");
                            }
                            else
                            {
                                Connection.OpenConnection();
                                Class.DepositWithoutAccount.deleteDeposit(Connection.myConnection, idDeposit);
                                Connection.CloseConnection();

                                MessageBox.Show("Eliminado exitosamente");
                                this.Close();
                            }
                        //}
                        //else
                        //{
                           // MessageBox.Show("La fecha de cancelacion expiro");
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
