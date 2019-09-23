using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyFlorist
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int[] arr = { 1, 3, 5, 7, 9, };

            Console.WriteLine(getMinimumCost(k,arr));
            Console.ReadKey();
        }

        static int getMinimumCost(int k, int[] c)
        {
            int res = 0;
            Array.Sort(c);
            int tempK = k;
            int koef = 1;
            for (int i = c.Length-1; i >=0; i--)
            {
                res += koef * c[i];
                tempK--;
                if (tempK==0)
                {
                    koef++;
                    tempK = k;
                }
            }

            return res;
        }
    }
}
