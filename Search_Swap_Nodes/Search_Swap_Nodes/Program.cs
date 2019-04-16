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

            
            int[,] m =  { {2, 3 },
                        { -1, -1 },
                         {-1 ,-1 }
                        };
            TreeOfNodes tree = new TreeOfNodes(m);
            tree.ShowTree();
        }
    }

    class TreeOfNodes
    {
        int[] numbers;
        Node rootNode = new Node(1,null);
        
        public TreeOfNodes(int[,] matrix)
        {
            int temp = 1;
            
            List<Node> tempNodes = new List<Node>();
            tempNodes.Add(rootNode);

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i+=temp)
            {

                List<Node> tempNodes2 = tempNodes;
                for (int j = i, k=0; j < i+temp; j++,k++)
                {
                    
                    int left = matrix[j,0];
                    if (left != -1)
                    {
                        tempNodes2[k].left = new Node(left, tempNodes2[k]);
                        tempNodes.Add(tempNodes2[k].left);
                        temp++;
                    }
                    int rght = matrix[j,1];
                    if (rght != -1)
                    {
                        tempNodes2[k].right = new Node(rght, tempNodes2[k]);
                        tempNodes.Add(tempNodes2[k].right);
                        temp++;
                    }
                }
                tempNodes2 = null;
            }
        }

        public void ShowTree()
        {
            List<int> lst = new List<int>();
            if (rootNode == null)
                Console.WriteLine("Tree is empty!");
            else
            {
                
                lst.Add(rootNode.root);
                if (rootNode.left!=null)
                    ShowLeft(lst, rootNode, rootNode.left);
                if (rootNode.right != null)
                    ShowRight(lst, rootNode, rootNode.right);

            }
            Console.WriteLine();
            foreach (var item in lst)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }

        private void ShowRight(List<int> lst,Node r, Node right)
        {
            lst.Insert(lst.IndexOf(r.root) + 1, right.root);
            Console.WriteLine(right.root);
            if (right.left != null)
            {
                ShowLeft(lst, right, right.left);
            }
            if (right.right != null)
            {
                ShowRight(lst, right, right.right);
            }
        }

        private void ShowLeft(List<int> lst, Node r, Node n)
        {
            lst.Insert(lst.IndexOf(r.root), n.root);
            Console.WriteLine(n.root);
            if (n.left!=null)
            {
                ShowLeft(lst, n, n.left);
            }
            if (n.right != null)
            {
                ShowRight(lst,n, n.right);
            }
        }
    }


    public class Node
    {
        public int root;
        Node parent;
        public Node left;
        public Node right;

        public Node()
        {
            root = 1;
            parent = null;
            left = null;
            right = null;
        }

        public Node(int root, Node p)
        {
            this.parent = p;
            this.root = root;
            left = null;
            right = null;
        }

        public Node(int root,Node p, Node left, Node right)
        {
            this.parent = p;
            this.root = root;
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
