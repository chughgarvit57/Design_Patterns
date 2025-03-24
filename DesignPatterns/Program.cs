namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            Console.WriteLine();
            YoutubeChannel channel = new YoutubeChannel();
            Subsciber user1 = new Subsciber("Garvit");
            Subsciber user2 = new Subsciber("Chugh");
            channel.Subscribe(user1);
            channel.Subscribe(user2);
            channel.Notify("New Video Uploaded!");
        }
    }
}
