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
        Class.Connection Connection = new Class.Connection();

        public AddClient(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneTextBox.Text == "" || emailTextBox.Text == "" || addresTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();

                Class.Client client = new Class.Client(1, firstNameTextBox.Text, lastNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, addresTextBox.Text, true);
                Class.Client.addClient(Connection.myConnection, client);
                Connection.CloseConnection();

                MessageBox.Show("Cliente registrado\nExitosamente");
                this.Close();
            }
        }
    }
}
