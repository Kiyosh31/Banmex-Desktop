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
                //abrimos conexion con la db
                Connection.OpenConnection();

                //establecemos la fecha de corte
                string date = DateTime.Now.AddDays(15).ToString();

                //establecemos el tipo de cuenta que el usuario quiere
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

                //ingresamos la cuenta del cliente a la db
                Class.Account account = new Class.Account(1, Int32.Parse(idClient), niptextBox.Text, float.Parse(balanceTextBox.Text), float.Parse(maximumCreditTextBox.Text), date, accountType, true);
                
                //ingresamos la nueva cuenta a la db
                Class.Account.addAccount(Connection.myConnection, account);
                
                //cierra conexion a la db
                Connection.CloseConnection();

                MessageBox.Show("La cuenta \nSe ingreso correctamente");
                this.Close();
            }
        }
    }
}
