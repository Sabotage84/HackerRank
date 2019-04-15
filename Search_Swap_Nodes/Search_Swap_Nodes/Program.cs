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
            int temp = 1;
            Node rootNode = new Node();
            List<Node> tempNodes = new List<Node>();
            tempNodes.Add(rootNode);

            for (int i = 0; i < matrix[0].Length; i+=temp)
            {

                List<Node> tempNodes2 = tempNodes;
                for (int j = i, k=0; j < i+temp; j++,k++)
                {
                    
                    int left = matrix[j][0];
                    if (left != -1)
                    {
                        tempNodes2[k].left = new Node(left, tempNodes2[k]);
                        tempNodes.Add(tempNodes2[k].left);
                        temp++;
                    }
                    int rght = matrix[j][1];
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
    }


    public class Node
    {
        int root;
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
