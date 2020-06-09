using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int squares(int a, int b)
        {
            int res = 0;
            int b1 =(int) Math.Sqrt(a);
            int b2 = (int)Math.Sqrt(b);
            for (int i = b1; i <= b2; i++)
            {
                if (i * i >= a && i * i <= b)
                    res++;
            }
            return res;

        }
    }
}
