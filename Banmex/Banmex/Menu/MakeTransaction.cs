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

        public MakeTransaction(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }

        public void loadData()
        {
            //llenamos origenComboBox y destinationComboBox con los nombres de los clientes
            Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * from Client WHERE Active = true"), Connection.myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                origenComboBox.Items.Add(reader.GetString("FirstName"));
                destinationComboBox.Items.Add(reader.GetString("FirstName"));
            }
            Connection.CloseConnection();
        }

        private void MakeTransaction_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            if(origenComboBox.SelectedItem == null || destinationComboBox.SelectedItem == null || 
                quantityTextBox.Text == "" || accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                //establecemos la fecha para la transaccion
                string date = DateTime.Now.ToString("yyyyMMdd");

                //convertimos los textbox a float
                float quantity = float.Parse(quantityTextBox.Text);

                //validacion que no se transfiera a la misma cuenta
                if(origenComboBox.SelectedItem == destinationComboBox.SelectedItem)
                {
                    MessageBox.Show("No se puede transferir a la misma cuenta");
                }
                else
                {
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
                    Class.Transaction transaction = new Class.Transaction(1, 2, 3, 4, date, quantity, accountType, false);
                    //agregamos la transaccion a la base de datos
                    Class.Transaction.addTransaction(Connection.myConnection, transaction);
                }
                Connection.CloseConnection();
            }
        }

        
    }
}
