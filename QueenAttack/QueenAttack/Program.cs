using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {

            int res = 0;
            int[,] matrix = new int[n,n];
            for (int i = 0; i < k; i++)
            {
                matrix[obstacles[i][0], obstacles[i][1]] = 1;
            }

            return res;

        }
    }
}
