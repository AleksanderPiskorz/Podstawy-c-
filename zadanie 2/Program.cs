using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        //Napisać program wczytujacy liczbe calkowita i wypisujacy informacje czy wczytana liczba jest dodatnia ujemna czy tez rowna zero
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba jest dodatnia");
            else if (a < 0)
                Console.WriteLine("Liczba jest ujemna");
            else
                Console.WriteLine("Liczba jest równa 0");

                Console.ReadKey(true);

        }
    }
}
