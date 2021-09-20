using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMergePointOfTwoLists
{
    class Program
    {

        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode curTemp;
            SinglyLinkedListNode nextTemp;
            SinglyLinkedListNode prevTemp;

            SinglyLinkedListNode temp = head1;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();

            prevTemp = null;
            curTemp = head1;
            nextTemp = curTemp.next;
            while (curTemp != null)
            {
                nextTemp = curTemp.next;
                curTemp.next = prevTemp;
                prevTemp = curTemp;
                curTemp = nextTemp;

            }
            head1 = prevTemp;

            temp = head1;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();


            temp = head2;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();


            prevTemp = null;
            curTemp = head2;
            nextTemp = curTemp.next;
            while (curTemp != null)
            {
                nextTemp = curTemp.next;
                curTemp.next = prevTemp;
                prevTemp = curTemp;
                curTemp = nextTemp;

            }
            head2 = prevTemp;

            temp = head2;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();


            while (true)
            {
                if (!object.ReferenceEquals(head1.next, head2.next))
                    return head2.data;
                head1 = head1.next;
                head2 = head2.next;
            }


        }

        static void Main(string[] args)
        {
        }
    }
}
