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
using System.Text.RegularExpressions;

namespace Banmex.Menu
{
    public partial class AddClient : Form
    {
        //instancia de la clase conexion de la base de datos
        Class.Connection Connection = new Class.Connection();

        public AddClient(Class.Connection Connection)
        {
            InitializeComponent();

            //recibo por referencia la conexion a la base de datos
            this.Connection = Connection;
            
        }

        //este metodo obtiene el ultimo id ingresado de un cliente
        private int maxId()
        {
            //se declara el entero que sera el id del cliente
            int id = 1;

            try
            {
                //se abre conexion
                Connection.OpenConnection();

                //se declara un reader que tendra el id del cliente
                MySqlDataReader reader = Class.Client.clientMaxId(Connection.myConnection);

                //mientras se haga la consulta
                if (reader.Read())
                {
                    //se valida si la db esta vacia
                    if(!reader.IsDBNull(0))
                    {
                        //se establece el id del cliente a la variable
                        id = reader.GetInt32(0);
                    }
                }

                //se cierra conexion
                Connection.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el id");
            }

            //retornamos el id del cliente
            return id;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //validacion, todos los campos deben estan llenos para poder ingresar
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneTextBox.Text == "" 
                || emailTextBox.Text == "" || addresTextBox.Text == "" )
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                //validacion, el formato del email debe ser correcto
                if(IsValidEmail(emailTextBox.Text) == true)
                {
                    //se abre conexion a la db
                    Connection.OpenConnection();

                    //instanciamos un objeto cliente y le mandamos los datos de los campos
                    Class.Client client = new Class.Client(1, firstNameTextBox.Text, lastNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, addresTextBox.Text, true);
                    
                    //validacion si se ingreso el nuevo cliente a la base de datos
                    if(Class.Client.addClient(Connection.myConnection, client) == 1)
                    {
                        //cerrar conexion
                        Connection.CloseConnection();

                        //mensaje de exito
                        MessageBox.Show("Cliente \nIngresado Correctamente");

                        //obtenemos el id del cliente
                        string id = maxId().ToString();

                        //se abre la ventana para ingresar la cuenta
                        this.Hide();
                        AddAccount addAccountWindow = new AddAccount(Connection, id);
                        addAccountWindow.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //mensaje error
                        MessageBox.Show("Problemas al insertar al cliente");
                    }
                }
                else
                {
                    //mensaje error
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
    }
}
