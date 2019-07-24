using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = { 3, 3, 9, 9, 5 };
            long M = 7;
            Console.WriteLine(maximumSum(arr, M));
            Console.ReadKey();

        }
        static long maximumSum(long[] a, long m)
        {
            long res = 0;
            long[] tempArr = new long[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                tempArr[i] = a[i] % m;
            }

            long f = 0, s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                f += a[i];
                s += tempArr[i];

            }
            Console.WriteLine(f % m);
            Console.WriteLine(s % m);
            return res;
        }
    }
}
