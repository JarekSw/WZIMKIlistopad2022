using System;

namespace Rekurencja
{
    internal class Program
    {
        static int RekurencjaSilnia(int liczba)
        {
            if(liczba==1)
                return 1;
            else
                return liczba*RekurencjaSilnia(liczba-1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RekurencjaSilnia(4));
        }
    }
}
