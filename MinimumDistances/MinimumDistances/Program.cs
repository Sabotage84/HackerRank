using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDistances
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int minimumDistances(int[] a)
        {
            int res = a.Length;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if(a[i]==a[j])
                    {
                        if (j - i < res)
                            res = j - i;
                        break;
                    }
                }
            }
            if (res == a.Length)
                res = -1;
            return res;
        }
    }
}
