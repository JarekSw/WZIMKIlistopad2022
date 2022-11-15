//3.	Wypisać ile w podanym napisie jest wielkich, a ile małych liter.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad3str
    {
        static bool CzyMalaLitera(char znak)
        {
            string malePolskieLitery = "ążźśęćńół";
            if ('a' <= znak && znak <= 'z')
            {
                return true;
            }

            for (int i = 0; i < malePolskieLitery.Length; i++)
            {
                if (znak == malePolskieLitery[i])
                {
                    return true;
                }
            }
            return false;
        }
        static bool CzyWielkaLitera(char znak)
        {
            string wielkiePolskieLitery = "ĄŻŹŚĘĆŃÓŁ";
            if ('A' <= znak && znak <= 'Z')
            {
                return true;
            }

            for (int i = 0; i < wielkiePolskieLitery.Length; i++)
            {
                if (znak == wielkiePolskieLitery[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static void STRING3(string napis)
        {
            Console.WriteLine("STRING3:");
            int liczbaMalychLiter = 0;
            int liczbaWielkiLiter = 0;

            for (int i = 0; i < napis.Length; i++)
            {
                if (CzyMalaLitera(napis[i]))
                {
                    liczbaMalychLiter++;
                }
                if (CzyWielkaLitera(napis[i]))
                {
                    liczbaWielkiLiter++;
                }
            }
            Console.WriteLine($"Napis: {napis}, zawiera: {liczbaMalychLiter} małych liter oraz {liczbaWielkiLiter} wielkich liter.");
        }
    }
}
