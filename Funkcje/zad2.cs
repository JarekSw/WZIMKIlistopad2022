//Stwórz funkcję 
//double Odleglosc(double x1, double y1, double x2, double y2)
//zwracającą odległość między dwoma punktami – (x1, y1) i(x2, y2).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    internal class zad2
    {
        public static double Odleglosc(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
