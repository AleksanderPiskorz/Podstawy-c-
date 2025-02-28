using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        //  Napisać program wczytujacy liczbe calkowita i wypisujacy na ekranie informacje czy jest to liczba parzysta czy tez nieparzysta
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbe calkowita: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("liczba jest parzysta");
            else
                Console.WriteLine("Liczba jest nieparzysta");
            Console.ReadKey(true);
                
        }
    }
}
