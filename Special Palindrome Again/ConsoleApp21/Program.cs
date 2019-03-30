using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Program
    {
        static void Main(string[] args)
        {
            long l = substrCount(8, "mnonopoo");
        }
        static public long substrCount(int n, string s)
        {
            List<CharCount> lst = new List<CharCount>();
            
            long res = 0;
            int t = 1;
            char key = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == key)
                    t++;
                else
                {
                    lst.Add(new CharCount(key, t));
                    key = s[i];
                    t = 1;
                }
                if (i==n-1)
                    lst.Add(new CharCount(key, t));

            }

            res += ArrProgr(lst[0].count);
            for (int i = 1; i < lst.Count; i++)
            {
                res += ArrProgr(lst[i].count);
                if (i <= lst.Count - 2)
                {
                    if (lst[i].count == 1 && lst[i - 1].ch == lst[i + 1].ch)
                    {
                        res += (lst[i - 1].count + lst[i + 1].count - Math.Abs(lst[i - 1].count - lst[i + 1].count)) / 2;
                    }
                }
            }
            
            return res;
        }
        class CharCount
        {
            public char ch;
            public int count;

            public CharCount(char ch, int count)
            {
                this.ch = ch;
                this.count = count;
            }
        }
        static long ArrProgr(long n)
        {
            double t = 0.5;
            t += (double)n / 2;
            t *= n;
            return (long)t;
        }
    }
}
