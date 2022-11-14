//W pliku liczby.txt znajdują się wiersze z kolumnami stwórz funkcję 
//string Dopisanie(string sciezka) zliczającą sumę wszystkich liczb parzystych, dopisz ją 
//do pliku i wyświetl

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pliki
{
    internal class zad3
    {
        static string Dopisanie(string sciezka)
        {
            int suma = 0;
            string[] wnetrze2 = File.ReadAllLines(sciezka);

            //1 sposób zastosować pętle foreach
            //foreach(string s in wnetrze2) 
            for (int i = 0; i < wnetrze2.Length; i++)
            {

                int numer = Convert.ToInt32(wnetrze2[i]);
                if (numer % 2 == 0) suma += numer;
                else
                {
                    continue;
                }
            }

            string przekonwertuj = Convert.ToString(suma);
            File.AppendAllText(sciezka, przekonwertuj);

            string sczytany = File.ReadAllText(sciezka);
            return sczytany;

        }
    }
}
