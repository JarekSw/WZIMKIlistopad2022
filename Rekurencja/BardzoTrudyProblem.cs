using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencja
{
    internal class BardzoTrudyProblem
    {
        public static uint C(uint n)
        {
            if (n == 1) return 0;
            if (n % 2 == 0) return C(n / 2) + 1;
            else return C(3 * n + 1) + 1;
        }
    }
}
