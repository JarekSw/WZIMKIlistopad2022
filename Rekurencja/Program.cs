using System;

namespace Rekurencja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bardzo trudny problem\n");
            for (uint i = 1; i < 10; i++)
            {
                Console.WriteLine(i + ": " + BardzoTrudyProblem.C(i));
            }

            Console.WriteLine("\n\n\nCiąg Fibbonaciego\n");
            for (uint i = 0; i <= 35; i++)
            {
                Console.WriteLine(i + ": " + CiagFibbonaciego.T(i));
            }
        }
    }
}
