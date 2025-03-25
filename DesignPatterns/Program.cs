namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Design Patterns Tutorial!");
            PaymentContext context = new PaymentContext();
            context.SetPaymentStrategy(new CreditCardPayment());
            context.PayAmount(500);
            context.SetPaymentStrategy(new PayPalPayment());
            context.PayAmount(250);
            context.SetPaymentStrategy(new BitcoinPayment());
            context.PayAmount(750);
        }
    }
}
