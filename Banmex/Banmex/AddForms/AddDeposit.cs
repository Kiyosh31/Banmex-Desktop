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
    public partial class AddDeposit : Form
    {
        Class.Connection Connection = new Class.Connection();
        int idEmployee;

        public AddDeposit(Class.Connection Connection, int idEmployee)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idEmployee = idEmployee;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            destinationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadData()
        {
            Connection.OpenConnection();
            //se genera una lista con todos los clientes activos
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

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

                MessageBox.Show("Favor de ingresar un dato valido");
            }
        }

        private void AddDeposit_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(destinationDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else if(quantityTextBox.Text == "" || nameTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                //id de la cuenta
                string idClient = destinationDataGridView.CurrentRow.Cells[0].Value.ToString();
                int idDestination = Class.Account.searchIdAccount(Connection.myConnection, idClient);
                Connection.CloseConnection();

                //fecha de hoy
                DateTime today = DateTime.Today;
                string date = today.ToString("yyyyMMdd");

                Connection.OpenConnection();
                Class.DepositWithoutAccount deposit = new Class.DepositWithoutAccount(1, idEmployee, idDestination, date, float.Parse(quantityTextBox.Text), nameTextBox.Text, false);
                Class.DepositWithoutAccount.addDeposit(Connection.myConnection, deposit);
                Connection.CloseConnection();

                MessageBox.Show("Deposito realizado con exito");
                this.Close();
            }
        }
    }
}
