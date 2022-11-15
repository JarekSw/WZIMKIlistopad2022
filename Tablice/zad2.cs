//2.	Wypisz największą i najmniejszą wartość niepustej tablicy liczb, oraz podaj na jakim
//indeksie się znajdują.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad2
    {
        public static void TAB2(int[] tab)
        {
            Console.WriteLine("TAB2:");

            int minimum = tab[0];
            int indeksMinimum = 0;
            int maksimum = tab[0];
            int indeksMaksimum = 0;

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < minimum)
                {
                    indeksMinimum = i;
                    minimum = tab[i];
                }

                if (tab[i] > maksimum)
                {
                    indeksMaksimum = i;
                    maksimum = tab[i];
                }
            }
            Console.WriteLine($"Minimum tablicy wynosi: {minimum} i jest ono na indeksie: {indeksMinimum}, natomiast maksimum tablicy wynosi: {maksimum} i jest ono na indeksie: {indeksMaksimum}");
        }
    }
}
