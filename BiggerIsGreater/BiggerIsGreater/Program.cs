using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerIsGreater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(biggerIsGreater("ehdegnmorgafrjxvksc"));
            Console.WriteLine("ehdegnmorgafrjxvsck");
            Console.WriteLine( "ehdegnmorgafrjxvsck" ==biggerIsGreater("ehdegnmorgafrjxvksc"));
            Console.ReadLine();
        }
        public static string biggerIsGreater(string w)
        {
            
            int[] arr = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                arr[i] = w[i];
            }
            int max = arr[arr.Length - 1];
            int imax = arr.Length - 1;
            for (int i = w.Length-2; i >-1 ; i--)
            {
                if (max<=arr[i])
                {
                    max = arr[i];
                    imax = i;
                }
                else
                {
					//for tests
                    int imin=imax;
                    int minras=max-arr[i];
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[j]-arr[i]>0 && arr[j]-arr[i]<minras)
                        {
                            imin = j;
                            minras = arr[j] - arr[i];
                        }
                    }
                    int t = arr[i];
                    arr[i] = arr[imin];
                    arr[imin] = t;
                    string s1 = "";
                    for (int k = 0; k <= i; k++)
                    {
                        s1 += (char)arr[k];
                    }
                    string s2 = "";
                    for (int k = i+1; k < arr.Length; k++)
                    {
                        s2 += (char)arr[k];
                    }
                    char[] CH = s2.ToCharArray();
                    Array.Sort(CH);
                    s2 = new string(CH);
                    return s1 + s2;
                }
            }

            
        return "no answer";
        }

    }
}
