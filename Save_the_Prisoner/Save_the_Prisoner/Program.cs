using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_the_Prisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(100 % 7);
            Console.ReadKey();
        }

        static int saveThePrisoner(int n, int m, int s)
        {
            int res = 0;
            int t = s - 1 + m % n;
            res = t % n;
            if (res == 0)
                return n;
            return res;
        }
    }
}
