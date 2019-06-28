using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] arStr = File.ReadAllLines("a.txt");
            //long[] a = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            //long item = 232897690;

            //string[] arStr = File.ReadAllLines("10.txt");
            //long[] a = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            //long item = 923832496;


            string[] arStr = File.ReadAllLines("9.txt");
            long[] a = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            long item = 433551589;
            //long item = 12;
            //long[] a = { 4, 5, 6 };

            //long item = 5;
            //long[] a = { 2, 3 };

            //long item = 10;
            //long[] a = { 1, 3, 4 };


            //long item = 306;
            //long[] a = { 477, 448, 240, 858, 927, 703, 172, 68, 969, 943, 657, 499, 753, 777, 438, 199, 356, 435, 63, 292, 446, 164, 323, 511, 145, 607, 39, 832, 764, 692, 990, 240, 491, 581, 98, 769, 635, 621, 189, 603, 915, 197, 453, 667, 973, 890, 865, 328, 676, 928 };


            Console.WriteLine(triplets(a, item));
            Console.ReadKey();
        }

        static long triplets(long[] machines, long goal)
        {
            long days = 0;
            Console.WriteLine("Изначальное необходимое количество: {0}", goal);
            Dictionary<long, long> machinesDic = new Dictionary<long, long>();

            Array.Sort(machines);


            for (int i = 0; i < machines.Length; i++)
            {
                if (machinesDic.ContainsKey(machines[i]))
                    machinesDic[machines[i]]++;
                else
                {
                    machinesDic.Add(machines[i], 1);
                }

            }
            Console.WriteLine("Количество элементов в словаре: {0}", machinesDic.Count);
            


            
           days = FindDays(1, goal*machinesDic.First().Key/ machinesDic.First().Value, goal, machinesDic);
           

            return days;

        }

        private static long FindDays(long left, long right, long goal, Dictionary<long, long> machinesDic)
        {
            long res = (right - left) / 2 + left;
            long resMin=-1;
            
            long items=0;
            while (items != goal)
            {
                items = 0;
                foreach (var item in machinesDic.Reverse())
                {
                    if (item.Key < res)
                        items += (res / item.Key) * item.Value;
                }
                if (items > goal)
                {
                    right = res-1 ;
                }
                else if (items < goal)
                {
                    left = res+1;
                }
                else
                {
                    long m = res%machinesDic.First().Key;
                    foreach (var item in machinesDic)
                    {
                        if (m > res % item.Key)
                            m = res % item.Key;

                    }
                    return res - m;
                    
                }
                res = (right - left) / 2 + left;
                if (resMin == res)
                    return res;
                    resMin = res;
                Console.WriteLine(res);
                

            }
            return res;
        }








        private static long FindLastDays(Dictionary<long, long> dic, Dictionary<long, long> dic2, long goal, long v)
        {
            long res = v;
            long tempGoal = 1;
            long maxDays;
            foreach (var item in dic)
            {
                if (item.Value < goal)
                {
                    res = item.Key;
                    tempGoal = goal - item.Value;
                    Console.WriteLine("Прошло дней: {0}", res);
                }
                else
                {
                    maxDays = item.Key;
                    Console.WriteLine("Максимум дней: {0}", maxDays);
                    break;
                }
            }
            goal = tempGoal;
            Console.WriteLine("Оставшиеся вещи: {0}", goal);
            while (!(goal <= 0))
            {

                foreach (var item in dic2)

                {
                    if (item.Key > res)
                    {
                        break;
                    }
                    else
                    {
                        if (res % item.Key == 0)
                        {
                            goal -= item.Value;
                            if (goal <= 0)
                                break;
                        }
                    }

                }
                res++;
                Console.WriteLine("Days: {0}", res);
                Console.WriteLine("Goals: {0}", goal);
            }

            return res;
        }

        static int NearestSearching(int[] arr, int num)
        {
            int res = -1;
            int left = 0;
            int right = arr.Length - 1;

            int med = right / 2;

            while (left <= right)
            {
                if (arr[med] <= num && arr[med + 1] > num)
                    return med;
                else if (arr[med] > num)
                {
                    right = med;
                    med = left + (med - left) / 2;

                }
                else
                {
                    left = med;
                    med = med + (right - med) / 2;

                }

            }
            return res;
        }


    }
}
