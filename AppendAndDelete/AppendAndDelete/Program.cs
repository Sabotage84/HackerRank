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
            Console.WriteLine(appendAndDelete("hackerhappy", "hackerrank", 9));
            Console.ReadKey();
        }

        static string appendAndDelete(string s, string t, int k)
        {
            int r = -1;
            if (s == t)
                r = s.Length;
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i < t.Length)
                    {
                        if (s[i] != t[i])
                        {
                            r = i;
                            break;
                        }
                    }
                    else
                    {
                        r = t.Length;
                        break;
                    }
                }
            }
            if (r == -1)
                r = s.Length;
            int d = t.Length - r+s.Length-r;
            if (d > k)
                return "No";
            else if ((k - d) % 2 == 0)
                return "Yes";
            else if ((k - d) >= s.Length + t.Length)
                return "Yes";
            else if (k >= s.Length + t.Length)
                return "Yes";
            else
                return "No";

        }
    }
}
