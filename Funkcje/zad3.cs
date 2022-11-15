//string DluzszyKrotszy(string napis1, string napis2, char znak)
//Funkcja ma zwracać połączone napisy napis1 i napis2 – najpierw dłuższy, potem krótszy.
//Jeśli napisy są równej długości, zwróć znak.
//Np. dla napis1 = ”aaaaa” i napis2 = ”bb”, funkcja powinna zwrócić ”aaaaabb”.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    internal class zad3
    {
        public static string DluzszyKrotszy(string napis1, string napis2, char znak)
        {
            if (napis1.Length > napis2.Length)
                return napis1 + napis2;
            else if (napis1.Length < napis2.Length)
                return napis2 + napis1;
            return znak.ToString();
        }
    }
}
