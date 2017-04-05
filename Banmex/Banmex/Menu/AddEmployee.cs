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
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneTextBox.Text == "" || 
                emailTextBox.Text == "" || addressTextBox.Text == "" || positionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                int position;
                if(positionComboBox.SelectedIndex == 0)
                {
                    // 0 = gerente
                    position = 0;
                }
                else
                {
                    //1 = empleado
                    position = 1;
                }

                Class.Employee newEmploye = new Class.Employee(1, firstNameTextBox.Text, lastNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, addressTextBox.Text, passwordTextBox.Text, position ,true);
                Class.Employee.addEmployee(Connection.myConnection, newEmploye);
                Connection.CloseConnection();

                MessageBox.Show("Cliente registrado\nExitosamente");
                this.Close();
            }
        }
    }
}
