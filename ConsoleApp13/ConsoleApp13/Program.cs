using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //long r = 3;
            //long[] lon = new long[6] { 1, 3, 9, 9, 27, 81 };

            long r = 1;
            long[] lon = new long[100];
            for (int i = 0; i < lon.Length; i++)
            {
                lon[i] = 1;
            }

            long res = 0;
            res = foo(lon.ToList(), r);
            Console.WriteLine(res);

            Console.ReadKey();

        }

        private static long foo(List<long> arr, long r)
        {
            long res = 0;
            //Dictionary<int, long> firstLevel = new Dictionary<int, long>();
            Dictionary<long, int> secondLevel = new Dictionary<long, int>();
            Dictionary<long, int> thirdLevel = new Dictionary<long, int>();
            int i=1, j=1;
             arr.Reverse();
            foreach (var item in arr)
            {
               if(secondLevel.Keys.Contains(item*r) && i>2)
                {
                    if (thirdLevel.Keys.Contains(item*r*r))
                    {
                        res += secondLevel[item * r] * thirdLevel[item * r * r];
                    }
                }

                if (secondLevel.Keys.Contains(item))
                {
                    if (i > 2)
                        secondLevel[item]++;
                }
                else
                    secondLevel.Add(item, 1);

                if (thirdLevel.Keys.Contains(item))
                {
                    if (i > 3)
                        thirdLevel[item]++;
                }
                else
                    thirdLevel.Add(item, 1);
                i++;
                j++;
            }

            return res;
        }
    }
}
