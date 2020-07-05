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
            Console.WriteLine(taumBday(27984, 1402, 619246, 615589, 247954));
            Console.ReadKey();
        }
        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            long res = 0;
            if (wc > bc && bc + z < wc)
                res= ((long)b * (long)bc) +( (long)(bc + z) * (long)w);
            else if (bc > wc && wc + z < bc)
                res= ((long)wc * (long)w) + ((long)(wc + z) * (long)b);
            else
                res=((long)b * (long)bc) +( (long)w * (long)wc);
            return res;
            
        }
    }
}
