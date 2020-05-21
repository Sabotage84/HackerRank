using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1,2,3,4,5,6,7};
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            A = circularArrayRotation(A, 3, A);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }

        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] temp = new int[a.Length];
            int[] res = new int[queries.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + k)%a.Length < a.Length)
                    temp[(i + k)%a.Length] = a[i];
                else
                    temp[(i + k)%a.Length - a.Length] = a[i];
            }
            
            for (int i = 0; i < queries.Length; i++)
            {
                res[i] = temp[queries[i]];
            }
            return res;

        }
    }
}
