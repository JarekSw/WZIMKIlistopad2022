//1.Napisać funkcje do wyświetlania tablicy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad1
    {
        public static void TAB1(int[] tab)
        {
            Console.WriteLine("TAB1:");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
