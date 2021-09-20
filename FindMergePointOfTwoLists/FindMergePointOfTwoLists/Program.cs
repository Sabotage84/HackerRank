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
            while (true)
            {
                if (head1.data > head2.data)
                {
                    head2 = head2.next;
                }
                else if (head1.data < head2.data)
                {
                    head1 = head1.next;
                }
                else
                {
                    if (object.ReferenceEquals(head1, head2))
                        return head1.data;
                    else
                    {
                        if (head2.next.data > head1.next.data)
                            head1 = head1.next;
                        else
                            head2 = head2.next;
                    }
                }
            }

            
        }

        static void Main(string[] args)
        {
        }
    }
}
