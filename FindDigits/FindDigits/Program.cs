using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int findDigits(int n)
        {
            int res = 0;
            int t = n;
            int t1 = n;
            while (t1/10!=0)
            {
                
                t = t1 % 10;
                if (t!=0)
                {
                    if (n % t == 0)
                        res++;
                }
                t1 = t1 / 10;
            }
            t = t1 % 10;
            if (t != 0)
            {
                if (n % t == 0)
                    res++;
            }

            return res;

        }
    }
}
