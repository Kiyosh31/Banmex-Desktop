using Banmex.Class;
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
    public partial class ManagerMenu : Form
    {
        Class.Connection Connection = new Class.Connection();

        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowEmployees EmployeesWindow = new ShowEmployees(Connection);
            EmployeesWindow.ShowDialog();
            this.Show();
        }

        private void showClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowClients ClientsWindow = new ShowClients(Connection);
            ClientsWindow.ShowDialog();
            this.Show();
        }
    }
}
