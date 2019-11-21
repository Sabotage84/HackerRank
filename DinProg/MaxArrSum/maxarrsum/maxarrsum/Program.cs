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
            int[] C = new int[arr.Length + 2];
            C[0] = 0;
            C[1] = 0;
            if (arr[0] > 0)
                C[2] = Math.Max(arr[0], arr[0] + C[0]);
            else
                C[2] = C[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    C[i + 2] = Math.Max(C[i], C[i - 1]) + arr[i];
                else
                    C[i + 2] = Math.Max(C[i], C[i - 1]);
            }

            return Math.Max(C[C.Length - 1], C[C.Length - 2]);
        }
    }
}
