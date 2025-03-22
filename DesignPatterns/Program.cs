namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            Console.WriteLine("Enter shape type (circle/rectangle): ");
            string? shapeType = Console.ReadLine();
            IShape? shape = ShapeFactory.CreateShape(shapeType ?? "");
            if(shape != null)
            {
                shape.Draw();
            }
            else
            {
                Console.WriteLine("Invalid Shape Type!");
            }
        }
    }
}
