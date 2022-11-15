//1.	Wypisać ile w podanym napisie jest liter (wliczając polskie litery).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad1str
    {
        public static void STRING1(string napis)
        {
            Console.WriteLine("STRING1:");
            int liczbaLiter = 0;
            for (int i = 0; i < napis.Length; i++)
            {
                if (CzyLitera(napis[i]))
                {
                    liczbaLiter++;
                }
            }
            Console.WriteLine($"W napisie: {napis}, znajduje się: {liczbaLiter} liter.");
        }
    }
}
