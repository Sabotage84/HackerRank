using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kangaroo(100,1,0,3));
            Console.ReadKey();
        }
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
           
            if (x1>x2)
            {
                int vx = v2 - v1;
                if (vx <= 0)
                    return "NO";
                else
                {
                    if ((x1 - x2) % vx != 0)
                        return "NO";
                    else
                        return "YES";
                }
            }
            else if (x2>x1)
            {
                int vx = v1 - v2;
                if (vx <= 0)
                    return "NO";
                else
                {
                    if ((x2 - x1) % vx != 0)
                        return "NO";
                    else
                        return "YES";
                }

            }
            else
            {
                if (v1 != v2)
                    return "NO";
                else
                    return "YES";
            }

           
        }
    }
}
