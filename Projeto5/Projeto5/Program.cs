using Projeto5.Entities;

namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {
     
            MyFile myFile = new MyFile("list.txt");

            myFile.AddValue("Maria Souza");
            myFile.AddValue("Pedro Oliveira");
            myFile.AddValue("Henrique Gusmão");
            myFile.AddValue("Ana Carolina");
            myFile.AddValue("Patrícia Rosa");
            myFile.AddValue("Gustavo Gouveia");
            myFile.AddValue("Daniel Albuquerque");
            myFile.AddValue("Renata Alves");
            myFile.AddValue("Kátia Guimarães");
            myFile.AddValue("Joao Silva");

            myFile.CreateFile();

            myFile.ShowData();

        }
    }
}