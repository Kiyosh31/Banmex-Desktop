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
    public partial class ModifyEmployee : Form
    {
        Class.Connection Connection = new Class.Connection();

        string idEmployee;

        public ModifyEmployee(Class.Connection Connection, string idEmployee)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idEmployee = idEmployee;

            idTextBox.Enabled = false;
        }

        private void ModifyEmployee_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            int id = Int32.Parse(idEmployee);
            Class.Employee employee = Class.Employee.searchEmployee(Connection.myConnection, id);
            Connection.CloseConnection();

            idTextBox.Text = employee.ID.ToString();
            firstNameTextBox.Text = employee.FirstName;
            lastNameTextBox.Text = employee.LastName;
            addresTextBox.Text = employee.Address;
            cellphoneTextBox.Text = Convert.ToString(employee.Cellphone);
            passwordTextBox.Text = employee.Password;

            if (employee.JobPosition == 0)
            {
                positionComboBox.Text = "Gerente";
            }
            else
            {
                positionComboBox.Text = "Cajero";
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || addresTextBox.Text == "" || cellphoneTextBox.Text == ""
                || passwordTextBox.Text == "" || positionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                int position;
                int cellphone;
                cellphone = Int32.Parse(cellphoneTextBox.Text);

                if (positionComboBox.Text == "Gerente")
                {
                    position = 0;
                }
                else
                {
                    position = 1;
                }

                Class.Employee employee = new Class.Employee(int.Parse(idEmployee), firstNameTextBox.Text, lastNameTextBox.Text, addresTextBox.Text, cellphone, passwordTextBox.Text, position, true);
                Class.Employee.modifyEmployee(Connection.myConnection, employee);
                Connection.CloseConnection();

                MessageBox.Show("Modificado exitosamente");
                this.Close();
            }
        }
    }
}
