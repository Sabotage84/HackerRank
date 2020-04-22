using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forming_a_Magic_Square
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        static int formingMagicSquare(int[][] s)
        {
            int res = 0;
            if (CheckMatrix(s))
                return res;
            else
                res = CorrectMatrix();
            return res;
        }

        public static int CorrectMatrix()
        {
            throw new NotImplementedException();
        }

        public static bool CheckMatrix(int[][] s)
        {
            
            int firstLine = s[0][0] + s[0][1] + s[0][2];
            int secondLine= s[1][0] + s[1][1] + s[1][2];
            int thirdLine = s[2][0] + s[2][1] + s[2][2];

            int firstCol= s[0][0] + s[1][0] + s[2][0];
            int secondCol = s[0][1] + s[1][1] + s[2][1];
            int thirdCol = s[0][2] + s[1][2] + s[2][2];

            int firstDiag= s[0][0] + s[1][1] + s[2][2];
            int secondDiag= s[2][0] + s[1][1] + s[0][2];
            if (firstLine == secondLine && firstLine == thirdLine && firstLine == firstCol && firstLine == secondCol && firstLine == thirdCol && firstLine == firstDiag && firstLine == secondDiag)
                return true;

            return false;
        }
    }
}
