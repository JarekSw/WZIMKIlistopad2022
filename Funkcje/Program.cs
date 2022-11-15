using System;

namespace Funkcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad1 \n");
            Console.WriteLine(zad1.CzyRównaA(11, 11));
            Console.WriteLine(zad1.CzyRównaA(11, 12));

            Console.WriteLine((zad1.CzyPodzielnaPrzezA(8, 24)));
            Console.WriteLine(zad1.CzyPodzielnaPrzezA(6, 13));
            Console.WriteLine(zad1.CzyPodzielnaPrzezA(0, 12));

            Console.WriteLine(zad1.CzyNieparzysta(3));
            Console.WriteLine(zad1.CzyNieparzysta(4));

            Console.WriteLine(zad1.CzyRówna22LubPodzielnaPrzez7INieparzysta(22));
            Console.WriteLine((zad1.CzyRówna22LubPodzielnaPrzez7INieparzysta(35)));
            Console.WriteLine((zad1.CzyRówna22LubPodzielnaPrzez7INieparzysta(5)));
            Console.WriteLine(zad1.CzyRówna22LubPodzielnaPrzez7INieparzysta((12)));

            Console.WriteLine("\n///////////////////////////////////////////////////\nZad2\n");
            Console.WriteLine(zad2.Odleglosc(2, 5, 5, 9));

            Console.WriteLine("\n///////////////////////////////////////////////////\nZad3\n");
            Console.WriteLine(zad3.DluzszyKrotszy("aaa", "bbbbb", 'c'));
            Console.WriteLine(zad3.DluzszyKrotszy("aaaaaaaaaa", "bb", 'c'));
            Console.WriteLine(zad3.DluzszyKrotszy("a", "b", 'c'));
            Console.WriteLine(zad3.DluzszyKrotszy("", "bbb", 'c'));
            Console.WriteLine(zad3.DluzszyKrotszy("aa", "", 'c'));
            
        }
    }
}
