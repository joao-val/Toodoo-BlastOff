using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_09_POO.entities
{
    public class Visitor
    {

        public Visitor()
        {
        }
        
        public string CPF { get; set; }

        private string Name { get; set; }

        private DateTime DateOfBirth { get; set; }

        private int ExhibitedItems { get; set; }

        private static byte Floor { get; set; }
        private static byte VINTAGE = 1;
        private static byte NUMISMATICS = 2;
        private static byte MUSIC_HISTORY = 3;
        private static byte PAINTINGS = 4;
        private static byte SCULPTURE = 5;

        public void FillCPF()
        {
            Regex testCPF = new Regex(@"^([\d]{3})\.([\d]{3})\.([\d]{3})\-([\d]{2})$");

            do
            {
                Console.Clear();
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Enter the CPF in the correct format (xxx.xxx.xxx-xx): |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                CPF = Console.ReadLine();
                if (!testCPF.IsMatch(CPF))
                {
                    Console.WriteLine("Incorrect format!");
                    Console.ReadKey();
                }
            } while (!testCPF.IsMatch(CPF));
        }


        public void FillInformations()
        {
            Regex testName = new Regex(@"^[A-Za-zÁ-Úá-ú]{2,15}\s[A-Za-zÁ-Úá-ú\s]+$");
            var test = false;
            string name, dateOfBirth;

            do
            {
                Console.Clear();
                Console.WriteLine("______________________________________________");
                Console.WriteLine("Fill in all the information requested below! |");
                Console.WriteLine("Type your name:                              |");
                name = Console.ReadLine();
                Console.WriteLine("Type your date of birth (dd/mm/yyyy):        |");
                dateOfBirth = Console.ReadLine();
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                test = DateTime.TryParse(dateOfBirth, out DateTime x)
                    && DateTime.Parse(dateOfBirth).Year > 1900
                    && DateTime.Parse(dateOfBirth).Year < 2022
                    && testName.IsMatch(name);

                if (test == false)
                {
                    Console.WriteLine("Information has been placed in an incorrect format!");
                    Console.ReadKey();
                }
            }while (test == false);
            Name = name;
            DateOfBirth = DateTime.Parse(dateOfBirth);

            Console.ReadKey();
        }

        public void Theme()
        {
            string option;

            Console.Clear();
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("|Choose below the floor where the visitor wants to be in our museum! |");
            Console.WriteLine("|Each floor has a specific theme:                                    |");
            Console.WriteLine("|Option 1 the theme is: Vintage                                      |");
            Console.WriteLine("|Option 2 the theme is: Numismatics                                  |");
            Console.WriteLine("|Option 3 the theme is: Music History                                |");
            Console.WriteLine("|Option 4 the theme is: Paintings                                    |");
            Console.WriteLine("|Option 5 the theme is: Sculpture                                    |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Floor = VINTAGE;
                    ExhibitedItems = 135;
                    Console.WriteLine("You choose the theme VINTAGE");
                    break;

                case "2":
                    Floor = NUMISMATICS;
                    ExhibitedItems = 300;
                    Console.WriteLine("You choose the theme NUMISMATICS");
                    break;

                case "3":
                    Floor = MUSIC_HISTORY;
                    ExhibitedItems = 67;
                    Console.WriteLine("You choose the theme MUSIC HISTORY");
                    break;

                case "4":
                    Floor = PAINTINGS;
                    ExhibitedItems = 72;
                    Console.WriteLine("You choose the theme PAINTINGS");
                    break;

                case "5":
                    Floor = SCULPTURE;
                    ExhibitedItems = 46;
                    Console.WriteLine("You choose the theme SCULPTURE");
                    break;
            }
            Console.ReadKey();
            if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5")
            {
                Console.WriteLine("Invalid option!");
                Console.ReadKey();
                Theme();
            }
        }

        public void ShowItems()
        {
            Console.Clear();
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine($"Current floor has {ExhibitedItems} items!");
            Console.WriteLine($"The total amount of items on all floors of the museum is {620}!");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

        public void ShowAllInformations()
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("Complete visitor record!");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Date of birth: {DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Floor: {Floor}");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

    }
}