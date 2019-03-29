using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        static public long substrCount(int n, string s)
        {
            long res = n;
            for (int i = 0; i < n; i++)
            {
                char ch = s[i];

                if ((i+1)<n && ch == s[i + 1])
                    res++;
                int j=i-1 , k = i+1;
                int t = 1;
                while (j>=0 && k<n)
                {
                    if (s[j] == s[k])
                    {
                        if (t == 1)
                        {
                            res++;
                            j--;
                            k++;
                            t++;
                        }
                        else
                        {
                            if (s[j] == s[j + 1] && s[k] == s[k - 1])
                            {
                                res++;
                                j--;
                                k++;
                            }
                            else
                                break;

                        }
                    }
                    else
                        break;
                }
            }

            return res;
        }
    }
}
