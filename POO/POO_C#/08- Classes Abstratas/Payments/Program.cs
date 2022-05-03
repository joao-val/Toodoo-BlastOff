using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var payment = new CreditCardPayment();
        }

        public abstract class Payment : IPayment
        {
            public DateTime expiration { get; set; }

            void IPayment.Payment(double value)
            {
                
            }
        }

        public class CreditCardPayment : Payment
        {
            public override void Payment(double value)
            {
                ((IPayment)(base)).Payment(value);
            }
        }

        public class BilletPayment : Payment
        {
            public override void Payment(double value)
            {
                ((IPayment)(base)).Payment(value);
            }
        }

        public class PagamentoApplePay : Payment
        {
            public override void Payment(double value)
            {
                ((IPayment)(base)).Payment(value);
            }
        }

        public interface IPayment
        {
            public DateTime expiration { get; set; }

            void Payment(double value);
        }
    }
}
