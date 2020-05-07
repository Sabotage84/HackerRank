using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int viralAdvertising(int n)
        {
            int likes=2;
            int res = 2;
            int sends = 1;
            for (int i = 2; i <= n; i++)
            {
                sends = likes * 3;
                res += sends / 2;
                likes = sends / 2;
            }

            return res;
        }
    }
}
