using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 4, 2 };
            Console.WriteLine(pairs(2, arr));
            Console.ReadKey();
        }

        static int pairs(int k, int[] arr)
        {
            int res = 0;
            List<long> expList = new List<long>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < k)
                {
                    if (expList.Contains(arr[i]))
                    { 
                        res+=expList.FindAll(p => p == arr[i]).Count;
                    }
                    expList.Add(arr[i] + k);

                }
                else if (arr[i]+k>int.MaxValue)
                {
                    if (expList.Contains(arr[i]))
                        res += expList.FindAll(p => p == arr[i]).Count;

                    expList.Add(arr[i] - k);
                    
                }
                else
                {
                    if (expList.Contains(arr[i]))
                        res += expList.FindAll(p => p == arr[i]).Count;
                   
                        expList.Add(arr[i] - k);
                        expList.Add(arr[i] + k);
                    
                }

              
                
            }

            return res;
        }

    }
}
