using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxarrsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 4, 6, 5 };
            Console.WriteLine(maxSubsetSum(arr));
            Console.ReadKey();
        }

        static int maxSubsetSum(int[] arr)
        {
            int res = 0;
            int[] odds;
            int[] evens = new int[arr.Length / 2]; ;
            if (arr.Length % 2 == 0)
            {
                odds = new int[arr.Length / 2];
            }
            else
            {
                odds = new int[arr.Length / 2 + 1];
            }

            odds[0] = arr[0];
            evens[0] = arr[1];

            for (int i = 2; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odds[i / 2] = arr[i] + odds[i / 2 - 1];
                }
                else
                {
                    evens[i / 2] = arr[i]+evens[i / 2-1];
                }
            }
            for (int i = 0; i < odds.Length; i++)
            {
                if (res < odds[i])
                    res = odds[i];
            }

            for (int i = 0; i < evens.Length; i++)
            {
                if (res < evens[i])
                    res = evens[i];
            }
            int tempSum;
            for (int i = 0; i <odds.Length;  i++)
            {
                tempSum = odds[i];
                int t = i + 1;
                for (int j = t; j < evens.Length; j++)
                {
                    tempSum += evens[j]-evens[t-1];
                    if (tempSum > res)
                        res = tempSum;
                }
            }


            //Console.WriteLine("Нечетн");
            //for (int i = 0; i < odds.Length; i++)
            //{
            //    Console.Write(odds[i]+" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Четные");
            //for (int i = 0; i < evens.Length; i++)
            //{

            //    Console.Write(evens[i] + " ");
            //}
            //Console.WriteLine();
            return res;
        }
    }
}
