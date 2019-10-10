using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 1, 3, 2 };
            int d = 3;
            int m = 2;
           
            Console.WriteLine( birthday(arr, d, m));
            Console.ReadKey();
        }

        static int birthday(List<int> s, int d, int m)
        {
            int res = 0;

            for (int i = 0; i < s.Count; i++)
            {
                int sum = 0;
                for (int j = i, k = 1 ; j < s.Count && k<=m; j++,k++)
                {
                    sum += s[j];
                }
                if (sum == d)
                    res++;
            }

            return res;
        }
    }
}
