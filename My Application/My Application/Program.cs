using System;

namespace MyApplication
{
    class Person
    {
        protected string name = "Ryan Ferdiansyah";
    }
    class Program : Person
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Name: " + program.name);
            Console.ReadLine();
        }
    }
}