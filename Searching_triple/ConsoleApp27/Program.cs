using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arStr = File.ReadAllLines("a.txt");
            int[] a = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt32(arrTemp));


            arStr = File.ReadAllLines("b.txt");
            int[] b = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            arStr = File.ReadAllLines("c.txt");
            int[] c = Array.ConvertAll(arStr[0].Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine(triplets(a, b, c));
            Console.ReadKey();
        }

        static long triplets(int[] a, int[] b, int[] c)
        {
            long res = 0;

            Array.Sort(a);
            var temp_a = a.Distinct();
            a = temp_a.ToArray();

            Array.Sort(c);
            var temp_c = c.Distinct();
            c = temp_c.ToArray();

            var temp_b = b.Distinct();
            b = temp_b.ToArray();


            for (int i = 0; i < b.Length; i++)
            {
                long t1 = 0, t2 = 0;
                if (b[i] >= a[0] && b[i] >= c[0])
                {
                    if (b[i] >= a[a.Length - 1])
                        t1 = a.Length;
                    else
                    {
                        t1 = NearestSearching(a, b[i]) + 1;
                    }
                    if (b[i] >= c[c.Length - 1])
                        t2 = c.Length;
                    else
                    {
                        t2 = NearestSearching(c, b[i]) + 1;
                    }
                    res += t1 * t2;
                }
            }


            return res;

        }

        static int NearestSearching(int[] arr, int num)
        {
            int res = -1;
            int left = 0;
            int right = arr.Length - 1;
            //bool founded = false;
            int med = right / 2;

            while (left <= right)
            {
                if (arr[med] <= num && arr[med + 1] > num)
                    return med;
                else if (arr[med] > num)
                {
                    right = med;
                    med = left + (med - left) / 2;

                }
                else
                {
                    left = med;
                    med = med + (right - med) / 2;

                }
                //Console.WriteLine(med);
            }
            return res;
        }


    }
}
