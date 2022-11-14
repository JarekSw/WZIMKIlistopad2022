//Zadanie jest proste. Napisz funkcję która przyjmuje jeden argument typu int o nazwie
//„CzyPodzielna”. Funkcja ma wypisać na ekran tekst „TAK” jeżeli podana liczba jest podzielna
//przez 7. W przeciwnym przypadku należy wypisać „NIE”.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Podzielnosc
    {
        static void CzyPodzielna(int value)
        {
            if (value % 7 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
        }

        static void Main(string[] args)
        {
            CzyPodzielna(7);
            CzyPodzielna(14);
            CzyPodzielna(15);
        }
    }
}
