namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            CarFactory factory = new PetrolSUVFactory();
            CarFactory factory2 = new ElectricSUVFactory();
            ICar car = factory.CreateCar();
            ICar car1 = factory2.CreateCar();
            car.Drive();
            car1.Drive();
        }
    }
}
