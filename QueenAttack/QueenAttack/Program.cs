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
            int s1200 = 0;
            int e1200 = n;
            int s1330 = r_q + c_q - n-1;
            int e1330 = n;
            int s1500 = 0;
            int e1500 = n;
            int s1030 = 0;
            int e1030 = n - (r_q - c_q);

            for (int i = 0; i < k; i++)
            {
                if (obstacles[i][0]==r_q)
                {
                    if (obstacles[i][1]>s1500 && obstacles[i][1]<c_q)
                    {
                        s1500 = obstacles[i][1];
                    }

                    else if (c_q<obstacles[i][1] && e1500>obstacles[i][1])
                    {
                        e1500 = obstacles[i][1];
                    }
                }

                if (obstacles[i][1]==c_q)
                {
                    if (obstacles[i][0]>s1200 && obstacles[i][0]<r_q)
                    {
                        s1200 = obstacles[i][0];
                    }
                    else if (obstacles[i][0]>r_q && obstacles[i][0]<e1200)
                    {
                        e1200 = obstacles[i][0];
                    }
                }

                if (obstacles[i][0]+ obstacles[i][0]==r_q+c_q)
                {

                    if (obstacles[i][0]>s1330 && obstacles[i][0]<r_q)
                    {
                        s1330 = obstacles[i][0];
                    }
                    else if (obstacles[i][0] < e1330 && obstacles[i][0] > r_q)
                    {
                        e1330 = obstacles[i][0];
                    }
                }

                if (obstacles[i][0] - obstacles[i][0] == r_q - c_q)
                {
                    if (obstacles[i][1] > s1030 && obstacles[i][1] < c_q)
                        s1330 = obstacles[i][1];
                    else if (obstacles[i][1] < e1030 && obstacles[i][1] > c_q)
                        e1030 = obstacles[i][1];
                }
            }

            res += e1030 - s1030 - 1;
            res += e1200 - s1200 - 1;
            res += e1330 - s1330 - 1;
            res += e1500 - s1500 - 1;

            return res;
        }
    }
}
