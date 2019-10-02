using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "06:40:03AM";
            Console.WriteLine(timeConversion(str));
            Console.ReadKey();
        }

        static string timeConversion(string s)
        {
            string res = "";
            if (s.Substring(8, 2) == "AM")
            {
                int r = int.Parse(s.Substring(0, 2));
                if (r == 12)
                    return "00" + s.Substring(2, s.Length - 4);
                return s.Substring(0, s.Length - 2);
            }

            int t = int.Parse(s.Substring(0, 2));
            if (t == 12)
                t = 0;

            t += 12;
            res = t.ToString() + s.Substring(2, s.Length - 4);

            return res;
        }

    }
}
