//Stwórz funkcję string Czytanie2(string sciezka) która dwukrotnie odczyta dane z pliku 
//Lorem.txt przy pomocy poleceń File.ReadAllLines oraz File.ReadAllText 
//(pamiętaj że File.ReadAllLines zwraca tablicę wartości string, jeśli używasz petli zastosuj 
//zmienną pomocniczą do której będziesz zapisywał iterowane wiersze oraz "\n" znak nowej 
//lini w celu ich oddzielenia. Przy return możesz zastosować "\n" w celu wyswietlenia kopi 
//tekstu w nowej linii)




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pliki
{
    internal class zad1
    {
        //Opcja 1
        static string Czytanie(string sciezka)
        {
            string wnetrze = File.ReadAllText(sciezka);
            string[] wnetrze2 = File.ReadAllLines(sciezka);

            string drugie = string.Join(Environment.NewLine, wnetrze2);

            return wnetrze + "\n" + drugie;
        }

        //Opcja 2
        static string Czytanie2(string sciezka)
        {
            string wnetrze = File.ReadAllText(sciezka);
            string[] wnetrze2 = File.ReadAllLines(sciezka);
            string downetraz2 = "";
            foreach (string s in wnetrze2)
            {
                downetraz2 += s + "\n";
            }

            return downetraz2 + "\n" + wnetrze;
        }

    }
}
