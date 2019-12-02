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
            string a = "Pi";
            string b = "P";
            Console.WriteLine(abbreviation(a, b));
            Console.ReadKey();
        }

        static string abbreviation(string a, string b)
        {
            bool[,] matrix = new bool[b.Length+1 , a.Length+1];
            matrix[0, 0] = true;
            bool flag = true;
            for (int i = 1; i < a.Length+1; i++)
            {
                if (flag &&  char.IsLower(a[i-1]))
                {
                    matrix[0, i] = true;
                }
                else
                {
                    matrix[0, i] = false;
                    flag = false;
                }
            }

            for (int i = 1; i < b.Length+1; i++)
            {
                matrix[i, 0] = false;
            }

            for (int i = 1; i < b.Length+1; i++)
            {
                for (int j = i; j < a.Length+1; j++)
                {
                    if(char.IsUpper(a[j-1]))
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] && b[i-1] == a[j-1];
                    }
                    else
                    {
                        matrix[i, j] = (matrix[i, j - 1] || (matrix[i-1,j-1] && b[i-1]==char.ToUpper(a[j-1])));
                    }
                }
            }

            for (int i = 0; i < b.Length+1; i++)
            {
                for (int j = 0; j < a.Length+1; j++)
                {

                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
                if (matrix[b.Length, a.Length] == true)
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
