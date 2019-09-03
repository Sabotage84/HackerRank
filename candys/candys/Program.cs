using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candys
{
    public class Program
    {
        static void Main(string[] args)
        {
            minimumPasses(0, 0, 0, 4);
            Console.ReadKey();
        }

        public static long minimumPasses(long m, long w, long p, long n)
        {
            long res = 0;
            if (m >= n || w >= n || m*n>=n)
                return 1;
            if (p>=n)
            {
                if (n % (m * n) == 0)
                    return n / (m * n);
                else
                    return n / (m * n)+1;
            }
            long target = Convert.ToInt64(Math.Ceiling(Math.Sqrt(n)));


            Console.WriteLine(target);
            return res;
        }
    }
}
