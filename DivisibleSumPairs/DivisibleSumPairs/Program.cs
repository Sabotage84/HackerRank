using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int n = 6;
            int[] ar = { 1, 3, 2, 6, 1, 2 };
            Console.WriteLine(divisibleSumPairs(n, k, ar));
            Console.ReadKey();
        }

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int res = 0;
            for (int i = 0; i < ar.Length-1; i++)
            {
                for (int j = i+1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        res++;
                }
            }

            return res;
        }
    }
}
