using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4._2
{
    class Program
    { 
        // Napisac program wczytujacy piec liczb i wypisujacy na ekranie wartosc najmniejszej najwiekszej z tych liczb
        static void Main(string[] args)
        {
            int a, b, c, d, e, min, max;
            Console.WriteLine("Podaj liczbę a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę e: ");
            e = Convert.ToInt32(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Najmniejsza liczba to: {0}", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Największa liczba to: {0}", max);

            Console.ReadKey(true);



        }
    }
}
