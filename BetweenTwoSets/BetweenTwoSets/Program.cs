using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            int res = 0;
            a.Sort();
            b.Sort();
            for (int i = a.Last(); i <= b.First(); i+=a.Last())
            {
                bool f1 = true, f2 = true;
                foreach (var item in a)
                {
                    if (i % item != 0)
                        f1 = false;
                }
                foreach (var item in b)
                {
                    if (item % i != 0)
                        f2 = false;
                }
                if (f1 && f2)
                    res++;
            }


            return res;
        }

    }
}
