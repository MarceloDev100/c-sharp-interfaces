using Project1.Entities;
using System.Globalization;
using Project1.Services;

namespace Project1
{
    class Program
    {
        /* Solution without using interface here */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            /*
             A RentalService class is instantiated by passing it the desired dependency (BrazilTaxService concret class).
             BrazilTaxService will match TaxService in constructor via upcasting.
             */
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}