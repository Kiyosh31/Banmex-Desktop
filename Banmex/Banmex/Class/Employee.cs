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
