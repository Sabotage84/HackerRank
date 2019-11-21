using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxarrsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 500,1,-8,1,500 };

            //StreamReader sr = new StreamReader("test2.txt");
            //string s = sr.ReadLine();

            //int[] arr = Array.ConvertAll(s.Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine(maxSubsetSum(arr));
            Console.ReadKey();
        }

        static int maxSubsetSum(int[] arr)
        {
            int[] C = new int[arr.Length];
            C[0] = arr[0];
            C[1] = arr[1];
            if (arr[2] > 0)
                C[2] = Math.Max(arr[2], arr[2] + C[0]);
            else
                C[2] = C[0];
            for (int i = 3; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    C[i] = Math.Max(C[i - 2], C[i - 3]) + arr[i];
                else
                    C[i] = Math.Max(C[i - 2], C[i - 3]);
            }

            return Math.Max(C[C.Length - 1], C[C.Length - 2]);
        }
    }
}
