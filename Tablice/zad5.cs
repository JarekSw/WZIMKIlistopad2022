//5.	Stworzyć tablice i zapisać w niej 14 pierwszych ilorazów ciągu Fibonacciego 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad5
    {
        public static double[] TAB5(int[] tab)
        {
            double[] wynik = new double[tab.Length - 1];
            double tmp;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                tmp = Convert.ToDouble(tab[i]);
                wynik[i] = tab[i + 1] / tmp;
            }

            return wynik;
        }
    }
}
