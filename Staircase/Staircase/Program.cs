using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            staircase(10);
            Console.ReadKey();
        }

        static void staircase(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                Console.Write(new string(' ', n-i));
                Console.WriteLine(new string('#', i));
            }

        }
    }
}
