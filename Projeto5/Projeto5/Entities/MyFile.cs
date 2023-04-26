namespace Projeto5.Entities
{
    class MyFile
    {
        public string Name { get; private set; }
        public List<string> Data { get; private set; }
        static public string CurrentDirectory { get; private set; }
        static public string ProjectDirectory { get; private set; }

        public MyFile(string name)
        {
            Name = name;
            Data = new List<string>();
            CurrentDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
            ProjectDirectory = Directory.GetParent(CurrentDirectory).Parent.Parent.FullName;
        }

        public void AddValue(string value)
        {
            Data.Add(value);
        }

        public void CreateFile()
        {
            string filePath = Path.Combine(ProjectDirectory, Name);

            try
            {
                File.WriteAllLines(filePath, Data);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e);
            }
        }

        public void ShowData()
        {
            Data.Sort();
            foreach(string item in Data)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
