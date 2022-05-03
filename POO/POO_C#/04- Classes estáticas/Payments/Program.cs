using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment.expiration = DateTime.Now;
            Console.WriteLine("Hello World!");
        }
    }

    // private, protect, internal e public
        
    public static class Payment
    {
        //prop
        public static DateTime expiration { get; set; }
    }

    public static class Settings
    {
        public static string API_URL { get; set; }
    }
}
