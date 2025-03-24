namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            Console.WriteLine("There are 2 possible ways - Shallow Copy & Deep Copy");
            Employee original = new Employee("Garvit", "Developer","Chandigarh");
            Console.WriteLine();
            Employee copy = (Employee) original.Clone();
            copy.Name = "Avi";
            copy.EmployeeAddress.City = "Pkl";
            original.Display();
            copy.Display();
        }
    }
}
