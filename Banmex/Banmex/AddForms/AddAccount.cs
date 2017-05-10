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
    public partial class AddAccount : Form
    {
        Class.Connection Connection = new Class.Connection();
        string idClient;


        public AddAccount(Class.Connection Connection, string idClient)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idClient = idClient;

            //establecemos un saldo minimo para la apertura de la cuenta
            balanceTextBox.Text = "1000";

            //establemos un credito maximo para la cuenta
            maximumCreditTextBox.Text = "50000";
            
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            if(niptextBox.Text == "" || balanceTextBox.Text == "" || maximumCreditTextBox.Text == "" 
                 || accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //abrir conexion de la db
                Connection.OpenConnection();

                //establecemos la fecha de corte
                DateTime today = DateTime.Today;
                DateTime cutOffDay = today.AddDays(15);
                string date = today.ToString("yyyyMMdd");

                //establemos el tipo de cliente que sera 
                int accountType;
                if(accountTypeComboBox.SelectedIndex == 0)
                {
                    //0 = Credito
                    accountType = 0;
                }
                else
                {
                    //1 = debito
                    accountType = 1;
                }

                Class.Account account = new Class.Account(1, Int32.Parse(idClient), niptextBox.Text, float.Parse(balanceTextBox.Text), float.Parse(maximumCreditTextBox.Text), date, accountType, true);

                if(Class.Account.addAccount(Connection.myConnection, account) == 1)
                {
                    //Cerrar conexion con db
                    Connection.CloseConnection();

                    //Mensaje de exito
                    MessageBox.Show("Cuenta registrada con exito");
                    this.Close();
                }   
            }
        }

        //evento keypress el textbox solo acepta numeros
        private void niptextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

                MessageBox.Show("Favor de ingresar un dato valido");
            }
        }

        private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

                MessageBox.Show("Favor de ingresar un dato valido");
            }
        }

        private void maximumCreditTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
