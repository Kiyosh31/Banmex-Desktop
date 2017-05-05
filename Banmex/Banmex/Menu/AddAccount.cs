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
    public partial class AddAccount : Form
    {
        Class.Connection Connection = new Class.Connection();

        public AddAccount(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(niptextBox.Text == "" || balanceTextBox.Text == "" || maximumCreditTextBox.Text == "" 
                || cutOffDayDateTimePicker.Value.ToString() == "" || accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {

            }
        }
    }
}
