using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            //var payment = new payment();
            //payment.dispose();

            using (var payment = new Payment())
            {
                Console.WriteLine("Processing payment");
            }

                Console.WriteLine("Hello World!");
        }
    }

    // private, protect, internal e public
        
    public class Payment : IDisposable
    {

        // Garbage Collector

        public Payment()
        {
            Console.WriteLine("Initiating payment");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizing the payment");
        }
    }
}
