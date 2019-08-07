using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            long[] arr = { 1,5,9 };
            long M = 5;
            Console.WriteLine(maximumSum(arr, M));
            Console.ReadKey();

        }

        public static long maximumSum(long[] a, long m)
        {
            long curr = 0;
            SortedDictionary<long, long> sDict = new SortedDictionary<long, long>();
            for (long i = 0; i < a.Length; i++)
            {
                curr = (a[i] % m + curr) % m;
                sDict[curr] = i;
            }
            var keyArr = sDict.Keys.ToArray();
            long max = keyArr.Last();
            for (long i = 0; i < sDict.Keys.Count - 1; i++)
            {
                if (sDict[keyArr[i]] > sDict[keyArr[i + 1]])
                {
                    max = Math.Max(max, (keyArr[i] - keyArr[i + 1] + m) % m);
                }
            }
            return max;
        }

        public static long maximumSum_Brut(long[] a, long m)
        {
            long res = 0;
            long[] tempArr = new long[a.LongLength];
            for (long i = 0; i < a.LongLength; i++)
            {
                tempArr[i] = a[i] % m;
            }
            long l = 0;
            List<long> resultsList = new List<long>();
            while (l <= tempArr.LongLength)
            {
                for (long i = 0; i < tempArr.LongLength && i + l < tempArr.LongLength; i++)
                {
                    long sum = 0;
                    for (long j = i; j <= l + i; j++)
                    {
                        sum += tempArr[j];
                        sum %= m;
                    }
                    resultsList.Add(sum % m);
                }
                l++;
            }

            foreach (var item in resultsList)
            {
                if (res < item)
                    res = item;
            }

            return res;
        }
    }
}
