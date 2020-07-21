using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int chocolateFeast(int n, int c, int m)
        {
            int res = 0;
            int ch = n / c;
            res += ch;
            while (ch>=m)
            {
                res += ch / m;
                int t = ch / m;
                ch = ch % m;
                ch += t;
            }

            return res;
        }
    }
}
