using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] lon = new long[6] { 1, 3, 9, 9, 27, 81 };
            Dictionary<long, long> dic = new Dictionary<long, long>();
            long res=0;
            for (int i = 0; i < lon.Length; i++)
            {
                if (dic.Keys.Contains(lon[i]))
                    dic[lon[i]] = dic[lon[i]] + 1;
                else
                    dic.Add(lon[i], 1);
            }
            int j = 0;
            foreach (KeyValuePair<long, long> keyValue in dic)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                if ((j+2)<dic.Count)
                    res=res+(keyValue.Value* dic.ElementAt(j+1).Value* dic.ElementAt(j + 2).Value);
                j++;
            }
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
