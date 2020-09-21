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
            int[][] t1 = new int[2][];
            t1[0] = new { 999336263, 998799923 };
           
998799923 999763019

        }

        static string organizingContainers(int[][] container)
        {
           
            long l = 0;
            bool flag = true;
            long n = 0;
            for (int i = 0; i < container.Length; i++)
            {
                for (int j = 0; j < container.Length; j++)
                {
                    l += container[i][j];
                    l -= container[i][i];
                    n += container[j][i];
                    n -= container[i][i];
                }
                if (l - n != 0)
                    flag = false;
                l = 0;
                n = 0;
            }
            if (flag)
                return "Possible";
            else
                return "Impossible";

        }
    }
}
