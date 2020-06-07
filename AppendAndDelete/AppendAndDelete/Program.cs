using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendAndDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(appendAndDelete("ab", "abf", 0));
            Console.ReadKey();
        }

        static string appendAndDelete(string s, string t, int k)
        {
            int op = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    op += s.Length - i;
                    op += t.Length - i;
                    break;
                }

            }
            if (op == 0)
                op += t.Length - s.Length;
            if (op > k)
                return "NO";
            else
                return "YES";

        }
    }
}
