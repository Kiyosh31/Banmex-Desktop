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
            Connection.CloseConnection();
        }

        private void ShowEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }



}
