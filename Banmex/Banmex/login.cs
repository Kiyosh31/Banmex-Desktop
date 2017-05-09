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

        private void loginButton_Click(object sender, EventArgs e)
        {
            //validacion: todos los campos deben estar llenos
            if(userTextbox.Text == "" || passwordTextbox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //abre conexion a la db
                Connection.OpenConnection();
                //busco el nombre y la contraseña en la db 
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * from Employee WHERE FirstName = '{0}' AND Password = '{1}' AND Active  = true", userTextbox.Text, passwordTextbox.Text), Connection.myConnection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //el reader lo ponemos de la forma de employee
                    Class.Employee myEmployee = new Class.Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetBoolean(8));

                    //si coinciden los campos con la informacion del gerente entra aqui
                    if (myEmployee.EmployeeType == 0)
                    {
                        Connection.CloseConnection();
                        MessageBox.Show("Sesion iniciada como admin");

                        //se inicializa el menu del gerente
                        this.Hide();
                        //obtengo el id del empleado y lo mando 
                        ManagerMenu ManagerWindow = new ManagerMenu(Connection, myEmployee.IdEmployee);
                        ManagerWindow.ShowDialog();
                        this.Close();
                    }
                    else if(myEmployee.EmployeeType == 1)
                    {
                        //si coinciden los datos con la informacion del cajero entra aqui
                        MessageBox.Show("Sesion iniciada como cajero");
                        Connection.CloseConnection();
                        CashierMenu CashierWIndow = new CashierMenu(Connection, myEmployee.IdEmployee);
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
    }
}
