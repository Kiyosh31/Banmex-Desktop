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
using Banmex.Menu;

namespace Banmex
{
    public partial class login : Form
    {
        Class.Connection Connection = new Class.Connection();

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userTextbox.Text == "" || passwordTextbox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * from employee WHERE firstName = '{0}' AND password = '{1}'", userTextbox.Text, passwordTextbox.Text), Connection.myConnection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetInt32(6) == 0)
                    {
                        Connection.CloseConnection();
                        Connection.OpenConnection();
                        //Class.Employee employee = Class.Employee.SearchEmployee(Connection.myConnection, userTextbox.Text);
                        Connection.CloseConnection();
                        MessageBox.Show("Sesion iniciada como admin");
                        ManagerMenu ManagerWindow = new ManagerMenu(Connection);
                        this.Hide();
                        ManagerWindow.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sesion iniciada como cajero");
                        Connection.CloseConnection();
                        CashierMenu CashierWIndow = new CashierMenu(Connection);
                        this.Hide();
                        CashierWIndow.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ID o Contraseña Incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Connection.CloseConnection();
            }
        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
