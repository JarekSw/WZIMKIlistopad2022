using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencja
{
    internal class CiagFibbonaciego
    {
        public static uint T(uint n)
        {
            if (n <= 2) return n;
            else return T(n - 1) + T(n - 2) + T(n - 3);
        }
    }
}
