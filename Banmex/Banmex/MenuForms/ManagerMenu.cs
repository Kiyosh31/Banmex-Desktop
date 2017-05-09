﻿using Banmex.Class;
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
        int idEmployee;

        public ManagerMenu(Class.Connection Connection, int idEmployee)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idEmployee = idEmployee;
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowEmployees EmployeesWindow = new ShowEmployees(Connection);
            EmployeesWindow.ShowDialog();
            this.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addWindow = new AddEmployee(Connection);
            addWindow.ShowDialog();
            this.Show();
        }

        private void showClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowClients ClientsWindow = new ShowClients(Connection);
            ClientsWindow.ShowDialog();
            this.Show();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient addWindow = new AddClient(Connection);
            addWindow.ShowDialog();
            this.Show();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RetrieveEmployees retrieveWindow = new RetrieveEmployees(Connection);
            retrieveWindow.ShowDialog();
            this.Show();
        }

        private void retrieveClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RetrieveClients retrieveWindow = new RetrieveClients(Connection);
            retrieveWindow.ShowDialog();
            this.Show();
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeTransaction transactionWindow = new MakeTransaction(Connection, idEmployee);
            transactionWindow.ShowDialog();
            this.Show();
        }

        private void cancelTransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelTransaction cancelWindow = new CancelTransaction(Connection, idEmployee);
            cancelWindow.ShowDialog();
            this.Show();
        }

        private void showTransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowTransaction showTransactionWindow = new ShowTransaction(Connection);
            showTransactionWindow.ShowDialog();
            this.Show();
        }
    }
}