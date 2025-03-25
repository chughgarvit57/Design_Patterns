namespace DesignPatterns
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Paid {amount} using PayPal.");
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }
        }
    }
}
