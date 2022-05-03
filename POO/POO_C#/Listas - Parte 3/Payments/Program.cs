using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Payment> payments = new List<Payment>();
            //payments.Add(new Payment(1));
            //payments.Add(new Payment(2));
            //payments.Add(new Payment(3));
            //payments.Add(new Payment(4));
            //payments.Add(new Payment(5));

            payments.AsEnumerable();
            payments.ToList();
            payments.ToArray();

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