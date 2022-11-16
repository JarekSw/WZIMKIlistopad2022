using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class wyjsciePozaIndeks
    {
        public static void WyswietlTablicę(int[] tab)
        {
            try
            {
                for (int i = 0; i <= tab.Length; i++)
                    Console.WriteLine(tab[i]);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Poza tablica");
            }
        }
    }
}
