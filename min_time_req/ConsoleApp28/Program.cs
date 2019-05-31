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
            Console.WriteLine("Изначальное необходимое количество: {0}", goal);
            Dictionary<long, long> dic = new Dictionary<long, long>();
            Dictionary<long, long> maxDic = new Dictionary<long, long>();
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
            Console.WriteLine("Количество элементов в словаре: {0}", dic.Count);
            long maxGoalsInOnePass = 0;

            foreach (var item in dic)
            {
                maxGoalsInOnePass += item.Value;
                foreach (var it in dic)
                {
                    if (it.Key == item.Key)
                        break;
                    
                    maxGoalsInOnePass+=it.Value*(item.Key/it.Key);
                }
                maxDic.Add(item.Key, maxGoalsInOnePass);
            }
            Console.WriteLine("Максимум за один проход: {0}", maxGoalsInOnePass);

            if (maxGoalsInOnePass >= goal)
            {
                Console.WriteLine("Выполняться буден за один проход...");
                days = FindLastDays(maxDic, dic, goal,0);
            }
            else
            {
                long newGoals = goal - (goal / maxGoalsInOnePass) * maxGoalsInOnePass;
                Console.WriteLine("Новое значение предметов: {0}", newGoals);

                days = (goal / maxGoalsInOnePass) * dic.Last().Key;
                Console.WriteLine("Пройдено дней: {0}", days);
                days = FindLastDays(maxDic, dic, newGoals, days);

            }
            
            return days;

        }

        private static long FindLastDays(Dictionary<long, long> dic, Dictionary<long, long> dic2, long goal, long v)
        {
            long res = v;
            long tempGoal=1;
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
