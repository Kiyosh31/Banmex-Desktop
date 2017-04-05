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
        }

        public void loadData()
        {
            Connection.OpenConnection();
            employesGridview.DataSource = Class.Employee.showDeletedEmployees(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void RetrieveEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
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
}
