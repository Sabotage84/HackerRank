using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int beautifulTriplets(int d, int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    if (arr[j] == arr[i])
                        continue;
                    else if (arr[j] - arr[i] < d)
                        continue;
                    else if (arr[j] - arr[i] > d)
                        break;
                    else
                    {
                        for (int l = j+1; l < arr.Length; l++)
                        {
                            if (arr[l] - arr[j] < d)
                                continue;
                            else if (arr[l] - arr[j] > d)
                                break;
                            else
                            {
                                res++;
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            return res;

        }
    }
}
