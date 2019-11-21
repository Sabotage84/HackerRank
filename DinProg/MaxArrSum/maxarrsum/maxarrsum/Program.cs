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
            
            int[,] matrix = new int[2, arr.Length];

            matrix[0, 0] = arr[0];
            matrix[0, 1] = Math.Max(matrix[0,0],arr[1]);
            matrix[0, 2] = Math.Max(matrix[0, 1], arr[2]);

            matrix[0, 3] = Math.Max(matrix[0, 2], arr[3]);
            matrix[1, 2] = arr[0] + arr[2];
            matrix[1, 3] = matrix[0, 1] + arr[3];


            for (int i = 4; i < arr.Length; i++)
            {
                matrix[0, i] = Math.Max(matrix[0, i - 1], arr[i]);
                if (arr[i] <= 0)
                {
                    matrix[1, i] = Math.Max(matrix[1, i - 2], matrix[1, i - 1]);
                    matrix[1, i - 1] = matrix[1, i];
                }
                else
                    matrix[1, i] = Math.Max(matrix[1, i - 2] + arr[i], matrix[0, i - 2] + arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(matrix[0, i] + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(matrix[1, i] + " ");

            }
            Console.WriteLine();
            return Math.Max(matrix[1, arr.Length-1],matrix[1, arr.Length-2]);
        }
    }
}
