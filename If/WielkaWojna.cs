//Jednowymiarowe mrówki cały czas dążą do powiększenia swoich królestw. Gdy spotkają się dwa
//królestwa dochodzi do wielkiej wojny. Królestwo to odcinek na osi liczbowej od jakiegoś x1
//do y1. Najlepsi mrówczy stratedzy ustalili że gdy jedno królestwo całkowicie zawiera się w
//drugim to przegrywa wojnę. Natomiast gdy królestwa na siebie nachodzą lub stykają się wtedy
//są w stanie wojny. Gdy królestwa nie nachodzą się w krainie jest pokój.
//	Zwracając uwagę na burzliwą kulturę świata mrówek królowa poprosiła ciebie - zdolnego
//	programistę - o napisanie funkcji typu void o nazwie “WynikWojny” która przyjmuje 4
//	argumenty typu int: x1,y1,x2,y2 które są odpowiednio granicami pierwszego i drugiego
//	królestwa. Funkcja ma wypisywać na ekran czy „Trwa wojna”, „Zwycięstwo królestwa
//	pierwszego”, „Zwycięstwo królestwa drugiego” lub czy „Trwa pokój”.
//	Gdy dwa królestwa idealnie na siebie nachodzą wtedy interpretujemy to jako błąd
//	mrówczej agencji wywiadu i funkcja ma nie wypisać nic.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    public class WielkaWojna
    {
        public static void WynikWojny(int x1, int y1, int x2, int y2)
        {
            if (x1 < x2)
            {
                if ((y1 >= x2) && (y1 <= y2))
                {
                    Console.WriteLine("Trwa wojna");
                }

                if (y1 < x2)
                {
                    Console.WriteLine("Trwa pokój");
                }
            }

            if (x2 < x1)
            {
                if ((y2 >= x1) && (y2 <= y1))
                {
                    Console.WriteLine("Trwa wojna");
                }

                if (y2 < x1)
                {
                    Console.WriteLine("Trwa pokój");
                }
            }

            if ((x1 < x2) && (y1 > y2))
            {
                Console.WriteLine("Zwycięstwo królestwa pierwszego");
            }

            if ((x2 < x1) && (y2 > y1))
            {
                Console.WriteLine("Zwycięstwo królestwa drugiego");
            }
        }
    }
}
