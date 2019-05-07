using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 5, 3, 4, 2 };
            int k = 204619;
            string[] arStr = File.ReadAllLines("test1.txt");
            int[] arr = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine(pairs(k, arr));
            Console.ReadKey();
        }

        public static int pairs(int k, int[] arr)
        {
            int res = 0;
            SortedList<long,int> expListPlus = new SortedList<long, int>();
            SortedList<long, int> expListMinus = new SortedList<long, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(expListPlus.ContainsKey(arr[i]))
                {
                    res++;
                    expListPlus.Remove(arr[i]);
                }
                else
                {
                    if(arr[i] - k>0)
                        expListMinus.Add(arr[i] - k,1);
                }
                if(expListMinus.ContainsKey(arr[i]))
                {
                    res++;
                    expListMinus.Remove(arr[i]);
                }
                else
                {
                    if (arr[i] + k<int.MaxValue)
                        expListPlus.Add(arr[i] + k,1);
                }
                Console.WriteLine(expListPlus.Count + " " + expListMinus.Count);
                
            }

            return res;
        }

    }
}
