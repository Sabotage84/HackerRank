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

            //long r = 2;
            //long[] lon = new long[4] { 1, 2, 2, 4 };

            long r = 1;

            //long[] lon = new long[5] { 1, 1, 1, 1, 1 };
            long[] lon = new long[100000];
            for (int i = 0; i < lon.Length; i++)
            {
                lon[i] = 1;
            }
            long realAnswer = 161700;
            long res = 0;
            res = foo(lon.ToList(), r);
            Console.WriteLine(res);

            Console.ReadKey();

        }

        private static long foo(List<long> arr, long r)
        {
            long res = 0;
            
            Dictionary<long, long> secondLevel = new Dictionary<long, long>();
            Dictionary<long, long> thirdLevel = new Dictionary<long, long>();
           
            arr.Reverse();
            foreach (var item in arr)
            {
                if (thirdLevel.ContainsKey(item * r))
                    res += thirdLevel[item*r];


                if (secondLevel.Keys.Contains(item * r))
                {
                    //secondLevel[item*r]++;
                    if (thirdLevel.Keys.Contains(item))
                        thirdLevel[item]+=secondLevel[item*r];
                    else
                        thirdLevel.Add(item, secondLevel[item*r]);
                    
                }

                
                if (secondLevel.Keys.Contains(item))
                    secondLevel[item]++;
                else
                    secondLevel.Add(item, 1);
                
            }

            return res;
        }
    }
}
