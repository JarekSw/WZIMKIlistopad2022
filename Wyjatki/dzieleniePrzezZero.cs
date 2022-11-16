using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class dzieleniePrzezZero
    {
        public static double Dzielenie(int a,int b)
        {
            double wynik;

            try
            {
                wynik = a / b;
                return wynik;
            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("Nie można dzielić przez zero");
            }
            return 0;
        }
    }
}
