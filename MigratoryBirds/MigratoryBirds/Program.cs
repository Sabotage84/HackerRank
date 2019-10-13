using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("test.txt");
            List<int> ar = f.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            //List<int> ar = new List<int>{ 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            Console.WriteLine(migratoryBirds(ar));
            Console.ReadKey();
        }

        static int migratoryBirds(List<int> arr)
        {
            int res = 0;

            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            foreach (var item in arr)
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic.Add(item, 1);
            }
            
            int min = dic.First().Value;
            res = dic.First().Key;
            foreach (var item in dic)
            {
                if (min<item.Value)
                {
                    min = item.Value;
                    res = item.Key;
                }
            }
            return res;
        }

    }
}
