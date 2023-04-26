using System.Globalization;

namespace Projeto5.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] items = csvEmployee.Split(", ");
            Name = items[0];
            Salary = double.Parse(items[1], CultureInfo.InvariantCulture);
        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparison Error: object is not an Employee");
            }

            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
