using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_04_POO.entities
{
    public class Book
    {
       
        public Book()
        {
        }

        public Book(string title, string format, string quantity)
        {
            Books = new List<Book>();
            Title = titleFormat(title);
            ISBN = ISBNFormat(format);
            NumberPages = numberOfPages(quantity);
        }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public int NumberPages { get; set; }

        public virtual List<Book> Books { get; set; }

        public void ViewData()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Book's title: {Title}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Number of pages: {NumberPages}");
        }

        public string titleFormat(string format)
        {
            var test = double.TryParse(format, out double x) || format.Length == 0 ;
            if (test == true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the title in the correct format:");
                    format = Console.ReadLine();
                    test = double.TryParse(format, out x) || format.Length == 0;
                } while (test == true);
            }
            else
            {
                Title = format;
            }
            return Title = format;
        }

        public string ISBNFormat(string format)
        {
            var test = Int64.TryParse(format, out Int64 x);
            if (test == false)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the ISBN in the correct format:");
                    format = Console.ReadLine();
                    test = Int64.TryParse(format, out x);
                } while (test == false);
            }
            else { return format; }
            return ISBN = format;
        }

        public int numberOfPages(string numberPages)
        {
            var test = int.TryParse(numberPages, out int x) && int.Parse(numberPages) > 0
                    && int.Parse(numberPages) < 4000;
            if (test == false)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the 'number of pages' in the correct format:");
                    numberPages = Console.ReadLine();
                    test = int.TryParse(numberPages, out x) && int.Parse(numberPages) > 0
                        && int.Parse(numberPages) < 4000;
                } while (test == false);
            }
            return NumberPages = int.Parse(numberPages);
        }

    }
}
