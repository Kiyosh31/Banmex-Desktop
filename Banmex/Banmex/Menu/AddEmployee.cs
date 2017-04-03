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
    public partial class AddEmployee : Form
    {
        Class.Connection Connection = new Class.Connection();

        public AddEmployee(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || addressTextBox.Text == "" || 
                cellphoneTextBox.Text == "" || passwordTextBox.Text == "" || positionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                int position;
                int cellphone = Int32.Parse(cellphoneTextBox.Text);
                if(positionComboBox.SelectedIndex == 0)
                {
                    position = 0;
                }
                else
                {
                    position = 1;
                }

                Class.Employee newEmploye = new Class.Employee(1, firstNameTextBox.Text, lastNameTextBox.Text, addressTextBox.Text, cellphone, passwordTextBox.Text, position, true);
                Class.Employee.addEmployee(Connection.myConnection, newEmploye);
                Connection.CloseConnection();

                MessageBox.Show("Cliente registrado\nExitosamente");
                this.Close();
            }
        }
    }
}
