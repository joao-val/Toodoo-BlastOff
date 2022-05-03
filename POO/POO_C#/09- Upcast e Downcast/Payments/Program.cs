using System;

namespace UpcastDowncast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = new Person();
            var physicalPerson = new PhysicalPerson();
            var legalPerson = new LegalPerson();
            //downcast
            person = physicalPerson;
            
            //upcast
            physicalPerson = (PhysicalPerson)person;

            //Erro estão na mesma altura
            //physicalPerson = (LegalPerson)legalPerson;
            person = new LegalPerson();
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class PhysicalPerson : Person
    {
        public string CPF { get; set; }
    }

    public class LegalPerson : Person
    {
        public string CNPJ { get; set; }
    }
}
