using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingtheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int[] r= breakingRecords(arr);
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine(r[i]);
            }
            Console.ReadKey();
        }

        static int[] breakingRecords(int[] scores)
        {
            int[] res = { 0, 0 };
            int min = scores[0];
            int max = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (min>scores[i])
                {
                    min = scores[i];
                    res[1]++;
                }
                if (max<scores[i])
                {
                    max = scores[i];
                    res[0]++;
                }
            }


            return res;

        }
    }
}
