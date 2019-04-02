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
            commonChild("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC");
            Console.ReadKey();
        }
        public static int commonChild(string s1, string s2)
        {
            int res = 0;

            res = CommonChildReq(s1, s2,0);
            //string tempres = "";
            //List<char> chars= s2.ToList();
            //for (int j = 0; j < s1.Length; j++)
            //{
            //    for (int i = j; i < s1.Length; i++)
            //    {
            //        if (chars.Contains(s1[i]))
            //        {
            //            tempres += s1[i];
            //            chars.RemoveRange(0, chars.FindIndex((x => s1[i] == x)) + 1);

            //        }
            //    }
            //    if(tempres.Length>res)
            //        res = tempres.Length;
            //    Console.WriteLine(tempres);
            //    Console.WriteLine(tempres.Length);
            //    tempres = "";
            //    chars= s2.ToList();
            //}
            
            return res;
        }

        private static int CommonChildReq(string s1, string s2, int start)
        {
            string res = "";
            int resInt = 0;
            List<char> chars = s2.ToList();
            for (int i = start; i < s1.Length; i++)
            {
                if (chars.Contains(s1[i]))
                {
                    Console.WriteLine(s1[i]);
                    chars.RemoveRange(0, chars.FindIndex((x => s1[i] == x)) + 1);
                    res += s1[i];
                    res+= CommonChildReq2(s1, chars, i+1);
                }
                Console.WriteLine();
                Console.WriteLine(res);
                Console.WriteLine(res.Length);
                if (res.Length > resInt)
                    resInt = res.Length;
                chars = s2.ToList();
                res = "";
            }

            return resInt;
        }

        private static string CommonChildReq2(string s1, List<char> chars, int v)
        {
            string res = "";
            string tempres = "";
            for (int i = v; i < s1.Length; i++)
            {
               
                if (chars.Contains(s1[i]))
                {
                    chars.RemoveRange(0, chars.FindIndex((x => s1[i] == x)) + 1);
                    tempres += s1[i];
                    tempres += CommonChildReq2(s1, chars, i + 1);
                }
                if (res.Length < tempres.Length)
                    res = tempres;

            }
            return res;
        }
    }
}
