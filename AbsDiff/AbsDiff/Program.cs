using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -59, - 36, - 13, 1, - 53, - 92, - 2, - 96, - 54, 75 };
            //int[] arr = { 1, - 3, 71, 68, 17, };

            Console.WriteLine(minimumAbsoluteDifference(arr));
            Console.ReadKey();
        }

        static int minimumAbsoluteDifference(int[] arr)
        {
            int[] tarr = arr.Distinct().ToArray();
            if (tarr.Length < arr.Length)
                return 0;

            int[] sarr ;
           
           
            int res = Math.Abs(arr[0] - arr[1]);
            for (int i = 0; i < arr.Length-1; i++)
            {
                sarr = new int[arr.Length-i-1];
                Array.Copy(arr, i+1,sarr, 0,arr.Length-1-i);
                List<int> t = (sarr.ToList());
                t.Sort();
               
                sarr = t.ToArray();
                for (int k = 0; k < sarr.Length; k++)
                {
                    Console.Write(sarr[k]+" ");
                }
                Console.WriteLine();
                if (sarr[0] > arr[i])
                {
                    if (res > Math.Abs(arr[i] - sarr[0]))
                        res = Math.Abs(arr[i] - sarr[0]);
                }
                else if (sarr[sarr.Length - 1] < arr[i])
                {

                    if (res > Math.Abs(arr[i] - sarr[sarr.Length - 1]))
                        res = Math.Abs(arr[i] - sarr[sarr.Length - 1]);
                }
                else
                {
                    int temp = NearestSearching(sarr, arr[i]);
                    Console.WriteLine("For {0} nearest is {1}", arr[i], temp);
                    if (res > Math.Abs(arr[i] - temp))
                        res = Math.Abs(arr[i] - temp);
                }
            }


            return res;
        }

        static int NearestSearching(int[] arr, int num)
        {
            int res = -1;
            int left = 0;
            int right = arr.Length - 1;

            int med = right / 2;

            while (left <= right)
            {
                if (arr[med] <= num && arr[med + 1] > num)
                {
                    if (Math.Abs(num - arr[med]) < (Math.Abs(num - arr[med + 1])))
                        return arr[med];
                    else
                        return arr[med + 1];
                }
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

            }
            return res;
        }

    }
}
