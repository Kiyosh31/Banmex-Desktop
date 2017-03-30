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

            loginButton.Enabled = false;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
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
                    
                    Class.Employee employee = Class.Employee.SearchEmployee(Connection.myConnection, userTextbox.Text);
                    Connection.CloseConnection();
                    AdminMenu adminWindow = new AdminMenu(employee);
                    this.Hide();
                    adminWindow.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sesion iniciada como cajero");
                    Connection.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("ID o Contraseña Incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.CloseConnection();
        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {
            if (userTextbox.Text == "")
            {
                loginButton.Enabled = false;
            }
            else if (passwordTextbox.Text != "")
            {
                loginButton.Enabled = true;
            }
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "")
            {
                loginButton.Enabled = false;
            }
            else if (userTextbox.Text != "")
            {
                loginButton.Enabled = true;
            }
        }
    }
}
