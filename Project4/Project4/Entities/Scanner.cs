namespace Project4.Entities
{
    class Scanner : Device
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
