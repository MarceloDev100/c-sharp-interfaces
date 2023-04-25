using Project2.Entities;
using Project2.Services;
using System.Globalization;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessInstallments(contract, months);
            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}