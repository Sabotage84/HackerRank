using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(encryption("chillout") == "fto ehg ee dd");

            Console.ReadKey();
        }

        static string encryption(string s)
        {
            string res = "";
            char[,] matrix;
            if (((int)Math.Floor(Math.Sqrt(s.Length))*(int)Math.Ceiling(Math.Sqrt(s.Length)))>=s.Length)
                matrix = new char[(int)Math.Floor(Math.Sqrt(s.Length)), (int)Math.Ceiling(Math.Sqrt(s.Length))];
            else
            {
                matrix=new char[(int)Math.Ceiling(Math.Sqrt(s.Length)), (int)Math.Ceiling(Math.Sqrt(s.Length))];
            }
            int k = 0;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (k < s.Length)
                    {
                        matrix[i, j] = s[k];
                        k++;
                    }
                    else
                        break;
                }
            }

            for (int i = 0; i < matrix.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(0) + 1; j++)
                {
                    if (matrix[j, i]!='\0')
                        res += matrix[j, i];
                }
                res += " ";
            }
            res=res.Trim();
            return res;
        }
    }
}
