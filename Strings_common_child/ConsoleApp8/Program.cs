using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //commonChild("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC");
            commonChild("SHINCHAN", "NOHARAAA");
            Console.ReadKey();
        }
        public static int commonChild(string s1, string s2)
        {
            int res = 0;

            res = CommonChildReq3(s1, s2, 0);

            return res;
        }

        private static int CommonChildReq3(string s1, string s2, int start)
        {
            int res = 0;
            int tempRes = 0;
            List<char> alredyDone = new List<char>();
            List<Char> tempCharList = s2.ToList();
            for (int i = start; (i < s1.Length && res<(s1.Length-i)); i++)
            {
                if (!alredyDone.Contains(s1[i]))
                {
                    alredyDone.Add(s1[i]);
                    if (tempCharList.Contains(s1[i]))
                    {
                        
                        tempRes++;
                        int temp = tempCharList.FindIndex((x => s1[i] == x)) + 1;
                        if(s2.Length - temp>res)
                            tempRes += CommonChildReq3(s1, s2.Substring(temp, s2.Length - temp), i + 1);
                    }
                    
                    if (tempRes > res)
                        res = tempRes;
                    tempRes = 0;
                    tempCharList = s2.ToList();
                }
            }

            return res;
        }

       
    }
}
