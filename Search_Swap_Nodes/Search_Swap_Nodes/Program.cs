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

    public class Node
    {
        int root;
        Node left;
        Node right;

        public Node()
        {
            root = 1;
            left = null;
            right = null;
        }

        public Node(int root)
        {
            this.root = root;
            left = null;
            right = null;
        }

        public Node(int root, Node left, Node right)
        {
            this.root = root;
            this.left = left;
            this.right = right;
        }
    }
}
