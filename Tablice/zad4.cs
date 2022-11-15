//4.	Stworzyć tablice  i zapisać w niej 15 pierwszych elementów ciągu Fibonacciego 
//(f0=1,fn+2=fn+1+fn)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad4
    {
        public static void TAB4(int[] tab)
        {
            Console.WriteLine("TAB4:");
            tab[0] = 1;
            tab[1] = 1;
            for (int i = 2; i < tab.Length; i++)
            {
                tab[i] = tab[i - 2] + tab[i - 1];
            }
        }
    }
}
