using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Swap_Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new int[][] { new int[] {2, 3 },
                        new int[]{ 4, - 1 },
                        new int[]{ 5 ,- 1 },
                        new int[]{ 6 ,- 1 },
                        new int[] { 7, 8 },
                        new int[] { - 1 ,9 },
                        new int[] { - 1, - 1 },
                        new int[] { 10 ,11 },
                        new int[] { - 1 ,- 1 },
                        new int[] { - 1 ,- 1 },
                        new int[]{ - 1, - 1 } };


            //int[,] m =  { {2, 3 },
            //            { -1, -1 },
            //             {-1 ,-1 }
            //            };
            TreeOfNodes tree = new TreeOfNodes(m);
            tree.ShowTree();
            tree.rootNode.Swap();
            tree.ShowTree();
            tree.rootNode.Swap();
            tree.ShowTree();
            Console.ReadKey();
        }
    }

    class TreeOfNodes
    {
        
        public Node rootNode = new Node(1,null, 1);
        
        public TreeOfNodes(int[][] matrix)
        {
            int innerLimit = 1;
            List<Node> tempNodes = new List<Node>();
            tempNodes.Add(rootNode);
            int tempLevel = 2;
            int outerIncr = innerLimit;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i+=outerIncr)
            {
                outerIncr = innerLimit;
                int childCount = 0;

                for (int j = i; j <i+innerLimit; j++)
                {
                    
                    int left = matrix[j][0];
                    if (left != -1)
                    {
                        tempNodes[j].left = new Node(left, tempNodes[j], tempLevel);
                        tempNodes.Add(tempNodes[j].left);
                        childCount++;
                    }
                    int rght = matrix[j][1];
                    if (rght != -1)
                    {
                        tempNodes[j].right = new Node(rght, tempNodes[j], tempLevel);
                        tempNodes.Add(tempNodes[j].right);
                        childCount++;
                    }
                    
                }
                innerLimit = childCount;
                tempLevel++;
            }
        }

        public void ShowTree()
        {
            List<int> lst = new List<int>();
            List<int> levelList = new List<int>();
            if (rootNode == null)
                Console.WriteLine("Tree is empty!");
            else
            {
                
                lst.Add(rootNode.root);
                levelList.Add(rootNode.level);
                if (rootNode.left!=null)
                    ShowLeft(lst, rootNode, rootNode.left, levelList);
                if (rootNode.right != null)
                    ShowRight(lst, rootNode, rootNode.right, levelList);

            }
            Console.WriteLine();

            foreach (var item in lst)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            foreach (var item in levelList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public int[][]  SwapTree(int[] queries)
        {
            int[][] res = new int[queries.Length][];


            return res;
        }

        private void ShowRight(List<int> lst,Node r, Node right, List<int> lvl)
        {
            lvl.Insert(lst.IndexOf(r.root) + 1, right.level);
            lst.Insert(lst.IndexOf(r.root) + 1, right.root);
         
            if (right.left != null)
            {
                ShowLeft(lst, right, right.left,lvl);
            }
            if (right.right != null)
            {
                ShowRight(lst, right, right.right,lvl);
            }
        }

        private void ShowLeft(List<int> lst, Node r, Node n, List<int> lvl)
        {
            lvl.Insert(lst.IndexOf(r.root), n.level);
            lst.Insert(lst.IndexOf(r.root), n.root);
            
            if (n.left!=null)
            {
                ShowLeft(lst, n, n.left, lvl);
            }
            if (n.right != null)
            {
                ShowRight(lst,n, n.right, lvl);
            }
        }
    }


    public class Node
    {
        public int root;
        Node parent;
        public Node left;
        public Node right;
        public int level;

        public Node()
        {
            root = 1;
            parent = null;
            left = null;
            right = null;
        }

        public Node(int root, Node p, int level)
        {
            this.parent = p;
            this.level = level;
            this.root = root;
            left = null;
            right = null;
        }

        public Node(int root,Node p, Node left, Node right, int level)
        {
            this.parent = p;
            this.root = root;
            this.level = level;
            this.left = left;
            this.right = right;
        }

        public void Swap()
        {
            Node temp = left;
            left = right;
            right = temp;
        }
    }
}
