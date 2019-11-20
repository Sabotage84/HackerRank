using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxarrsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 4, 6, 5 };
            Console.WriteLine(maxSubsetSum(arr));
            Console.ReadKey();
        }

        static int maxSubsetSum(int[] arr)
        {
            int res = 0;
            int oldMax;
            int newMax;
            int oldIndex;
            int newIndex;


            if (arr[0]>=arr[0]+arr[2])
            {
                oldMax = arr[0];
                oldIndex = 0;
            }
            else
            {
                oldMax = arr[0] + arr[2];
                oldIndex = 2;
            }

            if()
            
            return res;
        }
    }
}
