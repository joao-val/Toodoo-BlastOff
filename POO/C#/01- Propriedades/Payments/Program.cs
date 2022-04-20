using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {

            var payment = new Payment();
            payment.ToString();
            payment.paymentDay = DateTime.Now;

            Console.WriteLine("Hello World!");
        }
    }

    // private, protect, internal e public
        
    internal class Payment
    {
        
        public string billetNumber;

        public DateTime Expiration 
        {
            get 
            {
                return Expiration;
            }
            set { }
        }

        private DateTime _paymentDay;

        public DateTime paymentDay
        {
            get 
            {
                Console.WriteLine("Lendo o valor");
                return _paymentDay.AddDays(1); 
            }
            set 
            {
                Console.WriteLine("Atribuindo o valor");
                _paymentDay = value; 
            }
        }


        // Métodos
        protected void pay() { }
    }

    public class Address
    {
        string ZipCode;
    }

}
