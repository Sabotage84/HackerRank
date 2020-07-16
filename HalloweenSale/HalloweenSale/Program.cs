using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenSale
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(howManyGames(20, 3, 6, 85));
            Console.ReadLine();
        }
        public static int howManyGames(int p, int d, int m, int s)
        {
            int res = 0;
            while (s>=m)
            {
                s -= p;
                res++;
                if (p > m)
                    p -= d;
                else
                    p = m;
            }

            return res;

        }

    }
}
