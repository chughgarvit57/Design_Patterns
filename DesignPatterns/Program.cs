namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            RemoteControl remote = new(new SonyTV());
            remote.PressPower();
        }
    }
}
