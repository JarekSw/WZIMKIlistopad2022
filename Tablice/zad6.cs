//6.	Podać średnią arytmetyczną liczb pierwszych z tablicy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad6
    {
        public static void TAB6(int[] tab)
        {
            Console.WriteLine("TAB6:");

            int ileJestLiczPierwszych = 0;
            double srednia = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (CzyLiczbaJestPierwsza(tab[i]))
                {
                    srednia += tab[i];
                    ileJestLiczPierwszych++;
                }
            }
            srednia /= ileJestLiczPierwszych;
            Console.WriteLine($"Średnia liczb pierwszych z tablicy wynosi {srednia}");
        }
    }
}
