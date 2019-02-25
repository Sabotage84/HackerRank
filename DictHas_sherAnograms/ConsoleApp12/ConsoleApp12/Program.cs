using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "abbaqiofhuliqnfdnvgfkaweiucntyemvtuorgmqieytqwdfscvvakrtjhqwnbwdrtqwuirtixmcbnvuieytgcmbnvavemgqwgfj";
            //string s1 = "abba";
            string s1 = "kkkk";
            char[] ch1 = s1.ToCharArray();
            //char[] ch2 = s2.ToCharArray();
            List<string> ls = new List<string>();
            int res = 0;
            //Array.Sort(ch2);
            for (int i = 1; i < s1.Length; i++)
            {
                for (int j = 0; j+i <= s1.Length; j++)
                {
                    Char[] temp = (s1.Substring(j, i)).ToCharArray();
                    Array.Sort(temp);
                    string t2 =new string(temp);
                    Console.WriteLine(t2);
                    if (ls.Contains(t2))
                    {
                        List<string> found = ls.FindAll(item => t2 == item);
                        res+=found.Count;
                        ls.Add(t2);
                    }
                    else
                        ls.Add(t2);
                }
                
            }


            //Console.WriteLine("Количество строк всего: "+s1.Length);
            Console.WriteLine("Количество анограм: " + res);
            //Console.WriteLine("String - {0}, hash - {1}", s1, ch1.GetHashCode());
            //Console.WriteLine("String - {0}, hash - {1}", s2, ch2.GetHashCode());



            Console.ReadKey();
        }
    }
}
