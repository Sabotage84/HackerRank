using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 6, 3, 5, 2 };
            int j = 4;
            Console.WriteLine(hurdleRace(j, ar));
            Console.ReadKey();
        }
        static int hurdleRace(int k, int[] height)
        {
            int res = height[0];
            for (int i = 0;   i <height.Length;  i++)
            {
                if (res < height[i])
                    res = height[i];
            }

            if (res < k)
                return 0;
            else
                return res-k;
        }


    }
}
