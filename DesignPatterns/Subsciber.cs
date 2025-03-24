namespace DesignPatterns
{
    public class Subsciber : IObserver
    {
        private string name;
        public Subsciber(string name)
        {
            this.name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }
    }
}
