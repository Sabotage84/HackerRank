using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static int utopianTree(int n)
        {
            int res = 1;
            int i = 1;
            while (i<n)
            {
                if (i % 2 == 0)
                    res++;
                else
                    res *= 2;
                i++;
            }

            return res;

        }
    }
}
