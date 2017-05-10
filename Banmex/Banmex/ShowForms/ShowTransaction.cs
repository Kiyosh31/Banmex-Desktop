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
                    string today = date.ToString("yyyyMMdd");

                    //tomamos la fecha en que se hizo la transaccion para comparacion
                    string transactionDate = transactionGridView.CurrentRow.Cells[4].Value.ToString();

                    //comparamos las fechas para la cancelacion
                    if(today == transactionDate)
                    {
                        Connection.OpenConnection();
                        //si la cancelacion es el mismo dia se cancela la transaccion
                        Class.Transaction.deleteTransaction(Connection.myConnection, idTransaction);
                        Connection.CloseConnection();

                        MessageBox.Show("Eliminado exitosamente");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("El tiempo de cancelacion expiro");
                        this.Close();
                    }
                }
            }
        }
    }
}
