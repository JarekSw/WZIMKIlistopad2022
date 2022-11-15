//3.	Napisać funkcję która wypiszę średnią arytmetyczną liczb z niepustej tablicy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad3
    {
        public static void TAB3(int[] tab)
        {
            Console.WriteLine("TAB3:");
            double srednia = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                srednia += tab[i];
            }
            srednia /= tab.Length;
            Console.WriteLine($"Średnia liczb z podanej tablicy wynosi: {srednia}");

        }
    }
}
