using System;

namespace Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Wypisać liczby od 0 do 100.
            FOR1();
            //2.Wypisać liczby od 0 do 100, ale w odwrotnej kolejności.
            FOR2();
            //3.Wypisać liczby od 0 do 100 ale wypisując co drugą (0,2,4,…).
            FOR3();
            //4.Wypisać liczby od 0 do 100 w odwrotnej kolejność wypisując co trzecią (100, 97,94,..)
            FOR4();
            //5.Wypisać sumę wszystkich naturalnych nie większych niż 100. (0 jest naturalne)
            FOR5();
            //6.Wypisać średnią arytmetyczną liczb naturalnych nie większych niż 100. (0 jest naturalne)
            FOR6();
            //7.Wypisać wszystkie liczby pierwsze mniejsze niż 100, oraz wypisać ile tych liczb jest.
            FOR7();
            //8.Wypisać średnią arytmetyczną liczb pierwszych nie większych niż 100.
            FOR8();
            //9.Wypisać wszystkie liczby dwucyfrowe, których cyfra dziesiątek jest trzy razy większa od cyfry jedności (liczba postaci: DJ gdzie D = 3*J).
            FOR9();
            //10.Wypisać liczby podzielne przez 3 albo przez 5 nie większe niż 100.
            FOR10();
            //11.Wypisz ile jest liczb pierwszych w zakresie od a do b.
            FOR11(100, 111);
            //12.Dla podanej liczby naturalnej oblicz jej silnie.
            FOR12(5);

            //2.Znaleźć najmniejszą liczbę naturalną n spełniającą równanie: n^3 – 21*n^2 – 1659*n - 14430361 = 0
            WHILE2();

            //1.Napisać funkcje, która dla podanej liczby wierszy, wypisze na ekran:
            //n=4
            //*
            //**
            //***
            //****
            ZAGNIEZDZANIE1(4);
            //2.Napisać funkcje, która dla podanej liczby wierszy, wypisze na ekran:
            //n=4
            //   *
            //  ***
            // *****
            //*******
            ZAGNIEZDZANIE2(10);
            //3. Napisać funkcje, która dla podanej liczby wierszy wypisze na ekran:
            //n=4
            //*^*^*
            //^*^*^
            //*^*^*
            //^*^*^
            ZAGNIEZDZANIE3(8);
        }
        static void FOR1()
        {
            Console.WriteLine("FOR1:");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void FOR2()
        {
            Console.WriteLine("FOR2:");
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void FOR3()
        {
            Console.WriteLine("FOR3:");
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            ////Inny sposób:
            //for (int i = 0; i <= 50; i++)
            //{
            //    Console.WriteLine(2*i);
            //}
        }
        static void FOR4()
        {
            Console.WriteLine("FOR4:");
            for (int i = 100; i >= 0; i = i - 3)
            {
                Console.WriteLine(i);
            }
        }
        static void FOR5()
        {
            Console.WriteLine("FOR5:");
            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Suma wynosi: {suma}, powinno wyjść (0+100)/2*101 = 5050");
        }
        static void FOR6()
        {
            int srednia = 0;
            for (int i = 0; i <= 100; i++)
            {
                srednia += i;
            }
            srednia /= 101;
            Console.WriteLine($"Średnia arytmetyczna liczb naturalnych nie większych od 100 wynosi: {srednia}");
        }
        static void FOR7()
        {
            Console.WriteLine("FOR7:");
            int ileJestLiczbPierwszych = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (CzyLiczbaJestPierwsza(i))
                {
                    Console.WriteLine(i);
                    ileJestLiczbPierwszych++;
                }
            }
            Console.WriteLine($"Liczb pierwszych nie większych od 100 jest: {ileJestLiczbPierwszych}");
        }
        static void FOR8()
        {
            Console.WriteLine("FOR8:");
            int ileJestLiczbPierwszych = 0;
            int sredniaLiczbPierwszych = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (CzyLiczbaJestPierwsza(i))
                {
                    Console.WriteLine(i);
                    ileJestLiczbPierwszych++;
                    sredniaLiczbPierwszych += i;
                }
            }
            sredniaLiczbPierwszych /= ileJestLiczbPierwszych;
            Console.WriteLine($"Średnia arytmetyczna liczb pierwszych nie większych od 100 wynosi: {sredniaLiczbPierwszych}");
        }
        static void FOR9()
        {
            Console.WriteLine("FOR9:");

            int cyfraJednosci;
            int cyfraDziesiatek;
            for (int i = 10; i < 100; i++)
            {
                cyfraJednosci = i % 10;
                cyfraDziesiatek = i / 10;
                if (3 * cyfraJednosci == cyfraDziesiatek)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void FOR10()
        {
            Console.WriteLine("FOR10:");

            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3 == 0 || i % 5 == 0) && i % 15 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void FOR11(int a, int b)
        {
            Console.WriteLine("FOR11:");

            if (a > b)
            {
                Console.WriteLine($"Liczb pierwszych w zakresie <{a},{b}> jest 0");
                return;
            }

            int ileLiczbPierwszych = 0;
            for (int i = a; i <= b; i++)
            {
                if (CzyLiczbaJestPierwsza(i))
                {
                    ileLiczbPierwszych++;
                }
            }
            Console.WriteLine($"Liczb pierwszych w zakresie <{a},{b}> jest {ileLiczbPierwszych}");

        }
        static void FOR12(int n)
        {
            Console.WriteLine("FOR12:");

            if (n == 0)
            {
                Console.WriteLine($"Silnia dla n={n} wynosi: 1");
                return;
            }

            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik *= i;
            }
            Console.WriteLine($"Silnia dla n={n} wynosi: {wynik}");
        }
        static void WHILE2()
        {
            Console.WriteLine("WHILE2:");
            int n = 0;
            while ((n * n * n - 21 * n * n - 1659 * n - 14430361) != 0)
            {
                n++;
            }
            Console.WriteLine(n);
        }
        static void ZAGNIEZDZANIE1(int a)
        {
            Console.WriteLine("ZAGNIEZDZANIE1:");

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void ZAGNIEZDZANIE2(int a)
        {
            Console.WriteLine("ZAGNIEZDZANIE2:");

            int liczbaSpacji = a - 1;
            int liczbaGwiazdek = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < liczbaSpacji; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < liczbaGwiazdek; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                liczbaSpacji--;
                liczbaGwiazdek += 2;
            }
        }
        static void ZAGNIEZDZANIE3(int a)
        {
            Console.WriteLine("ZAGNIEZDZANIE3:");
            bool wypiszGwiazdke = true;
            bool zacznijOdGwiazdki = true;
            for (int i = 0; i < a; i++)
            {
                wypiszGwiazdke = zacznijOdGwiazdki;
                zacznijOdGwiazdki = !zacznijOdGwiazdki;
                for (int j = 0; j < a; j++)
                {
                    if (wypiszGwiazdke)
                        Console.Write("*");
                    else
                        Console.Write("^");

                    wypiszGwiazdke = !wypiszGwiazdke;
                }
                Console.WriteLine();
            }
        }
        static bool CzyLiczbaJestPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= liczba; i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
