﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arStr = File.ReadAllLines("all2.txt");
            int t = Convert.ToInt32(arStr[0]);

            int monInd = 1;
            for (int tItr = 0; tItr < t; tItr++, monInd += 3)
            {
                int money = Convert.ToInt32(arStr[monInd]);

                string[] nm = arStr[(tItr + 1)*3].Split(' ');
                int[] cost = new int[nm.Length];
                for (int i = 0; i < cost.Length; i++)
                {
                    if (!string.IsNullOrEmpty(nm[i]))
                    {
                        cost[i] = int.Parse(nm[i]);
                    }
                }
                    //Array.ConvertAll(arStr[tItr + 3].Split(' '), costTemp => Convert.ToInt32(costTemp));

                whatFlavors(cost, money);
                //int m = 412242546;
                //string[] arStr = File.ReadAllLines("test2.txt");


                //string[] nm = arStr[0].Split(' ');
                //int[] arr = new int[nm.Length];
                //for (int i = 0; i < nm.Length; i++)
                //{
                //    //Console.WriteLine(nm[i]);
                //    arr[i] = int.Parse(nm[i]);
                //}
            }
            Console.ReadKey();
        }

        static void whatFlavors(int[] cost, int money)
        {
            int id1=-1, id2=-1;
            for (int i = 0; i < cost.Length; i++)
            {
                int temp = money - cost[i];
                int tempMin = int.MaxValue;
                for (int j = i+1; j < cost.Length; j++)
                {
                    if(cost[j]==temp)
                    {
                        id1 = i;
                        id2 = j;
                        Console.WriteLine("{0} {1} ", id1 + 1, id2 + 1);
                        return;
                    }
                    else
                    {
                        if(tempMin>(money-cost[i]-cost[j]) && (money - cost[i] - cost[j])>0)
                        {
                            tempMin = money - cost[i] - cost[j];
                            id1 = i;
                            id2 = j;
                        }
                    }

                }
            }
            Console.WriteLine("{0} {1} ", id1+1,id2+1);
        }
    }
}
