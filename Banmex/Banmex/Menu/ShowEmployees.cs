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
    public partial class ShowEmployees : Form
    {
        Class.Connection Connection;

        public ShowEmployees(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;

            //Ajustar la tabla a la ventana
            employesGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadData()
        {
            Connection.OpenConnection();
            employesGridview.DataSource = Class.Employee.showAllEmployees(Connection.myConnection);

            this.employesGridview.Columns[0].HeaderCell.Value = "ID";
            this.employesGridview.Columns[1].HeaderCell.Value = "Nombre";
            this.employesGridview.Columns[2].HeaderCell.Value = "Apellido";
            this.employesGridview.Columns[3].HeaderCell.Value = "Teléfono";
            this.employesGridview.Columns[4].HeaderCell.Value = "Correo";
            this.employesGridview.Columns[5].HeaderCell.Value = "Direccion";
            this.employesGridview.Columns[6].HeaderCell.Value = "Contraseña";
            this.employesGridview.Columns[7].HeaderCell.Value = "Tipo Empleado";
            this.employesGridview.Columns[8].Visible = false;

            Connection.CloseConnection();
        }

        private void ShowEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string idEmployee = employesGridview.CurrentRow.Cells[0].Value.ToString();
            ModifyEmployee modWindow = new ModifyEmployee(Connection, idEmployee);
            modWindow.ShowDialog();
            loadData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                string idEmployee = employesGridview.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Employee.deleteEmployee(Connection.myConnection, idEmployee);
                Connection.CloseConnection();

                MessageBox.Show("Eliminado exitosamente");
                loadData();
            }
        }
    }
}
