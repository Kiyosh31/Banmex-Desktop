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
            cuttOfDayDateTimePicker.Value = Convert.ToDateTime(account.CutOffDay);
            if (account.AccountType == 0)
            {
                accountTypeComboBox.Text = "Credito";
            }
            else
            {
                accountTypeComboBox.Text = "Debito";
            }
            //cierra conexion a la db
            Connection.CloseConnection();
        }
    }
}
