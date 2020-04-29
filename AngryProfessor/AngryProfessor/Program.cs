using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string angryProfessor(int k, int[] a)
        {
            int t = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                    t++;
            }
            if (t < k)
                return "YES";
            else
                return "NO";
        }

    }
}
