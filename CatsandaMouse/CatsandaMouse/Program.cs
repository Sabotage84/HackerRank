using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsandaMouse
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(z - x) < Math.Abs(z - y))
                return "Cat A";
            else if (Math.Abs(z - x) == Math.Abs(z - y))
                return "Mouse C";
            else
                return "Cat B";

        }
    }
}
