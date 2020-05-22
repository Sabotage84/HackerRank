using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingontheClouds_Revisited
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int jumpingOnClouds(int[] c, int k)
        {
            int res = 100;
            int i= 0;
            while (true)
            {
                if ((i+k)%(c.Length-1)==0)
                {
                    i = c.Length - 1;
                }
                else
                {
                    i = (i + k) % (c.Length - 1);
                }
                if (c[i] == 1)
                    res -= 3;
                else
                    res--;
                if (i==0)
            }

            return res;
        }
    }
}
