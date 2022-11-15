using System;

namespace Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Napisać funkcje do wyświetlania tablicy.
            int[] tab1 = { 6, 3, 1, 8, 23, 0, -12, 23 };
            zad1.TAB1(tab1);

            Console.WriteLine();
            //2.Wypisz największą i najmniejszą wartość niepustej tablicy liczb, oraz podaj na jakim indeksie się znajdują.
            int[] tab2 = { 7, -9, 123, 4, 0, -7, 6, 7, 290, -165, 87, 3, -9, 12 };
            zad2.TAB2(tab2);

            Console.WriteLine();
            //3.Napisać funkcję która wypiszę średnią arytmetyczną liczb z niepustej tablicy.
            int[] tab3 = { 5, 2, -23, 123, 65, -76, 12, 2, 5, 2, 3, 0, 34 };
            zad3.TAB3(tab3);

            Console.WriteLine();
            //4.Stworzyć tablice i zapisać w niej 15 pierwszych elementów ciągu Fibonacciego (f_0=1, f_1=1, f_(n+2)= f_(n+1)  + f_n)
            int[] tab4 = new int[15];
            zad4.TAB4(tab4);
            WypiszTablice(tab4);

            Console.WriteLine();
            //5.Stworzyć tablice i zapisać w niej 14 pierwszych ilorazów ciągu Fibonacciego czyli:  f_n/f_(n-1) 
            double[] tab5 = zad5.TAB5(tab4);
            WypiszTablice(tab5);

            Console.WriteLine();
            //6.Podać średnią arytmetyczną liczb pierwszych z tablicy.
            int[] tab6 = { 7, 21, 65, 11, 2, 19, 10, 25, 4, 3 };
            zad6.TAB6(tab6);


            //1.Wypisać ile w podanym napisie jest liter(wliczając polskie litery).
            string napis1 = "aaab@#scśdó239łsd";
            zad1str.STRING1(napis1);

            //2.Wypisać ile w podanym napisie jest samogłosek, a ile spółgłosek.
            string napis2 = "Ala ma jednego kota i dwa psy.";
            zad2str.STRING2(napis2);

            //3.Wypisać ile w podanym napisie jest wielkich, a ile małych liter.
            string napis3 = "asd223DźWEqółw2e@W43 sdaWEW23sdDFX";
            zad3str.STRING3(napis3);
        }
        static void WypiszTablice(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
        static void WypiszTablice(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
