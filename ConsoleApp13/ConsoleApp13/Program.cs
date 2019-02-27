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
            long r = 3;
            long[] lon = new long[6] { 1, 3, 9, 9, 27, 81 };
            long res=0;
            res = foo(lon.ToList(), r);
            Console.WriteLine(res);

            Console.ReadKey();

        }

        private static long foo(List<long> arr, long r)
        {
            long res = 0;
            Dictionary<int, long> firstLevel = new Dictionary<int, long>();
            Dictionary<int, long> secondLevel = new Dictionary<int, long>();
            Dictionary<int, long> thirdLevel = new Dictionary<int, long>();
            int i = 0;
            foreach (var item in arr)
            {
                firstLevel.Add(i, item);
                if (item%r==0)
                    secondLevel.Add(i, item);
                if (item%(r*r)==0)
                    thirdLevel.Add(i, item);
                i++;
            }
            if (secondLevel.Count == 0 || thirdLevel.Count == 0)
                return res;
            foreach (var item in firstLevel)
            {
                if(secondLevel.Values.Contains(item.Value*r) && thirdLevel.Values.Contains(item.Value*r*r))
                {
                    foreach (var item2 in secondLevel)
                    {
                        if (item.Value* r == item2.Value  && item2.Key > item.Key)
                        {
                            
                            foreach (var item3 in thirdLevel)
                            {
                                if (item2.Value * r == item3.Value  && item3.Key > item2.Key)
                                {
                                    res++;
                                }
                            }
                        }

                    }
                }
            }


            
            
            Console.WriteLine("First level:");
            foreach (KeyValuePair<int, long> keyValue in firstLevel)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                
            }

            Console.WriteLine();
            Console.WriteLine("Second level:");
            foreach (KeyValuePair<int, long> keyValue in secondLevel)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                
            }
            Console.WriteLine();
            Console.WriteLine("Third level:");
            foreach (KeyValuePair<int, long> keyValue in thirdLevel)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
               
            }

            return res;
        }
    }
}
