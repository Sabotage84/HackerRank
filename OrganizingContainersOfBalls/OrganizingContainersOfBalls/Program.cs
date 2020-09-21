using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingContainersOfBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a =  { 1, 2 };
            int[][] t1 = new int[2][];
            
           


        }

        static string organizingContainers(int[][] container)
        {
           
            long l = 0;
            bool flag = false;
            long n = 0;
            long[] pos = new long[container.Length];
            long[] need = new long[container.Length];
            for (int i = 0; i < container.Length; i++)
            {
                for (int j = 0; j < container.Length; j++)
                {
                    l += container[i][j];
                    n += container[j][i];
                }
                pos[i] = l;
                need[i] = n;
                l = 0;
                n = 0;
            }

            for (int i = 0; i < container.Length; i++)
            {
                for (int j = 0; j < container.Length; j++)
                {
                    l = pos[i] - container[i][j];
                    n = need[j] - container[i][j];
                    if (l-n==0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    l = 0;
                    n = 0;
                    flag = false;
                }
                else
                {
                    return "Impossible";
                }
            }

            return "Possible";

        }
    }
}
