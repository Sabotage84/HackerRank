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

        public TreeOfNodes(int[][] matrix)
        {

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
