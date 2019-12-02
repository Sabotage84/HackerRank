using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abcCaeCAccRkkKkkR";
            string b = "CCARKR";
            Console.WriteLine(abbreviation(a, b));
            Console.ReadKey();
        }

        static string abbreviation(string a, string b)
        {
            if (MYabbreviation(a,b))
                return "YES";
            else
                return "NO";
        }

        static bool MYabbreviation(string a, string b)
        {
            if (a.Length == 0 && b.Length == 0)
                return true;
            else if (a.Length == 0 && b.Length != 0)
                return false;
            if (b.Length==0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsUpper(a[i]))
                        return false;
                }
                return true;
            }
            else
            {
                if (a.Last() == b.Last())
                    return MYabbreviation(a.Substring(0, a.Length - 1), b.Substring(0, b.Length - 1));
                else if (char.ToUpper(a.Last()) == b.Last())
                {
                    return (MYabbreviation(a.Substring(0, a.Length - 1), b.Substring(0, b.Length)) || MYabbreviation(a.Substring(0, a.Length - 1), b.Substring(0, b.Length - 1)));
                }
                else if (char.IsUpper(a.Last()))
                {
                    return false;
                }
                else
                {
                    return MYabbreviation(a.Substring(0, a.Length - 1), b.Substring(0, b.Length));
                }
            }
           
        }


    }
}
