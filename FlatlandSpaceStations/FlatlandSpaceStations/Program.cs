using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatlandSpaceStations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(flatlandSpaceStations(20, new int[] { 13, 1, 11, 10, 6 }));
            Console.ReadKey();
        }

        static int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int res = 0;
            int start = 0;
            int last = n - 1;
            
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] - start > res)
                    res = c[i] - start;
                start = c[i];
            }
            if (last - start > res/2 && last-start>c[0])
                return last - start;
            if (c[0] > res / 2 && last - start < c[0])
                return c[0];
            return res/2;

        }

    }
}
