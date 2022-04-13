﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Balta_io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(manutencaoEletrica.Id);
            Console.WriteLine(manutencaoEletrica.Name);
            Console.WriteLine(manutencaoEletrica.Price);
            Console.WriteLine(manutencaoEletrica.Type);
            Console.WriteLine((int)manutencaoEletrica.Type);
            Console.ReadKey();

        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
