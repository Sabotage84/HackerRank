using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_nearest_clone
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1 2 1 1";
            long[] ids = Array.ConvertAll(s.Split(' '), idsTemp => Convert.ToInt64(idsTemp));
            Console.WriteLine(ids.Length);
            Console.ReadLine();
        }

        static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            int res = 1;
            long tempVal = val;
            int tempRes = 0;
            for (int i = 0; i < ids.Length; i++)
            {
                if (tempVal == ids[i])
                    tempRes++;
            }
            if (tempRes >= 2)
                return res;
            else
                return -1;
        }

    }
}
