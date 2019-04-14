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
        }
    }

    class TreeOfNodes
    {
        int[] numbers;
        Node rootNode = new Node();
        public TreeOfNodes(int[][] matrix)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int temp = 0;
		Node tempNode;
                for (int j = temp; j < matrix[0].Length; j+=temp)
                {
                    temp = 0;
                    int left = matrix[j][0];
                    if (left != -1)
                        temp++;
                    int rght = matrix[j][1];
                    if (rght != -1)
                        temp++;                   
                }
            }
        }
    }


    public class Node
    {
        int root;
        Node parent;
        Node left;
        Node right;

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
