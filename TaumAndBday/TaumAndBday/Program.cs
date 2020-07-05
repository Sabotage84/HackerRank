using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaumAndBday
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            long res = 0;
            if (wc > bc && bc + z < wc)
                res= b * bc + (bc + z) * w;
            else if (bc > wc && wc + z < bc)
                res= wc * w + (wc + z) * b;
            else
                res= b * bc + w * wc;
            return res;
            
        }
    }
}
