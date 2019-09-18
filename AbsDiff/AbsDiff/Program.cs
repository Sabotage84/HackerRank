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
            int n = arr.Length;

        Array.Sort(arr);

        int minAbsDiff = Math.Abs(arr[0] - arr[1]);

        for(int i = 1; i < n - 1; i++){
            int tempDiff = Math.Abs(arr[i] - arr[i + 1]);
            if(tempDiff < minAbsDiff)
                minAbsDiff = tempDiff;
        }
        return minAbsDiff;
        }

        

    }
}
