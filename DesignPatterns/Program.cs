namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            Burger burger = new BurgerBuilder()
                .AddCheese("Cheese")
                .AddSauce("BBQ")
                .Build();

            burger.Show();
        }
    }
}
