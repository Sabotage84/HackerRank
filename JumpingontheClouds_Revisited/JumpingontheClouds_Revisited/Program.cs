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
            int[] c = { 0, 0, 1, 0, 0, 1, 1, 0 };
            int k = 2;
            Console.WriteLine(jumpingOnClouds(c, k));
            Console.ReadKey();
        }

        static int jumpingOnClouds(int[] c, int k)
        {
            int res = 100;
            int i= 0;
            while (true)
            {
                if ((i+k)>c.Length-1)
                {
                    i = i + k - c.Length;
                    if (i==0)
                    {
                        if (c[i] == 1)
                            res -= 3;
                        else
                            res--;
                        break;
                    }
                }
                else
                {
                    i = i + k;
                }
                 
                
                if (c[i] == 1)
                    res -= 3;
                else
                    res--;
                
            }

            return res;
        }
    }
}
