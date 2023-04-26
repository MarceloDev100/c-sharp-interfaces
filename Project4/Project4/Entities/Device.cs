namespace Project4.Entities
{
    abstract class Device
    {
        public string SerialNumber { get; set; }
        public abstract void ProcessDoc(string doc);
    }
}
