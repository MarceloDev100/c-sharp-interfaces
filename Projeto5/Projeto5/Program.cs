using Projeto5.Entities;

namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {
     
            MyEmployeeFile myFile = new MyEmployeeFile("list.csv");

            myFile.AddEmployee(new Employee("Maria souza", 4300.00));
            myFile.AddEmployee(new Employee("Pedro Oliveira", 2700.00));
            myFile.AddEmployee(new Employee("Henrique Gusmão", 1500.00));
            myFile.AddEmployee(new Employee("Ana Carolina", 2100.00));
            myFile.AddEmployee(new Employee("Patrícia Rosa", 8200.00));
            myFile.AddEmployee(new Employee("Gustavo Gouveia", 3500.00));
            myFile.AddEmployee(new Employee("Daniel Albuquerque", 1200.00));
            myFile.AddEmployee(new Employee("Renata Alves", 4000.00));
            myFile.AddEmployee(new Employee("Kátia Guimarães", 6420.00));
            myFile.AddEmployee(new Employee("Joao Silva", 5700.00));

            myFile.CreateFile();

            myFile.ShowData();

        }
    }
}