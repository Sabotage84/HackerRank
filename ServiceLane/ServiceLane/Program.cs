using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int[] serviceLane(int n, int[][] cases, int[] width)
        {
            int[] res = new int[cases.Length];
            for (int i = 0; i < cases.Length; i++)
            {
                int min = width[cases[i][0]];
                for (int j = cases[i][0]+1; j <= cases[i][1]; j++)
                {
                    if (min > width[j])
                        min = width[j];
                }
                res[i] = min;
            }

            return res;
        }
    }
}
