using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Banmex.Class
{
    public class Employee
    {
        private int idEmployee;
        private string firstName;
        private string lastName;
        private string address;
        private int cellphone;
        private string password;
        private int jobPosition;
        private bool active;

        public Employee(int idEmployee, string firstName, string lastName, string address, int cellphone, string password, int jobPosition, bool active)
        {
            this.idEmployee = idEmployee;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.cellphone = cellphone;
            this.password = password;
            this.jobPosition = jobPosition;
            this.active = active;
        }

        public int ID
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Cellphone
        {
            get { return cellphone; }
            set { cellphone = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int JobPosition
        {
            get { return jobPosition; }
            set { jobPosition = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }


        public static int addEmployee(MySqlConnection Connection, Employee newEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO employee(firstName, lastName, address, cellphone, password, position, active) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', {5}, true)", newEmployee.firstName, newEmployee.lastName, newEmployee.address, newEmployee.cellphone, newEmployee.password, newEmployee.jobPosition), Connection);

            /// if OK = 1 it's ok
            /// if OK = 0 error
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static Employee searchEmployee(MySqlConnection Connection, int idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE idEmployee = {0} AND active = true", idEmployee), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                return employee;
            }
            Employee e = null;
            return e;
        }

        public static int modifyEmployee(MySqlConnection Connection, Employee employee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET firstName = '{1}', lastName = '{2}', address = '{3}', cellphone = {4}, password = '{5}', position = {6}, active = true WHERE idEmployee = {0}", employee.ID ,employee.firstName, employee.lastName, employee.address, employee.cellphone, employee.password, employee.jobPosition), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int deleteEmployee(MySqlConnection Connection, string name)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET active = false WHERE idEmployee = '{0}'", name), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Employee> showAllEmployees(MySqlConnection Connection)
        {
            List<Employee> employeeList = new List<Employee>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetBoolean(7));
                employeeList.Add(employee);
            }

            return employeeList;
        }
    }
}
