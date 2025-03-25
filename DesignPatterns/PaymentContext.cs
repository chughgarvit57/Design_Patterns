using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
        public void PayAmount(int amount)
        {
            if (paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method first.");
            }
            else
            {
                paymentStrategy.Pay(amount);
            }
        }
    }
}
