using System;

namespace inheritance
{
    class siswa
    {
        private string nama;
        private string jurusan;

        public void pertama(string name)
        {
            this.nama = name;
        }
        public void kedua(string jurus)
        {
            this.jurusan = jurus;
        }
        public string getnama()
        {
            return (nama);
        }
        public string getjurusan()
        {
            return (jurusan);
        }
    }
    class satu : siswa
    {
        private double induk;

        public void setnim(double nim)
        {
            induk = nim;
        }
        public double getnim()
        {
            return (induk);
        }
        public void tampil()
        {
            Console.WriteLine("Nim     = " + getnim());
            Console.WriteLine("Nama    = " + getnama());
            Console.WriteLine("Jurusan = " + getjurusan());
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            satu a = new satu();
            a.pertama("Ryan Ferdiasnsyah");
            a.kedua("S1 Sistem Informasi");
            a.setnim(21051214073);
            a.tampil();
            Console.ReadKey(true);
        }
    }
}