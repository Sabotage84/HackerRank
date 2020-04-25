using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picking_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int pickingNumbers(List<int> a)
        {
            int res = 0;
            int[] mass = new int[100];
            foreach (var item in a)
            {
                mass[item]++;
            }
            for (int i = 0; i < mass.Length-1; i++)
            {
                if (mass[i] + mass[i + 1] > res)
                    res = mass[i] + mass[i + 1];
            }
            return res;
        }
    }
}
