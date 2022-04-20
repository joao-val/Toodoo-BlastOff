using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Payment : IPayment
        {
            public DateTime expiration { get; set; }

            void IPayment.Payment(double value)
            {
                
            }
        }

        public class CreditCardPayment : IPayment
        {
            public DateTime expiration { get; set; }

            public void Payment(double value)
            {
                throw new NotImplementedException();
            }
        }

        public interface IPayment
        {
            public DateTime expiration { get; set; }

            void Payment(double value);
        }
    }
}
