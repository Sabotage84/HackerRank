using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t1= { 4, 3, 5, 1, 2 };
            int[] r= permutationEquation(t1);
            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i] + " ");
            }
            Console.ReadKey();
        }
        static int[] permutationEquation(int[] p)
        {
            int[] res = new int[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                int t = i + 1;
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j]==t)
                    {
                        for (int k = 0; k < p.Length; k++)
                        {
                            if (p[k] == j+1)
                                res[i] = k+1;
                        }
                    }
                }
            }


            return res;

        }
    }
}
