namespace DesignPatterns
{
    public class Burger
    {
        public string Cheese { get; set; }
        public string Sauce { get; set; }
        public void Show()
        {
            Console.WriteLine($"Burger with {Cheese} Cheese & {Sauce} Sauce");
        }
    }
}
