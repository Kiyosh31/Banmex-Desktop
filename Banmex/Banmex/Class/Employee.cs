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
        private string phone;
        private string email;
        private string address;
        private string password;
        private int employeeType;
        private bool active;

        public Employee(int idEmployee, string firstName, string lastName, string phone, string email, string address, string password, int employeeType, bool active)
        {
            this.idEmployee = idEmployee;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.password = password;
            this.employeeType = employeeType;
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
        
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static int addEmployee(MySqlConnection Connection, Employee employee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO employee (FirstName, LastName, Phone, Email, Address, Password, EmployeeType, Active) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, true)", employee.firstName, employee.lastName, employee.phone, employee.email, employee.address, employee.password, employee.employeeType), Connection);
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
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7) ,reader.GetBoolean(8));
                return employee;
            }
            Employee e = null;
            return e;
        }

        public static int modifyEmployee(MySqlConnection Connection, Employee employee)
        {
            MySqlCommand command = new MySqlCommand(String.Format(
                "UPDATE employee SET firstName = '{1}', lastName = '{2}', phone = '{3}', email = {4}, address = '{5}', password = '{6}', employeeType = {6}, Active = true WHERE idEmployee = {0}", 
                employee.ID ,employee.firstName, employee.lastName, employee.phone, employee.email, employee.address, employee.password, employee.employeeType, true), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int deleteEmployee(MySqlConnection Connection, string idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET Active = false WHERE idEmployee = '{0}'", idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Employee> showAllEmployees(MySqlConnection Connection)
        {
            List<Employee> employeeList = new List<Employee>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE Active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7) ,reader.GetBoolean(8));
                employeeList.Add(employee);
            }

            return employeeList;
        }

        public static IList<Employee> showDeletedEmployees(MySqlConnection Connection)
        {
            List<Employee> employeeList = new List<Employee>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE Active = false"), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetBoolean(8));
                employeeList.Add(employee);
            }

            return employeeList;
        }

        public static int retrieveEmployee(MySqlConnection Connection, string idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET Active = true WHERE idEmployee = '{0}'", idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }
    }
}
