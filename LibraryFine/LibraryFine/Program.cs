using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFine
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {

            if (y2 < y1)
                return 10000;
            else if (m2 < m1 && y2==y1)
                return 500 * (m1 - m2);
            else if (d2 < d1 && m1==m2 && y2==y1 )
                return 15 * (d1 - d2);
            else
                return 0;

            

        }
    }
}
