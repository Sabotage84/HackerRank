﻿using System;
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
            int n = 4;
            int[] gf = { 1, 1, 4 };
            int[] gt = { 2,3,2};
            long[] inds = {1,2,1,1 };
            int v = 1;
            
            //string s = "1 2 1 1";
            //long[] ids = Array.ConvertAll(s.Split(' '), idsTemp => Convert.ToInt64(idsTemp));
            //long[] ids = Array.ConvertAll(Console.ReadLine().Trim(' ').Split(' '), idsTemp => Convert.ToInt64(idsTemp))
            Console.WriteLine(findShortest(n,gf,gt,inds,v));
            Console.ReadLine();
        }
        class Node
        {
            public long color;
            public bool checkedN=false;
            public List<int> neighbors= new List<int>();
        }

        static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            int res = 1000;
            long tempVal = val;
            int tempRes = 0;
            Node[] nodes = new Node[graphNodes];
            Queue<int> nodesForCheck = new Queue<int>();
            List<int> interstingNodes = new List<int>();
           

            for (int i = 0; i < ids.Length; i++)
            {
                nodes[i] = new Node();
                nodes[i].color = ids[i];
                if (tempVal == ids[i])
                {
                    tempRes++;
                    interstingNodes.Add(i);
                }
            }
            for (int i = 0; i < graphTo.Length; i++)
            {
                nodes[graphFrom[i]-1].neighbors.Add(graphTo[i]-1);
                nodes[graphTo[i]-1].neighbors.Add(graphFrom[i]-1);
            }
            if (tempRes >= 2)
            {
                foreach (var item in interstingNodes)
                {
                    Node start = nodes[item];
                    List<int> t1 = new List<int>();
                    start.checkedN = true;
                    int tempres = 0;
                    foreach (var neib in start.neighbors)
                    {

                        nodesForCheck.Enqueue(neib);
                        if (nodes[neib].color == val)
                            return 1;
                    }
                    tempres++;
                    while (nodesForCheck.Count > 0)
                    {
                        int tempNod = nodesForCheck.Dequeue();
                        if (!nodes[tempNod].checkedN)
                        {
                            if (nodes[tempNod].color == val)
                            {
                                if (res > tempres)
                                    res = tempres;
                                break;
                            }
                            else
                            {
                                nodes[tempNod].checkedN = true;
                                t1.AddRange(nodes[tempNod].neighbors);
                            }
                            if (nodesForCheck.Count == 0)
                            {
                                tempres++;
                                foreach (var nod in t1)

                                {
                                    nodesForCheck.Enqueue(nod);
                                }
                            }
                        }
                    }

                    foreach (var item2 in nodes)
                    {
                        item2.checkedN = false;
                    }
                    
                }
                return res;
            }
            else
                return -1;
        }

    }
}
