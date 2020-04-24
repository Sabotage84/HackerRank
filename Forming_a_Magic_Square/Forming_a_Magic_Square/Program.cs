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
                res = CorrectMatrix(s);
            return res;
        }

        public static int CorrectMatrix(int[][] s)
        {
            int res = 0;



            #region dif realisation
            //res += Math.Abs(5 - s[2][2]);

            //find 9 position
            //int t1 = Math.Abs(Math.Min(s[0][1], s[2][1]) - 1) + Math.Abs(Math.Max(s[0][1], s[2][1]) - 9);
            //int t2 = Math.Abs(Math.Min(s[1][0], s[1][2]) - 1) + Math.Abs(Math.Max(s[1][0], s[1][2]) - 9);
            //if (t1 < t2)
            //{
            //    if (s[0][1] >= s[2][1])
            //    {
            //        res += Math.Abs(9 - s[0][1]);
            //        res += Math.Abs(1 - s[2][1]);
            //        s[0][1] = 9;
            //        s[2][1] = 1;
            //        res += FindAllMatrix(s,0,1);
            //    }
            //    else
            //    {
            //        res += Math.Abs(1 - s[0][1]);
            //        res += Math.Abs(9 - s[2][1]);
            //        s[0][1] = 1;
            //        s[2][1] = 9;
            //        res += FindAllMatrix(s,2,1);
            //    }
            //}
            //else if(t1>t2)
            //{
            //    if (s[1][0] >= s[1][2])
            //    {
            //        res += Math.Abs(9 - s[1][0]);
            //        res += Math.Abs(1 - s[1][2]);
            //        s[1][0] = 9;
            //        s[1][2] = 1;
            //        res += FindAllMatrix(s,1,0);
            //    }
            //    else
            //    {
            //        res += Math.Abs(1 - s[1][0]);
            //        res += Math.Abs(9 - s[1][2]);
            //        s[1][0] = 1;
            //        s[1][2] = 9;
            //        res += FindAllMatrix(s,1,2);
            //    }
            //}
            #endregion

            #region stupid realisation
            List<int[][]> matrixs = new List<int[][]>();
            int[][] s1 =
                {
                    new int[] { 4, 9, 2},
                    new int[] { 3, 5, 7},
                    new int[] { 8, 1, 6}
                };

            matrixs.Add(s1);
            int[][] s2 =
                {
                    new int[] { 2, 9, 4},
                    new int[] { 7, 5, 3},
                    new int[] { 6, 1, 8}
                };
            int[][] s3 =
                {
                    new int[] { 8, 1, 6},
                    new int[] { 3, 5, 7},
                    new int[] { 4, 9, 2}
                };
            int[][] s4 =
                {
                    new int[] { 6, 1, 8},
                    new int[] { 7, 5, 3},
                    new int[] { 2, 9, 4}
                };
            int[][] s5 =
                {
                    new int[] { 4, 3, 8},
                    new int[] { 9, 5, 1},
                    new int[] { 2, 7, 6}
                };
            int[][] s6 =
                {
                    new int[] { 2, 7, 6},
                    new int[] { 9, 5, 1},
                    new int[] { 4, 3, 8}
                };

            int[][] s7 =
                {
                    new int[] { 6, 7, 2},
                    new int[] { 1, 5, 9},
                    new int[] { 8, 3, 4}
                };
            int[][] s8 =
                {
                    new int[] { 8, 3, 4},
                    new int[] { 1, 5, 9},
                    new int[] { 6, 7, 2}
                };
            matrixs.Add(s2);
            matrixs.Add(s3);
            matrixs.Add(s4);
            matrixs.Add(s5);
            matrixs.Add(s6);
            matrixs.Add(s7);
            matrixs.Add(s8);

            res = SubtractMatrix(s, matrixs[0]);
            #endregion
            foreach (var item in matrixs)
            {
                if (res > SubtractMatrix(s, item))
                    res = SubtractMatrix(s, item);
            }

            return res;
        }

        private static int FindAllMatrix(int[][] s, int v1, int v2)
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

        public static int SubtractMatrix(int[][] s1, int[][] s2)
        {
            int res = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res += Math.Abs(s1[i][j] - s2[i][j]);

                }
            }
            return res;
        }
        
    }
}
