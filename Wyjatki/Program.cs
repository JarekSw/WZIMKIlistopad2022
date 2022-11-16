using System;

namespace Wyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dzieleniePrzezZero.Dzielenie(6,0));

            Console.WriteLine("\n//////////////////////////////////////////////////\n");

            int[] tab = { 1, 2, 3, 4, 5 };
            wyjsciePozaIndeks.WyswietlTablicę(tab);
            
        }
    }
}
