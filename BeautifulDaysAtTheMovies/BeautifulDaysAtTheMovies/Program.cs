using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 949488;
            int j = 1753821;
            int k = 5005440;
            Console.WriteLine(beautifulDays(i, j, k));
            Console.ReadKey();
        }

        static int beautifulDays(int i, int j, int k)
        {
            int res = 0;
            for (int l = i; l <=j; l++)
            {
                int t1 = l;
                int t = l;
                int t2 = 0;


                while (t / 10 != 0)
                {
                    t2 = t2 * 10 + t % 10;
                    t = t / 10;
                }
                t2 = t2 * 10 + t;
                //string s = t1.ToString();
                //char[] sReverse = s.ToCharArray();
                //Array.Reverse(sReverse);
                //int t2 = int.Parse( new string(sReverse));
                if (Math.Abs(t1 - t2) % k == 0)
                    res++;
            }
            return res;
        }
    }
}
