using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greedyMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int maxMin(int k, int[] arr)
        {
           
            Array.Sort(arr);
            int res = arr[k-1]-arr[0];
            for (int i = 0, j=k-1; j<arr.Length; i++, j++)
            {
                if (arr[j] - arr[i] < res)
                    res = arr[j] - arr[i];

            }
            return res;
        }

    }
}
