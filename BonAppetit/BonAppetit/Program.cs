using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void bonAppetit(List<int> bill, int k, int b)
        {

            int sum = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                    continue;
                sum += bill[i];
            }
            sum = sum / 2;
            if (b - sum == 0)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - sum);
        }
    }
}
