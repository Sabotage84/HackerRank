using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3DSurfaceArea
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int surfaceArea(int[][] A)
        {
            int res = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if(A[i][j]>0)
                    {
                        res += 2;
                        if(j+1 < A[i].Length)
                        {
                            if (A[i][j] > A[i][j + 1])
                                res += A[i][j] - A[i][j + 1];
                        }
                        else
                        {
                            res += A[i][j];
                        }
                        if(i+1<A.Length)
                        {
                            if (A[i][j] > A[i+1][j])
                                res += A[i][j] - A[i+1][j];
                        }
                        else
                        {
                            res += A[i][j];
                        }
                        if (j-1>=0)
                        {
                            if (A[i][j] > A[i][j-1])
                                res += A[i][j] - A[i][j-1];
                        }
                        else
                        {
                            res += A[i][j];
                        }
                        if(i-1>=0)
                        {
                            if (A[i][j] > A[i-1][j])
                                res += A[i][j] - A[i-1][j];
                        }
                        else
                        {
                            res += A[i][j];
                        }

                    }
                }
            }

            return res;
        }
    }
}
