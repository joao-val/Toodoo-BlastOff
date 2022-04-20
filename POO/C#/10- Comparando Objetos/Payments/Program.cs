using System;

namespace ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var personA = new Person(1, "André Baltieri");
            var personB = new Person(1, "André BaltieriX");

            Console.WriteLine(personA.Equals(personB));

        }
    }

    public class Person : IEquatable<Person>
    {
        public Person(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Person person)
        {
            return Id == person.Id;
        }
    }
}
