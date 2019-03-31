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
            string tempres = "";
            List<char> chars= s2.ToList();
            for (int j = 0; j < s1.Length; j++)
            {
                for (int i = j; i < s1.Length; i++)
                {
                    if (chars.Contains(s1[i]))
                    {
                        tempres += s1[i];
                        chars.RemoveRange(0, chars.FindIndex((x => s1[i] == x)) + 1);

                    }
                }
                if(tempres.Length>res)
                    res = tempres.Length;
                Console.WriteLine(tempres);
                Console.WriteLine(tempres.Length);
                tempres = "";
                chars= s2.ToList();
            }
            
            return res;
        }
    }
}
