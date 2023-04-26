namespace Project4.Entities
{
    class Printer : Device
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }

        public void Print(string doc)
        {
            Console.WriteLine("Printer print " + doc);
        }
    }
}
