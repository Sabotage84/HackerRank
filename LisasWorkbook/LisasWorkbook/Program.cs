using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisasWorkbook
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int workbook(int n, int k, int[] arr)
        {
            int res = 0;
            int page = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int curTask = 1;
                while (curTask <= arr[i])
                {
                    if (curTask <= page && page <= curTask + k - 1)
                    {
                        if (page <= arr[i])
                            res++;
                    }
                    page++;
                    curTask += k;
                }

            }


            return res;
        }
    }
}
