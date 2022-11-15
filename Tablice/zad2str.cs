//2.	Wypisać ile w podanym napisie jest samogłosek, a ile spółgłosek.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    internal class zad2str
    {
        static bool CzyLitera(char znak)
        {
            if ('a' <= znak && znak <= 'z')
            {
                return true;
            }

            if ('A' <= znak && znak <= 'Z')
            {
                return true;
            }

            string polskieZnaki = "ąćżźśęńółĄĆŻŹŚĘŃÓŁ";


            for (int i = 0; i < polskieZnaki.Length; i++)
            {
                if (znak == polskieZnaki[i])
                {
                    return true;
                }
            }

            return false;
        }
        static bool CzySamogłoska(char znak)
        {
            string samogloski = "aąeęiouóyAĄEĘIOUÓY";
            if (CzyLitera(znak))
            {
                for (int i = 0; i < samogloski.Length; i++)
                {
                    if (znak == samogloski[i])
                    {
                        return true;
                    }
                }


            }

            return false;
        }
        static bool CzySpolgloska(char znak)
        {
            if (CzyLitera(znak))
            {
                if (!CzySamogłoska(znak))
                {
                    return true;
                }
            }
            return false;
        }
        public static void STRING2(string napis)
        {
            Console.WriteLine("STRING2:");
            int liczbaSamoglosek = 0;
            int liczbaSpolglosek = 0;

            for (int i = 0; i < napis.Length; i++)
            {
                if (CzySamogłoska(napis[i]))
                {
                    liczbaSamoglosek++;
                }
                if (CzySpolgloska(napis[i]))
                {
                    liczbaSpolglosek++;
                }
            }
            Console.WriteLine($"W napisie: {napis}, jest {liczbaSamoglosek} samoglosek oraz {liczbaSpolglosek} spolglosek");
        }
    }
    
    
}
