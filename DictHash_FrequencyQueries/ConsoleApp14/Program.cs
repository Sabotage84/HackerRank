using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> q = new List<List<int>>();
            q.Add(new List<int> { 1, 3 });
            q.Add(new List<int> { 2, 3 });
            q.Add(new List<int> { 3, 2 });
            q.Add(new List<int> { 1, 4 });
            q.Add(new List<int> { 1, 5 });
            q.Add(new List<int> { 1, 5 });
            q.Add(new List<int> { 1, 4 });
            q.Add(new List<int> { 3, 2 });
            q.Add(new List<int> { 2, 4 });
            q.Add(new List<int> { 3, 2 });



           
            List<int> res = freqQuery(q);
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }

        static List<int> freqQuery(List<List<int>> queries)
        {
            List<int> res = new List<int>();
            int adds = 0;
            int max = 1;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in queries)
            {
                if (item[0] == 1)
                {
                    adds++;
                    if (dic.ContainsKey(item[1]))
                    {
                        dic[item[1]]++;
                        if (max < dic[item[1]])
                            max = dic[item[1]];
                    }
                    else
                        dic.Add(item[1], 1);
                }
                if (item[0] == 2 && adds > 0)
                {
                    if (dic.ContainsKey(item[1]))
                    {
                        dic[item[1]]--;
                        if (dic[item[1]] == 0)
                            dic.Remove(item[1]);
                    }

                }
                if (item[0] == 3)
                {
                    if (item[1] <= adds && item[1] <= max)
                    {
                        if (dic.ContainsValue(item[1]))
                            res.Add(1);
                        else
                            res.Add(0);
                    }
                    else
                        res.Add(0);
                }


            }
            return res; 
        }
    }

   
}
