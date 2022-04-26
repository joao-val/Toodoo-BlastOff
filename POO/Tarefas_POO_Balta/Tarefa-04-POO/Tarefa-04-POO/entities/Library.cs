using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tarefa_04_POO.entities;

namespace Tarefa_04_POO
{
    public class Library : Book
    {

        public Library()
        {
        }

        public void menu()
        {

            var books = new List<Book>();
            var book1 = new Book("The Fellowship of the Ring", "9780007136599", "479");
            var book2 = new Book("The Two Towers", "9780007136599", "415");
            var book3 = new Book("The Return of the King", "9780007136599", "347");
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            var test = false;
            int option;
            do
            {
                option = Option();
                Console.Clear();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("First type the title on the 1st line, ISBN on the 2nd and number of pages on the 3rd");
                        books.Add(new Book(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
                        Console.WriteLine(books.Count);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter the title:");
                        var bookTitle = Console.ReadLine();
                        Console.WriteLine("Enter the ISBN:");
                        var bookISBN = Console.ReadLine();

                        test = false;
                        string bookPages;
                        do
                        {
                            Console.WriteLine("Enter the number of pages:");
                            bookPages = Console.ReadLine();
                            test = int.TryParse(bookPages, out int x) 
                                && int.Parse(bookPages) > 0 && int.Parse(bookPages) < 50000;
                        } while (test == false);

                        var allBooks =
                            from Book book in books
                            where book.Title == bookTitle || book.ISBN == bookISBN || book.NumberPages == int.Parse(bookPages)
                            select book;

                        foreach (Book item in allBooks)
                        {
                            item.ViewData();
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Book smaller = book1;
                        Book bigger = book1;
                        foreach (Book item in books)
                        {
                            for (int i = 0; i < books.Count; i++)
                            {
                                var oi = books[i];
                                if (smaller.NumberPages > item.NumberPages)
                                {
                                    smaller = item;
                                }
                                else if (bigger.NumberPages < item.NumberPages)
                                {
                                    bigger = item;
                                }
                            }
                        }
                        smaller.ViewData();
                        bigger.ViewData();

                        Console.ReadKey();
                        break;
                }
            }while (option != 4);
            Environment.Exit(0);
        }

        public int Option()
        {
            string option;
            var test = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("Option 1: Add a book!");
                Console.WriteLine("Option 2: Search a book!");
                Console.WriteLine("Option 3: Search for books with the smallest and largest number of pages!");
                Console.WriteLine("Option 4: To exit!");

                option = Console.ReadLine();
                test = int.TryParse(option, out int x)
                    && int.Parse(option) >= 1 && int.Parse(option) <= 4;

            } while (test == false);

            return int.Parse(option);
        }

    }
}