using System;

namespace Destructor
{
    class Murid
    {
        public Murid()
        {
            Console.WriteLine("Instance Class Telah Dibuat");
        }
        ~Murid()
        {
            Console.WriteLine("Instance Class Telah di Destroy");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Jalankan();
            GC.Collect();
        }
        public static void Jalankan()
        {
            Murid murid = new Murid();
        }
    }
}