﻿using System;
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
            long res = 0;
            long[] tempArr = new long[a.LongLength];
            for (long i = 0; i < a.LongLength; i++)
            {
                tempArr[i] = a[i] % m;
            }
            long l = 0;
            List<long> resList = new List<long>();
            long tempSum = 0;
            long tempindex=0;
            for (long i = 0; i <tempArr.LongLength; i++)
            {
               
                tempSum += tempArr[i];
                if (tempSum >= m)
                {
                    long tr = tempSum % m;
                    resList.Add(tempSum - tempArr[i]);
                    resList.Add(tr);
                    // tr = tempArr[i] - 1;
                    if (tr < tempArr[tempindex])
                    {
                        tempindex++;
                        i = tempindex-1;
                    }
                    else
                    {
                        long tt = 0;
                        for (long j = tempindex; j < i; j++)
                        {
                            tt += tempArr[j];
                            if (tt == tr)
                            {
                                tempindex = j + 1;
                                i = j;
                                break;
                            }
                            else if(tt > tr)
                                {
                                    tempindex = j+1;
                                    i = j;
                                    break;
                                }
                        }
                    }
                    tempSum = 0;
                }
                else if (i == tempArr.LongLength-1)
                    resList.Add(tempSum);

            }

            foreach (var item in resList)
            {
                if (res < item)
                    res = item;
            }

           

            return res;
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
