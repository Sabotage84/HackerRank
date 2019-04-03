using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CharInd
    {
        char ch;
        int index;

        public CharInd(char ch, int index)
        {
            this.ch = ch;
            this.index = index;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
           int t= commonChild("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC");
            //commonChild("SHINCHAN", "NOHARAAA");
            Console.WriteLine(t);
            Console.ReadKey();
        }
        public static int commonChild(string s1, string s2)
        {
            int res = 0;
            string tempS1 = "";
            string tempS2 = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.Contains(s1[i]))
                    tempS1 += s1[i];
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (s1.Contains(s2[i]))
                    tempS2 += s2[i];
            }

            res = CommonChildReq3(tempS1, tempS2);

            return res;
        }

        private static int CommonChildReq3(string s1, string s2)
        {
            int res = 0;
            int tempRes = 0;
            List<char> alredyDone = new List<char>();
            
            for (int i =0; (i < s1.Length && res <= (s1.Length - i)); i++)
            {
                if (!alredyDone.Contains(s1[i]))
                {
                    alredyDone.Add(s1[i]);
                    List<char> alredyDone2 = new List<char>();
                    for (int j = 0; (j < s2.Length && res <= (s2.Length - j)); j++)
                    {
                        if (!alredyDone2.Contains(s2[j]))
                        {
                            alredyDone2.Add(s2[j]);
                            if (s1[i] == s2[j])
                            {
                                tempRes++;
                                if (s2.Length - j > res)
                                    tempRes += CommonChildReq3(s1.Substring(i + 1), s2.Substring(j + 1));
                            }
                            
                        }
                        if (tempRes > res)
                                res = tempRes;
                            tempRes = 0;
                    }
                }
                
            }

            return res;
        }

        private static void ShowList(List<char> alredyDone)
        {
            foreach (var item in alredyDone)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
