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
    public partial class ModifyAccount : Form
    {
        Class.Connection Connection;
        string idAccount;

        public ModifyAccount(Class.Connection Connection, string idAccount)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idAccount = idAccount;

            //idCuenta e idCliente textbox seran bloqueadas para evitar su modificacion
            idAccountTextBox.Enabled = false;
            idClientTextBox.Enabled = false;
            cutOffDayDateTimePicker.Enabled = false;
        }


        //metodo cargar de la pagina
        private void ModifyAccount_Load(object sender, EventArgs e)
        {
            //se abre conexion a la db
            Connection.OpenConnection();

            //metodo que busca la cuenta por id
            Class.Account account = Class.Account.searchAccount(Connection.myConnection, idAccount);

            //establecemos los datos en sus respectivos campos para su modificacion
            idAccountTextBox.Text = Convert.ToString(account.IdAccount);
            idClientTextBox.Text = Convert.ToString(account.Client_IdClient);
            nipTextBox.Text = account.Nip;
            balancetextBox.Text = Convert.ToString(account.Balance);
            maximumCreditTextBox.Text = Convert.ToString(account.MaximumCredit);
            cutOffDayDateTimePicker.Text = Convert.ToString(account.CutOffDay);

            if(account.AccountType == 0)
            {
                accountTypeComboBox.SelectedItem = "Credito";
            }
            else
            {
                accountTypeComboBox.SelectedItem = "Debito";
            }

            //cierra conexion a la db
            Connection.CloseConnection();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(nipTextBox.Text == "" || balancetextBox.Text == "" || maximumCreditTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                int type;
                if (accountTypeComboBox.SelectedIndex == 0)
                {
                    // 0 = credito
                    type = 0;
                }
                else
                {
                    // 1 = debito
                    type = 1;
                }

                string cutOffDay = cutOffDayDateTimePicker.Text; 

                Connection.OpenConnection();
                Class.Account account = new Class.Account(Convert.ToInt32(idAccountTextBox.Text), Convert.ToInt32(idClientTextBox.Text), nipTextBox.Text, float.Parse(balancetextBox.Text), float.Parse(maximumCreditTextBox.Text), cutOffDay, type, true);
                Class.Account.modifyAccount(Connection.myConnection, account);
                Connection.CloseConnection();

                MessageBox.Show("Modificado exitosamente");
                this.Close();
            }
        }
    }
}
