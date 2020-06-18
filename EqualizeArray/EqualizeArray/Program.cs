using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeArray
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int equalizeArray(int[] arr)
        {
            int res = 0;
            int max=1;
            Dictionary<int, int> r = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (r.ContainsKey(arr[i]))
                    r[arr[i]]++;
                else
                    r.Add(arr[i], 1);
            }
            
            foreach (var item in r)
            {
                if (max < item.Value)
                    max = item.Value;
                res += item.Value;
            }

            return res - max;
        }
    }
}
