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
            biggerIsGreater("ab");
            Console.ReadLine();
        }
        public static string biggerIsGreater(string w)
        {
            
            int[] arr = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                arr[i] = w[i];
            }
            

            for (int i = arr.Length-1; i >0; i--)
            {
                for (int j = i-1; j > -1; j--)
                {
                    if(arr[i]>arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                        string s1 = "";
                        for (int k = 0; k <= j; k++)
                        {
                            s1 += (char)arr[k];
                        }
                        string s2 = "";
                        for (int k = j+1; k < arr.Length; k++)
                        {
                            s2 += (char)arr[k];
                        }
                        char[] CH = s2.ToCharArray();
                        Array.Sort(CH);
                        s2 = new string(CH);
                        return s1 + s2;
                    }
                }
            }
        return "no answer";
        }

    }
}
