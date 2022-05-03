using System;

namespace ComparandoObjetos
{
    class Program
    {

        static void Main(string[] args)
        {
            // Delegates(delegar para outro fazer) => anonymous methods
            var pay = new Payment.Pay(AccomplishPayment);
            pay(25);
        }
        static void AccomplishPayment(double value)
        {
            Console.WriteLine($"I pay the value of {value}");
        }

        
    }

    public class Payment
    {
        public delegate void Pay(double value);
    }
}
