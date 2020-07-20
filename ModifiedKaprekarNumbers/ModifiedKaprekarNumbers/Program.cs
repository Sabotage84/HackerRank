using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            kaprekarNumbers(1, 99999);
            Console.ReadKey();
        }

        static void kaprekarNumbers(int p, int q)
        {
            List<int> res = new List<int>();

            for (int i = p; i <= q; i++)
            {
                if (IsKaprekar(i))
                    res.Add(i);
            }

            if (res.Count == 0)
                Console.WriteLine("INVALID RANGE");
            else
                foreach (var item in res)
                {
                    Console.Write(item + " ");
                }
        }

        public static bool IsKaprekar(int a)
        {
            long sq = (long)a * (long)a;
            string s = sq.ToString();
            int r = 0;
            int l = 0;

            if (s.Length < 2)
            {
                r = int.Parse(s);
            }
            else
            {
                r = int.Parse(s.Substring(s.Length-a.ToString().Length));               
                l = int.Parse(s.Substring(0, s.Length - (a.ToString().Length)));
            }
            if (l + r == a)
                return true;
            else 
                return false;
        }
    }
}
