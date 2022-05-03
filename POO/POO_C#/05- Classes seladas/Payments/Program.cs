using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello World!");
        }
    }
        
    //Não pode ser herdada
    public sealed class Payment 
    {
        public DateTime expiration { get; set; }
    }

}
