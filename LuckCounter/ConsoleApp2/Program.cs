using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            arr[0] = new int[2];
            arr[1] = new int[2];
            arr[2] = new int[2];
            arr[3] = new int[2];
            arr[4] = new int[2];
            arr[5] = new int[2];


            arr[0][0] = 5; arr[0][1] = 1;
            arr[1][0] = 2; arr[1][1] = 1;
            arr[2][0] = 1; arr[2][1] = 1;
            arr[3][0] = 8; arr[3][1] = 1;
            arr[4][0] = 10; arr[4][1] = 0;
            arr[5][0] = 5; arr[5][1] = 0;

            Console.WriteLine(luckBalance(3,arr));
            Console.ReadKey();

        }

        static int luckBalance(int k, int[][] contests)
        {
            int res = 0;
            List<int> temp = new List<int>();
            for (int i = 0; i < contests.Length; i++)
            {
                if (contests[i][1] == 0)
                    res += contests[i][0];
                else
                    temp.Add(contests[i][0]);
            }

            temp.Sort();
            temp.Reverse();

            int r = 0;

            foreach (var item in temp)
            {
                if (r < k)
                    res += item;
                else
                    res -= item;
                r++;
            }

            return res;

        }

    }
}
