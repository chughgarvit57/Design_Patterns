namespace DesignPatterns
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Paid {amount} using Credit Card.");
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }
        }
    }
}
