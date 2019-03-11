using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "cde";
            string b = "abc";
            int res = 0;
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            Dictionary<char, int> d2 = new Dictionary<char, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (d1.ContainsKey(a[i]))
                    d1[a[i]]++;
                else
                    d1.Add(a[i], 1);
            }

            for(int i = 0; i < b.Length; i++)
            {
                if (d2.ContainsKey(b[i]))
                    d2[b[i]]++;
                else
                    d2.Add(b[i], 1);
            }

            foreach (var item in d1)
            {
                if (d2.ContainsKey(item.Key))
                {
                    res += Math.Abs(d2[item.Key] - item.Value);
                    d2.Remove(item.Key);
                }
                else
                {
                    res += item.Value;
                }
            }

            foreach (var item in d2)
            {
                res += item.Value;
            }

            //SortedSet<char> s1 = new SortedSet<char>("fcrxzwscanmligyxyvym");
            //SortedSet<char> s3 = new SortedSet<char>("fcrxzwscanmligyxyvym");
            //SortedSet<char> s2 = new SortedSet<char>("jxwtrhvujlmrpdoqbisbwhmgpmeoke");
            //ShowColl(s1);
            //ShowColl(s2);
            //s1.ExceptWith(s2);
            //ShowColl(s1);
            //Console.WriteLine(s1.Count);

            //s2.ExceptWith(s3);
            //ShowColl(s2);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static void ShowColl(SortedSet<char> ss)
        {
            
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
    }
}
