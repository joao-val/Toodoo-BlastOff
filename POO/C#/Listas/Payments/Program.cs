using System;
using System.Collections.Generic;

namespace ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            IList <Payment> payments = new List<Payment>();
            payments.Add(new Payment());
            payments.Remove(new Payment());

            IEnumerable<string> list = new List<string>();
            var list1 = new List<string>();
            
        }
    }

    public class Payment { }

}