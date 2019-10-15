using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pageCount(6,2));
            Console.WriteLine(pageCount(5,4));
            Console.WriteLine(pageCount(7, 3));
            Console.ReadKey();
        }

        static int pageCount(int n, int p)
        {
            
            int f = 0, r = 0;
            for (int i = 0, j=1; j < n; i++, j+=2)
            {
                if (j == p || (j - 1) == p)
                    f = i; 
            }

            int k = 0;
            int l = n;
            if (n % 2 == 0)
            {
                if (p == n)
                    return 0;
                k = 1;
                l = n - 1;
            }


            for (; l > 1; k++, l-=2)
            {
                if (l == p || (l - 1) == p)
                    r = k;
            }
            return Math.Min(f,r);

        }
    }
}
