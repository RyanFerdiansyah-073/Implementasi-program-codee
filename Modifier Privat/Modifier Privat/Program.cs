using System;

namespace ModifierPrivate
{
    class Person
    {
        private string name = "Ryan Ferdiansyah";
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.name);
        }
    }
}