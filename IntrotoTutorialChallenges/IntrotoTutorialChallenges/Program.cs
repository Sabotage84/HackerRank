using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoTutorialChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int introTutorial(int V, int[] arr)
        {
            int res = 0;
            int left = 0;
            int right = arr.Length - 1;
            int med ;
            while (true)
            {
                med = left+ (right - left) / 2;
                if (arr[med] > V)
                {
                    right = med;
                }
                else if (arr[med] < V)
                {
                    left = med+1;
                }
                else
                    return med;

                

            }

            return res;
        }
    }
}
