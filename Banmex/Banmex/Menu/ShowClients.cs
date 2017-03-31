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
    public partial class ShowClients : Form
    {
        Class.Connection Connection;

        public ShowClients(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;

            //Ajustar la tabla a la ventana
            clientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadData()
        {
            Connection.OpenConnection();
            clientsGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void ShowClients_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
