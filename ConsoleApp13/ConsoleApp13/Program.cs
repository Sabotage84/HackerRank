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
            long res = 0;
            res = foo(lon.ToList(), r);
            Console.WriteLine(res);

            Console.ReadKey();

        }

        private static long foo(List<long> arr, long r)
        {
            long res = 0;
            //Dictionary<int, long> firstLevel = new Dictionary<int, long>();
            //Dictionary<int, long> secondLevel = new Dictionary<int, long>();
            //Dictionary<int, long> thirdLevel = new Dictionary<int, long>();
            long[] firstLevel = new long[arr.Count];
            long[] secondLevel = new long[arr.Count];
            long[] thirdLevel = new long[arr.Count];

            int i = 0;
            foreach (var item in arr)
            {
                firstLevel[i] = item;
                if (item % r == 0)
                    secondLevel[i] = item;
                if (item % (r * r) == 0)
                    thirdLevel[i] = item;
                i++;
            }

            for (int j = 0; j < firstLevel.Length; j++)
            {
                if (secondLevel.Contains(firstLevel[j] * r) && thirdLevel.Contains(firstLevel[j] * r * r))
                {
                    for (int k = j + 1; k < secondLevel.Length; k++)
                    {
                        if (firstLevel[j] * r == secondLevel[k])
                        {
                            for (int l = k + 1; l < thirdLevel.Length; l++)
                            {
                                if (secondLevel[k] * r == thirdLevel[l])
                                {
                                    res++;
                                }
                            }
                        }
                    }
                }
            }




           
   




//    Console.WriteLine("First level:");
//            foreach (KeyValuePair<int, long> keyValue in firstLevel)
//            {
//                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

//            }

//Console.WriteLine();
//            Console.WriteLine("Second level:");
//            foreach (KeyValuePair<int, long> keyValue in secondLevel)
//            {
//                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

//            }
//            Console.WriteLine();
//            Console.WriteLine("Third level:");
//            foreach (KeyValuePair<int, long> keyValue in thirdLevel)
//            {
//                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

//            }

            return res;
        }
    }
}
