using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleandOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] apples = { -2, 2, 1 };
            int[] orange = { 6, -6 };
            countApplesAndOranges(s,t,a,b,apples,orange);
            Console.ReadKey();
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int res = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if (a + apples[i] >= s && a + apples[i] <= t)
                    res++;
            }
            Console.WriteLine(res);
            res = 0;
            for (int i = 0; i < oranges.Length; i++)
            {
                if (b + oranges[i] >= s && b + oranges[i] <= t)
                    res++;
            }
            Console.WriteLine(res);
        }
    }
}
