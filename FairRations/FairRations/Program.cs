using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairRations
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string fairRations(int[] B)
        {

            int res = 0;
            if (B[0] % 2 != 0)
            {
                B[0]++; B[1]++;
                res += 2;
            }
            for (int i = 1; i < B.Length; i++)
            {
                if (B[i] % 2 != 0)
                {
                    if (i == B.Length - 1)
                    {
                        return "NO";
                    }
                    B[i]++; B[i + 1]++;
                    res += 2;
                }

            }

            return res.ToString();
        }

    }
}
