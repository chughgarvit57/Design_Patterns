namespace DesignPatterns
{
    public class BitcoinPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Paid {amount} using Bitcoin.");
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }
        }
    }
}
