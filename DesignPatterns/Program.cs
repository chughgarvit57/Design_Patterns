namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            Parallel.Invoke(
                () => PrintEmployeeDetails(),
                () => PrintStudentDetails()
                );
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployeeClass = Singleton.GetInstance;
            fromEmployeeClass.PrintMessage("Suppose From Employee Class");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudentClass = Singleton.GetInstance;
            fromStudentClass.PrintMessage("Suppose From Student Class");
        }
    }
}
