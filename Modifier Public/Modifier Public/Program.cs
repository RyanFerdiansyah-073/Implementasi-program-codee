using System;

namespace ModifierPublic
{
    class Person
    {
        public string name = "Ryan Ferdiansyah";
    }
    class program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.name);
        }
    }
}