using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int res = -1;

            Array.Sort(keyboards);
            Array.Sort(drives);

            if (keyboards[0] + drives[0] >= b)
                return res;
            int min =b- (keyboards[0] + drives[0]);
            for (int i = 0; i < keyboards.Length; i++)
            {
                
                for (int j = 0; j < drives.Length; j++)
                {
                    if (b-(keyboards[i] + drives[j])<min && b - (keyboards[i] + drives[j])>=0)
                    {
                        min = b - (keyboards[i] + drives[j]);
                        res = keyboards[i] + drives[j];
                    }
                }
            }

            return res;
        }
    }
}
