using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    { 

        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,3,2,1,5,4,4,5};
            Console.WriteLine(birthdayCakeCandles(arr));
            Console.ReadKey();
        }
        static int birthdayCakeCandles(int[] ar)
        {
            int res = 1;
            int max = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {

                if (max<ar[i])
                {
                    max = ar[i];
                    res = 1;
                }
                else if (max == ar[i])
                    res++;
            }
            return res;
        }
    }
}
