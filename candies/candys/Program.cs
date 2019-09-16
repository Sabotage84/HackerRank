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
            // minimumPasses(1, 1,6, 45);
            //minimumPasses(1, 3, 2, 12);
            //minimumPasses(123456789012, 215987654321, 50000000000, 1000000000000);
            // minimumPasses(4294967297, 4294967297, 1000000000000, 1000000000000);
            //minimumPasses(5361,3918, 8447708, 989936375520);

            minimumPasses(499999, 1000000, 999996, 1000000000000);

            Console.ReadKey();
        }

        public static long minimumPasses(long m, long w, long p, long n)
        {
           long res = 0;
           double tt = (double)m * (double)w;
           
            if (m >= n || w >= n || tt>= n )
                return 1;
            res = WhatWay(m, w, p, n, 0, 0);
            Console.WriteLine("aNSWER---->" + res);
            return res;
        }

        public static long WhatWay(long m, long w, long p, long n, long steps, long over)
        {
            Console.Write("m={0} w={1} steps={2}", m, w, steps);
            long strictWay = Convert.ToInt64(Math.Ceiling((double)(n-over) / (double)(m * w)));
            long bayWay = 0;
            long b=0;
            long newSteps = 0;
            if (p >= (m * w))
            {
                b = 1;
                long tp = p - over;
                bayWay = Convert.ToInt64(Math.Ceiling((double)tp / (double)(m * w)));
                newSteps= bayWay;
                over = bayWay * m * w - tp;
                if (m >= w)
                {
                    w++;
                }
                else
                {
                    m++;
                }
                
            }
            else
            {
                bayWay = 1;
                newSteps= 1;
                long totalMoney = (m * w) + over;
                b = totalMoney / p;
                over = totalMoney-(b*p);
                if (m==w)
                {
                    if (b % 2 == 0)
                    {
                        m += b / 2;
                        w += b / 2;
                    }
                    else
                    {
                        w += b / 2 + 1;
                        m += b / 2;
                    }
                }
                else
                {
                    if (m>w)
                    {
                        long r = m - w;
                        if (r >= b)
                            w += b;
                        else
                        {
                            w += r;
                            b -= r;
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
                    }
                    else
                    {
                        long r = w - m;
                        if (r >= b)
                            m += b;
                        else
                        {
                            m += r;
                            b -= r;
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
                    }

                }

               
            }
            if (n > m * w)
            {
                bayWay += Convert.ToInt64(Math.Ceiling((double)(n) / (double)(m * w)));
               
            }

            Console.WriteLine(" bought={0}  over={1}",b, over);

            if (strictWay < bayWay)

                return strictWay + steps;

            else
            {
                steps += newSteps;
                if (bayWay == 1)
                    return steps+1;
                else
                {
                    
                    return WhatWay(m, w, p, n, steps, over);
                }
            }
        }
    }
}
