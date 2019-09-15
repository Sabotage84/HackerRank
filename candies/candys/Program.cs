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
            if (m >= n || w >= n || m * w >= n)
                return 1;
            //if (p >= n)
            //{
            //    if (n % (m * n) == 0)
            //        return n / (m * n);
            //    else
            //        return n / (m * n) + 1;
            //}
            long target = Convert.ToInt64(Math.Ceiling(Math.Sqrt(n)));

            res = WhatWay(m, w, p, n, 0, 0);

            Console.WriteLine(target);
            return res;
        }

        public static long WhatWay(long m, long w, long p, long n, long steps, long over)
        {
            long strictWay = Convert.ToInt64(Math.Ceiling((double)n / (double)(m * w)));
            long bayWay = 0;

            if (p >= (m * w))
            {
                bayWay = Convert.ToInt64(Math.Ceiling((double)p / (double)(m * w)));

                if (m >= w)
                    w++;
                else
                    m++;
                
            }
            else
            {
                bayWay = 1;
                long b = (m * w) / p;
                over = (m * w) % p;
                if (b % 2 == 0)
                {
                    m += b / 2;
                    w += b / 2;
                }
                else
                {
                    if (m >= w)
                    {
                        w += b / 2 + 1;
                        m += b / 2;
                    }
                    else
                    {
                        m += b / 2 + 1;
                        w += b / 2;
                    }
                }
            }
            bayWay += Convert.ToInt64(Math.Ceiling((double)n / (double)(m * w)));
            if (strictWay <= bayWay)
                return strictWay + steps;
            else
               return WhatWay(m, n, p, n, bayWay, over);
        }
    }
}
