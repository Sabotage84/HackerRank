using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarryArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] D = { 1, 6, 5, 2, 3, 4 };
            Console.WriteLine(larrysArray(D));
            Console.ReadKey();

        }

        static string larrysArray(int[] A)
        {
            
            for (int i = 0; i < A.Length-3; i++)
            {
                if ((i+1)!=A[i])
                {
                    for (int j = i+1; j < A.Length; j++)
                    {
                        if(A[j]==i+1)
                        {
                            int cur = j;
                            while (cur!=i)
                            {
                                if(cur-i>=2)
                                {
                                    cur = ABC_CAB(A, cur);
                                }
                                if((cur-i)==1)
                                {
                                    cur = ABC_BCA(A, cur);
                                }
                            }
                            break;
                        }
                    }
                }
            }
            if (A[A.Length - 3] < A[A.Length - 2] && A[A.Length - 2] < A[A.Length - 1])
                return "YES";
            ABC_CAB(A, A.Length - 1);
            if (A[A.Length - 3] < A[A.Length - 2] && A[A.Length - 2] < A[A.Length - 1])
                return "YES";
            ABC_CAB(A, A.Length - 1);
            if (A[A.Length - 3] < A[A.Length - 2] && A[A.Length - 2] < A[A.Length - 1])
                return "YES";

            return "NO";
        }

        private static int ABC_CAB(int[] a, int cur)
        {
            int tmp = a[cur];
            a[cur] = a[cur - 1];
            a[cur - 1] = a[cur - 2];
            a[cur - 2] = tmp;
            return cur - 2;
        }

        private static int ABC_BCA(int[] a, int cur)
        {
            int tmp = a[cur];
            a[cur] = a[cur + 1];
            a[cur + 1] = a[cur - 1];
            a[cur - 1] = tmp;
            return cur - 1;
        }


    }
}
