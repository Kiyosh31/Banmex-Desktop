using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.CancelForms
{
    public partial class CancelTransaction : Form
    {
        Class.Connection Connection;

        public CancelTransaction(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            canceledDataGriedView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadData()
        {
            Connection.OpenConnection();
            //se genera una lista con todos los clientes activos
            canceledDataGriedView.DataSource = Class.Transaction.showAllCanceled(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.canceledDataGriedView.Columns[0].HeaderCell.Value = "ID";
            this.canceledDataGriedView.Columns[1].HeaderCell.Value = "Cuenta origen";
            this.canceledDataGriedView.Columns[2].HeaderCell.Value = "Cuenta destino";
            this.canceledDataGriedView.Columns[3].HeaderCell.Value = "ID empleado";
            this.canceledDataGriedView.Columns[4].HeaderCell.Value = "Fecha";
            this.canceledDataGriedView.Columns[5].HeaderCell.Value = "Cantidad";
            this.canceledDataGriedView.Columns[6].HeaderCell.Value = "Tipo de cuenta";
            this.canceledDataGriedView.Columns[7].Visible = false;

            Connection.CloseConnection();
        }

        private void CancelTransaction_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(canceledDataGriedView.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia");
            }
            else
            {

            }
        }
    }
}
