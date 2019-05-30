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

            string[] arStr = File.ReadAllLines("a.txt");
            long[] a = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            long item = 232897690;
            //long[] a = { 1, 3, 4 };


            Console.WriteLine(triplets(a, item));
            Console.ReadKey();
        }

        static long triplets(long[] machines, long goal)
        {
            long days = 0;
            Dictionary<long, long> dic = new Dictionary<long, long>();
            Array.Sort(machines);


            for (int i = 0; i < machines.Length; i++)
            {
                if (dic.ContainsKey(machines[i]))
                    dic[machines[i]]++;
                else
                {
                    dic.Add(machines[i], 1);
                }

            }

            while (!(goal<= 0))
            {
                days++;
                foreach (var item in dic)
                
                {
                    if (item.Key > days)
                    {
                        Console.WriteLine("дней меньше чем число");
                        Console.WriteLine(item.Key);
                        break;
                    }
                    else
                    {
                        if (days % item.Key == 0)
                        {
                            goal -= item.Value;
                            if (goal <= 0)
                                break;
                        }
                    }

                }

            }

            return days;

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
