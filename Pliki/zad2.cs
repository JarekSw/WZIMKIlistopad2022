//Stwórz funkcję Wczytanie(string imie,int rok,string kto,string sciezka) która jednorazowo 
//nadpisze plik kartka_s.txt i zamieni wartości {imie}, {   rok, { kto}
//na dowolne parametry wprowadzone przez użytkownika oraz zwróci nadpisany plik(zastosuj 
//funkcję wbudowaną.Replace)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pliki
{
    internal class zad2
    {
        static string Wczytanie(string imie, int rok, string kto, string sciezka)
        {


            string dowczytania = File.ReadAllText(sciezka);


            string dokument = dowczytania.Replace("{imie}", imie).Replace("{rok}", Convert.ToString(rok)).Replace("{kto}", kto);
            //dowczytania.Replace("{imie}", imie);
            //dowczytania.Replace("{rok}", Convert.ToString(rok));
            //dowczytania.Replace("{kto}", kto);


            File.WriteAllText(sciezka, dokument);

            return dokument;


        }
    }
}
