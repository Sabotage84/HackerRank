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
            return Math.Max(foo(arr), foo(arr.Reverse().ToArray()));
        }

        static long foo(int[] arr)
        {
            long res = 0;
            long[,] candiesArr = new long[2, arr.Length];

            if (arr[0] < arr[1])
            {
                candiesArr[0, 1] = 1;
                candiesArr[1, 0] = 1;
                candiesArr[1, 1] = 2;

            }
            else if (arr[0] > arr[1])
            {
                candiesArr[0, 1] = 0;
                candiesArr[1, 0] = 1;
                candiesArr[1, 1] = 2;
            }
            else
            {
                candiesArr[0, 1] = 3;
                candiesArr[1, 0] = 1;
                candiesArr[1, 1] = 1;
            }



            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {

                    if (candiesArr[0, i - 1] == 1)
                    {
                        candiesArr[0, i] = 1;
                        candiesArr[1, i] = candiesArr[1, i - 1] + 1;
                    }
                    else if (candiesArr[0, i - 1] == 0)
                    {
                        candiesArr[1, i] = 1;

                        if (i + 1 <= arr.Length - 1)
                        {
                        
                            if (arr[i] < arr[i + 1])
                            {    
                                candiesArr[1, i + 1] = 2;
                                candiesArr[0, i + 1] = 1;
                            }
                            else if(arr[i] > arr[i + 1])
                            {
                                candiesArr[1, i + 1] = 2;
                                candiesArr[0, i + 1] = 0;
                            }
                            else
                            {
                                candiesArr[1, i + 1] = 1;
                                candiesArr[0, i + 1] = 3;
                            }
                        }
                        i++;
                    }
                    else
                    {
                        candiesArr[0, i] = 1;
                        candiesArr[1, i] = candiesArr[1, i - 1] + 1;
                    }
                }
                else if (arr[i] < arr[i - 1])
                {

                    if (candiesArr[0, i - 1] == 0)
                    {
                        candiesArr[0, i] = 0;
                        candiesArr[1, i] = candiesArr[1, i - 1] + 1;
                    }
                    else if (candiesArr[0, i - 1] == 1)
                    {
                        candiesArr[1, i] = 1;

                        if (i + 1 <= arr.Length - 1)
                        {

                            if (arr[i] < arr[i + 1])
                            {
                                candiesArr[1, i + 1] = 2;
                                candiesArr[0, i + 1] = 1;
                            }
                            else if (arr[i] > arr[i + 1])
                            {
                                candiesArr[1, i + 1] = 2;
                                candiesArr[0, i + 1] = 0;
                            }
                            else
                            {
                                candiesArr[1, i + 1] = 1;
                                candiesArr[0, i + 1] = 3;
                            }
                        }
                       
                        i++;

                    }
                    else
                    {
                        candiesArr[0, i] = 0;
                        candiesArr[1, i] = candiesArr[1, i - 1] + 1;
                    }
                }
                else
                {
                    candiesArr[0, i] = 3;
                    candiesArr[1, i] = 1;
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(candiesArr[1, i]);
                res += candiesArr[1, i];
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(res);
            return res;
        }
    }
}
