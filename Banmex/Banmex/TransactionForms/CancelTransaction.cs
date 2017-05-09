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
    public partial class CancelTransaction : Form
    {
        Class.Connection Connection = new Class.Connection();
        int idEmployee;

        public CancelTransaction(Class.Connection Connection, int idEmployee)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idEmployee = idEmployee;

            //Ajustar la tabla a la ventana
            canceltGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //metodo cargar todo en la tabla
        public void loadData()
        {
            Connection.OpenConnection();
            canceltGridView.DataSource = Class.Transaction.showAllCanceled(Connection.myConnection);

            this.canceltGridView.Columns[0].HeaderCell.Value = "ID";
            this.canceltGridView.Columns[1].HeaderCell.Value = "Cuenta Origen";
            this.canceltGridView.Columns[2].HeaderCell.Value = "Cuenta Destino";
            this.canceltGridView.Columns[3].HeaderCell.Value = "Id Empleado";
            this.canceltGridView.Columns[4].HeaderCell.Value = "Fecha";
            this.canceltGridView.Columns[5].HeaderCell.Value = "Cantidad";
            this.canceltGridView.Columns[6].HeaderCell.Value = "Tipo de cuenta";
            this.canceltGridView.Columns[7].Visible = false;

            Connection.CloseConnection();
        }

        private void CancelTransaction_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
