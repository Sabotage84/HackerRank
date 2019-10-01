using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr = { 256741038, 623958417, 467905213, 714532089, 938071625 };

            miniMaxSum(arr);
            Console.ReadKey();
        }

        static void miniMaxSum(int[] arr)
        {
            long min = arr[0], max = arr[0], sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (min > arr[i])
                    min = arr[i];
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine((sum - max) + " "+(sum - min));
        }
    }
}
