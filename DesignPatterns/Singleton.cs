namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static int count = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine($"Count: {count}");
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
