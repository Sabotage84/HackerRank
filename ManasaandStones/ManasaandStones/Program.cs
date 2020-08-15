using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasaandStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = stones(58,69,24);
            for (int i = 0; i < t1.Length; i++)
            {
                Console.Write(t1[i] + " ");
                
            }
Console.ReadKey();

        }

        static int[] stones(int n, int a, int b)
        {
            int[] res = new int[n];
            if (a == b)
                return new int[] { a * (n - 1) };
            for (int i = 0, j=n-1; i < n; i++,j--)
            {
                res[i] = a * j + i * b;
            }
            Array.Sort(res);

            return res;
        }
    }
}
