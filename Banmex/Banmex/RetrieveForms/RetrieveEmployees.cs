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
    public partial class RetrieveEmployees : Form
    {
        Class.Connection Connection;

        public RetrieveEmployees(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;

            //Ajustar la tabla a la ventana
            employesGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //desactivamos la opcion de eliminar completamente
            deleteDefinitely.Visible = false;
        }

        public void loadData()
        {
            Connection.OpenConnection();
            employesGridview.DataSource = Class.Employee.showDeletedEmployees(Connection.myConnection);

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

        private void RetrieveEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            if(employesGridview.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea restaurar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string idEmployee = employesGridview.CurrentRow.Cells[0].Value.ToString();
                    Connection.OpenConnection();
                    Class.Employee.retrieveEmployee(Connection.myConnection, idEmployee);
                    Connection.CloseConnection();

                    MessageBox.Show("Restaurado exitosamente");
                    loadData();
                }
            }
        }

        private void deleteDefinitely_Click(object sender, EventArgs e)
        {
            if (employesGridview.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string idEmployee = employesGridview.CurrentRow.Cells[0].Value.ToString();
                    Connection.OpenConnection();
                    Class.Employee.deleteDefinetly(Connection.myConnection, idEmployee);
                    Connection.CloseConnection();

                    MessageBox.Show("Eliminado Exitosamente");
                    loadData();
                }
            }
        }
    }
}
