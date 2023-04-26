namespace Projeto5.Entities
{
    class MyEmployeeFile
    {
        public string Name { get; private set; }
        public List<Employee> Data { get; private set; }
        static public string CurrentDirectory { get; private set; }
        static public string ProjectDirectory { get; private set; }

        public MyEmployeeFile(string name)
        {
            Name = name;
            Data = new List<Employee>();
            CurrentDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
            ProjectDirectory = Directory.GetParent(CurrentDirectory).Parent.Parent.FullName;
        }

        public void AddEmployee(Employee emp)
        {
            Data.Add(emp);
        }

        public void CreateFile()
        {
            string filePath = Path.Combine(ProjectDirectory, Name);

            try
            {
                File.WriteAllLines(filePath, Data.Select(x => x.ToString()));
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
            foreach(Employee e in Data)
            {
                Console.WriteLine(e);
            }            
        }
    }
}
