using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int[] cutTheSticks(int[] arr)
        {
            List<int> lres = new List<int>();
            lres.Add(arr.Length);
            List<int> t = arr.ToList();
            t.Sort();
            arr = t.ToArray();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                    lres.Add(arr.Length - i);
            }

            return lres.ToArray();
        }
    }
}
