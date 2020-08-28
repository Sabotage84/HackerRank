using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyLadybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(happyLadybugs("X_Y__X"));
            Console.ReadKey();
        }

        static string happyLadybugs(string b)
        {
            string res = "NO";
            bool alresdyAllHappy = true;
            Dictionary<Char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < b.Length; i++)
            {
                if (i > 0 && i < b.Length - 1)
                {
                    if (b[i] != '_' && (b[i] != b[i + 1] && b[i] != b[i - 1]))
                        alresdyAllHappy = false;
                }
                else if (i==0)
                {
                    if (b[i] != '_' && b[i] != b[i + 1])
                        alresdyAllHappy = false;
                }
                else
                {
                    if (b[i] != '_' && b[i] != b[i - 1])
                        alresdyAllHappy = false;
                }
                if (dic.ContainsKey(b[i]))
                    dic[b[i]]++;
                else
                    dic.Add(b[i], 1);
            }

            if (alresdyAllHappy)
                return "YES";
            else
            {
                foreach (var item in dic)
                {
                    if (item.Key != '_' && item.Value == 1)
                        return "NO";
                    
                }
                if (dic.ContainsKey('_'))
                    return "YES";
                

            }

            return res;

        }
    }
}
