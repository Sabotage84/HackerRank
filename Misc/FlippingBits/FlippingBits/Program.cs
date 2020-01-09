using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            long test = 1;
            long answer = flippingBits(test);
            Console.WriteLine(answer == 4294967294);
            Console.ReadKey();
        }

        static long flippingBits(long n)
        {
            long res=0;
           
            string s= Convert.ToString(n, 2);
            string s1 = new string('0', 32 - s.Length);
            string result = s1 + s;
                                   
            Console.WriteLine(result);
            string r = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '0')
                    r += '1';
                else
                    r += '0';
            }
            Console.WriteLine(r);
            res = Convert.ToInt64(r,2);

            return res;

        }
    }
}
