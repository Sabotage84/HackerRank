using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aaabbbbcccddd";
            string str2 = "aaabcccddd";
            string str3 = "aabbccddeefghi";
            Console.WriteLine(isValid(str1));
            Console.WriteLine(isValid(str2));
            Console.WriteLine(isValid(str3));

            Console.ReadKey();
        }

        static string isValid(string s)
        {
           
            Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<int, int> dicInt = new Dictionary<int, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    dic[s[i]]++;
                else
                    dic.Add(s[i], 1);
            }
          
            foreach (var item in dic)
            {
                if (dicInt.ContainsKey(item.Value))
                    dicInt[item.Value]++;
                else
                    dicInt.Add(item.Value, 1);
            }
            if (dicInt.Count > 2)
                return "NO";
            else if (dicInt.Count == 1)
                return "YES";
            else
            {
                if ((dicInt.Values.ElementAt(0)) == 1 && (dicInt.Keys.ElementAt(0)) == 1)
                    return "YES";
                if ((dicInt.Values.ElementAt(1)) == 1 && (dicInt.Keys.ElementAt(1)) == 1)
                    return "YES";
                if ((dicInt.Values.ElementAt(0) )==1 && (Math.Abs(dicInt.Keys.ElementAt(0)-dicInt.Keys.ElementAt(1)))==1)
                {
                    return "YES";
                }
                else if (dicInt.Values.ElementAt(1)==1  && (Math.Abs(dicInt.Keys.ElementAt(0) - dicInt.Keys.ElementAt(1))) == 1)
                {
                    return "YES";
                }
               //else if(dicInt.Keys.ElementAt(0)==Math.Abs(dicInt.) {

               // }


                else
                    return "NO";
            }


        }

    }
}
