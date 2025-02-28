using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        //Napisać program wczytujacy trzy liczby i wypisujacy na ekranie wartosc najmniejszej i najwiekszej z tych liczb
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj liczbę a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
                Console.Write("Liczba najwieksza to a, liczba najmniejsza to c");
            else if (a > c && c > b)
                Console.Write("Liczba najwieksza to a, liczba najmniejsza to b");
            else if (b > c && c > a)
                Console.Write("Liczba najwieksza to b, liczba najmniejsza to a");
            else if (b > a && a > c)
                Console.Write("Liczba najwieksza to b, liczba najmniejsza to c");
            else if (c > a && a > b)
                Console.Write("Liczba najwieksza to c, liczba najmniejsza to b");
            else
                Console.Write("Liczba najwieksza to c, liczba najmniejsza to a");

            Console.ReadKey(true);
        }
    }
}
