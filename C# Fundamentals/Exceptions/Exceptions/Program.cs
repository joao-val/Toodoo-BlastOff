using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[3];

            try
            {
                //for (int i = 0; i < 10; i++)
                //{
                //   IndexOutOfRangeException
                //  Console.WriteLine(arr[i]);
                //}

                Save("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cannot find index in the list");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Failed to register text");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.WhenHappened);
                Console.WriteLine("Custom exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Reached the end");
            }
        }

        private static void Save(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new MyException(DateTime.Now);
            }
        }

        public class MyException : Exception
        {
            public MyException(DateTime date)
            {
                WhenHappened = date;
            }

            public DateTime WhenHappened { get; set; }
        }

    }
}
