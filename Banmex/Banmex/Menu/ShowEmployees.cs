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
            //employesGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadData()
        {
            Connection.OpenConnection();
            MySqlDataAdapter da = Class.Employee.showAllEmployees(Connection.myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            employesGridview.DataSource = ds;
            employesGridview.DataMember = "employee";
            Connection.CloseConnection();
        }

        private void ShowEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }



}
