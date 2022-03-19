using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nim 1302204100");
            Console.Write("Penjumlahan Long : ");
            Console.WriteLine(Penjumlahan.jlh<long>(13, 02, 20));
        }
    }

    class Penjumlahan
    {
        public static T jlh<T>(T satu, T dua, T tiga)
        {
            return (dynamic)satu + (dynamic)dua + (dynamic)tiga;
        }
    }
}


