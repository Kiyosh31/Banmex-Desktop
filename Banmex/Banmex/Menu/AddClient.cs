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
    public partial class AddClient : Form
    {
        //instancia de la clase conexion de la base de datos
        Class.Connection Connection = new Class.Connection();

        public AddClient(Class.Connection Connection)
        {
            InitializeComponent();

            //recibo por referencia la conexion a la base de datos
            this.Connection = Connection;

            //establecemos una minima cantidad inicial de la cuenta
            balanceTextBox.Text = "1000";

            //establecemos un limite estandar para la cuenta
            maximumCreditTextBox.Text = "50000";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //validacion, todos los campos deben estan llenos para poder ingresar
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneTextBox.Text == "" 
                || emailTextBox.Text == "" || addresTextBox.Text == "" || niptextBox.Text == "" 
                || balanceTextBox.Text == "" || maximumCreditTextBox.Text == "" || cutOffDayDateTimePicker.Value.ToString() == "" 
                || accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //validacion, el formato del email debe ser correcto
                if(IsValidEmail(emailTextBox.Text) == true)
                {
                    //se abre conexion a la db
                    Connection.OpenConnection();
                    //instanciamos un objeto cliente y le mandamos los datos de los campos
                    Class.Client client = new Class.Client(1, firstNameTextBox.Text, lastNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, addresTextBox.Text, true);
                    //ingresamos el nuevo cliente a la base de datos
                    Class.Client.addClient(Connection.myConnection, client);

                    //damos formato a la fecha de corte
                    string date = cutOffDayDateTimePicker.Value.ToString("yyyyMMdd");
                    //establecemos el tipo de cuenta que el usuario quiere
                    int accountType;
                    if(accountTypeComboBox.SelectedIndex == 0)
                    {
                        // 0 = Credito
                        accountType = 0;
                    }
                    else
                    {
                        // 1 = Debito
                        accountType = 1;
                    }
                    //conseguimos el id del cliente para asociarlo con la cuenta
                    int idClient = Class.Client.searchIdClient(Connection.myConnection, firstNameTextBox.Text);
                    //instanciamos un objeto account y le mandamos los datos de los campos
                    Class.Account account = new Class.Account(1, idClient, niptextBox.Text, float.Parse(balanceTextBox.Text), float.Parse(maximumCreditTextBox.Text), date, accountType, true);
                    //ingresamos la nueva cuenta a la db
                    Class.Account.addAccount(Connection.myConnection, account);
                    //cierra conexion a la db
                    Connection.CloseConnection();

                    MessageBox.Show("El cliente \nSe ingreso correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El formato del correo no es correcto");
                }
            }
        }

        //este metodo valida que el correo tenga un formato correcto, recibe el email a evaluar
        //retorna un valor booleano 
        //true = tiene el formato correcto
        //false = no tiene el formato correcto
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
