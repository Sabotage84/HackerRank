using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 4, 3, 5, 2, 6, 4, 5 };

            int[] B = { 2, 4, 2, 6, 1, 7, 8, 9, 2, 1 };

            int[] C = { 9, 8, 7, 7, 6, 6, 5, 4, 3 };
            StreamReader sr = new StreamReader("test2.txt");
            
            int[] D = new int[int.Parse(sr.ReadLine())];
            for (int i = 0; i < D.Length; i++)
            {
                D[i]=int.Parse(sr.ReadLine());
            }
            sr.Close();


            //Console.WriteLine(candies(A.Length, A));
            Console.WriteLine(candies(A.Length, D));


            Console.ReadKey();
        }

        static long candies(int n, int[] arr)
        {
            long res = 0;
            long[] t = new long[arr.Length];
            t[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                    t[i] = t[i - 1] + 1;
                else
                    t[i] = 1;
            }

            for (int i = arr.Length - 2; i > -1; i--)
            {
                if (arr[i] > arr[i + 1] && t[i]<=t[i+1])
                    t[i] = t[i + 1] + 1;
               


            }

            for (int i = 0; i < t.Length; i++)
            {
                res += t[i];
            }

            return res;
        }

        
    }
}
