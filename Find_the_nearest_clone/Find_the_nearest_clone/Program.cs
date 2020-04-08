using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_nearest_clone
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1 2 1 1";
            long[] ids = Array.ConvertAll(s.Split(' '), idsTemp => Convert.ToInt64(idsTemp));
            //long[] ids = Array.ConvertAll(Console.ReadLine().Trim(' ').Split(' '), idsTemp => Convert.ToInt64(idsTemp))
            Console.WriteLine(ids.Length);
            Console.ReadLine();
        }
        class Node
        {
            public long color;
            public int[] neighbors;
        }

        static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            int res = 1;
            long tempVal = val;
            int tempRes = 0;
            Node[] nodes = new Node[graphNodes];
            Queue<int> nodesForCheck = new Queue<int>();

            nodesForCheck.Enqueue(3); // очередь 3
            nodesForCheck.Enqueue(5); // очередь 3, 5
            nodesForCheck.Enqueue(8); // очередь 3, 5, 8

            // получаем первый элемент очереди
            int queueElement = nodesForCheck.Dequeue(); //теперь очередь 5, 8

            for (int i = 0; i < ids.Length; i++)
            {
                nodes[i].color = ids[i];
                if (tempVal == ids[i])
                    tempRes++;
            }
            if (tempRes >= 2)
            {

                return res;
            }
            else
                return -1;
        }

    }
}
