using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                if(IsValidEmail(emailTextBox.Text) == true)
                {
                    Connection.OpenConnection();
                    int position;
                    if (positionComboBox.SelectedIndex == 0)
                    {
                        // 0 = gerente
                        position = 0;
                    }
                    else
                    {
                        //1 = empleado
                        position = 1;
                    }

                    Class.Employee newEmploye = new Class.Employee(1, firstNameTextBox.Text, lastNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, addressTextBox.Text, passwordTextBox.Text, position, true);
                    Class.Employee.addEmployee(Connection.myConnection, newEmploye);
                    Connection.CloseConnection();

                    MessageBox.Show("Empleado registrado\nExitosamente");
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
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

                MessageBox.Show("Favor de ingresar un dato valido");
            }
        }
    }
}
