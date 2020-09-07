using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static long strangeCounter(long t)
        {
            long t1 = 3;
            long time = 0;
            while (time+t1<t)
            {
                time += t1;
                t1 *= 2;
            }
            return t1 - (t - time)+1;

           
        }
    }
}
