using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            var payment = new CardPayment(DateTime.Now);
            //var payment = new CardPayment();

            payment.pay("");

            Console.WriteLine("Hello World!");
        }
    }

    // private, protect, internal e public
        
    public class Payment
    {
        public Payment(DateTime expiration)
        {
            Console.WriteLine("Starting payment");
            payDay = DateTime.Now;
        }

        //public Payment() { }
        public DateTime payDay { get; set; }

        // Métodos
        public virtual void pay(string number)
        {
            Console.WriteLine("Pay");
        }
        //public void pay(string number, DateTime expiration, bool payAfterExpiration = false) { }

    }

    public class CardPayment : Payment
    {
        //ctor
        public CardPayment(DateTime expiration):base(expiration)
        {

        }

        // Métodos
        public override void pay(string number) 
        {
            base.pay(number);
            Console.WriteLine("Pay card");
        }

    }
    public class Address
    {
        string ZipCode;
    }
}
