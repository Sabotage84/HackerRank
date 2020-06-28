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
            Console.WriteLine(queensAttack(4, 0, 4, 4, new int[0][]));

            Console.WriteLine(queensAttack(100000, 0, 4187, 5068, new int[0][]));


            Console.ReadLine();

        }

        static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {
            int res = 0;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < k; i++)
            {
                matrix[obstacles[i][0]-1, obstacles[i][1]-1] = 1;
            }

            for (int i = c_q-2; i >= 0; i--)
            {
                if (matrix[r_q-1, i] == 0)
                    res++;
                else
                    break;
            }

            for (int i = c_q; i < n; i++)
            {
                if (matrix[r_q-1, i] == 0)
                    res++;
                else
                    break;
            }

            for (int i = r_q-2; i >=0; i--)
            {
                if (matrix[i, c_q-1] == 0)
                    res++;
                else
                    break;
            }

            for (int i = r_q ; i <n; i++)
            {
                if (matrix[i, c_q-1] == 0)
                    res++;
                else
                    break;
            }

            for (int i = r_q-2, j=c_q-2; i >=0 && j>=0; i--,j--)
            {
                if (matrix[i, j] == 0)
                    res++;
                else
                    break;
            }

            for (int i = r_q - 2, j = c_q ; i >= 0 && j<n; i--, j++)
            {
                if (matrix[i, j] == 0)
                    res++;
                else
                    break;
            }

            for (int i = r_q , j = c_q ; i < n && j < n; i++, j++)
            {
                if (matrix[i, j] == 0)
                    res++;
                else
                    break;
            }

            for (int i = r_q , j = c_q - 2; i < n && j >= 0; i++, j--)
            {
                if (matrix[i, j] == 0)
                    res++;
                else
                    break;
            }

            return res;
        }
    }
}
