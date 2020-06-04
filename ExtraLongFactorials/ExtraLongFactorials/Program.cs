using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            extraLongFactorials(100);
            Console.ReadKey();

        }
        static void extraLongFactorials(int n)
        {
            BigInteger t = new BigInteger(1);
            for (int i = 1; i <= n; i++)
            {
                t *= i;
            }
            Console.WriteLine(t);

        }
    }
}
