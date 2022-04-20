using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            var payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            //foreach (var item in payments)
            //{
            //    Console.WriteLine(item.Id);
            //}

            var payment = payments.First(x => x.Id == 3);
            Console.WriteLine(payment.Id);

            //payments.Remove(payment);
            //foreach (var item in payments)
            //{
            //    Console.WriteLine(item.Id);
            //}

            //foreach (var item in payments.Where(x => x.Id == 4))
            //{
            //    Console.WriteLine(item.Id);
            //}

            //var exists = payments.Any(x => x.Id == 3);
            //Console.WriteLine(exists);

            var exists = payments.Skip(2).Take(3);
            Console.WriteLine(exists);


            // AddRange para adicionar vários elementos a lista
            //var paidPayments = new List<Payment>();
            //paidPayments.AddRange(payments);
        }
    }

    public class Payment 
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id; 
        }
    }

}