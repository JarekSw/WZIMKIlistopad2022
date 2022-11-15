//Stwórz funkcję  
//bool CzyRównaA(int a, int liczba)
//Funkcja ma zwracać true, jeśli liczba liczba jest równa liczbie a (w przeciwnym wypadku false).
//
//Stwórz funkcję  
//bool CzyPodzielnaPrzezA(int a, int liczba)
//Funkcja ma zwracać true, jeśli liczba liczba jest podzielna przez liczbę a (w przeciwnym wypadku lub dla a równego 0 – false).
//
//Stwórz funkcję  
//bool CzyNieparzysta(int liczba)
//Funkcja ma zwracać true, jeśli liczba liczba jest nieparzysta (w przeciwnym wypadku false).
//
//Stwórz funkcję  
//bool CzyRówna22LubPodzielnaPrzez7INieparzysta(int liczba)
//Funkcja ma zwracać true, jeśli liczba liczba spełnia jeden z warunków:
//Jest równa 22.
//Jest podzielna przez 7 i nieparzysta.
//W przeciwnym wypadku funkcja ma zwracać false. Wykorzystaj funkcje z poprzednich podpunktów (połącz je odpowiednimi operatorami logicznymi).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    internal class zad1
    {
        public static bool CzyRównaA(int a, int liczba)
        {
            if (liczba == a)
                return true;
            return false;
        }

        public static bool CzyPodzielnaPrzezA(int a, int liczba)
        {
            if (a == 0)
            {
                Console.WriteLine("Błąd - nie można dzielić przez 0!");
                return false;
            }
            if (liczba % a == 0)
                return true;
            return false;
        }

        public static bool CzyNieparzysta(int liczba)
        {
            if (liczba % 2 != 0)
                return true;
            return false;
        }

        public static bool CzyRówna22LubPodzielnaPrzez7INieparzysta(int liczba)
        {
            return CzyRównaA(22, liczba) || CzyPodzielnaPrzezA(7, liczba) && CzyNieparzysta(liczba);
        }
    }
}
