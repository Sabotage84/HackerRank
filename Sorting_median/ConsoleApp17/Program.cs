using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 10000;
            //var arr = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
            string path = @"test.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }
           
            var arr= Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r = activityNotifications(arr, d);
            Console.WriteLine(r);
            Console.ReadKey();
        }

        static int activityNotifications(int[] expenditure, int d)
        {
            int res = 0;
            Array.Reverse(expenditure);
            int med = 0;
            for (int j = 1; j <= d; j++)
            {
                med += expenditure[j];
            }
           

            for (int i = 0; i <= expenditure.Length - 1 - d; i++)
            {
               
                if ((double)expenditure[i] >= (med/d) * 2)
                    res++;
                if ((i + 1 + d)<=expenditure.Length-1)
                    med += (expenditure[i + 1 + d]-expenditure[i + 1]);
                //Console.WriteLine(i);
                //Console.WriteLine("+ {0}",expenditure[i + 1 + d]);
                //Console.WriteLine("- {0}",expenditure[i + 1]);
                //Console.WriteLine(med);
            }
            return res;
        }
    }
}
