﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, l, V, Pc;
            Console.Write("Podaj r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            V = 1 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.Write("objętość={0} ", V);
            Console.Write("pole całkowite={0} ", Pc);
            Console.ReadKey(true); //pauza
        }
    }
}
