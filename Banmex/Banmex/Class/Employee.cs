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
        private int jobPosition;
        private bool active;

        public Employee(int idEmployee, string firstName, string lastName, int jobPosition, bool active)
        {
            this.idEmployee = idEmployee;
            this.firstName = firstName;
            this.lastName = lastName;
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

        public int JobPosotion
        {
            get { return jobPosition; }
            set { jobPosition = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static Employee SearchEmployee(MySqlConnection Connection, string firstName)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE firstName = {0} AND active = 1", firstName), Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetBoolean(4));
                return employee;
            }
            Employee e = null;
            return e;
        }

        public static MySqlDataAdapter showAllEmployees(MySqlConnection connection)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT idEmployee as ID, firstName as Nombre, lastName as Apellido, address as Domicilio, cellphone as Celular, position as Puesto", connection);
            return da;
        }
    }
}
