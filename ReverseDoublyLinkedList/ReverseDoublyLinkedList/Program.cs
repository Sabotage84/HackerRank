using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDoublyLinkedList
{
    class Program
    {
        

        static void Main(string[] args)
        {
        }
    }

    public class Result
    {

        public class DoublyLinkedListNode
        {
             public int data;
             public DoublyLinkedListNode next;
             public DoublyLinkedListNode prev;
        }


    /*
 * Complete the 'reverse' function below.
 *
 * The function is expected to return an INTEGER_DOUBLY_LINKED_LIST.
 * The function accepts INTEGER_DOUBLY_LINKED_LIST llist as parameter.
 */

    /*
     * For your reference:
     *
     * DoublyLinkedListNode
     * {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */
    public DoublyLinkedListNode reverse(DoublyLinkedListNode llist)
        {
            DoublyLinkedListNode temp = llist;
            while (true)
            {
                //Console.Write("Temp=" + temp.data);
                //if (temp.prev != null)
                //    Console.Write(" Temp.prev=" + temp.prev.data);
                //else
                //    Console.Write(" Temp.prev=NULL");
                //if (temp.next != null)
                //    Console.Write(" Temp.next=" + temp.next.data);
                //else
                //    Console.Write(" Temp.next=NULL");
                //Console.WriteLine();
                DoublyLinkedListNode t2 = temp.next;
                temp.next = temp.prev;
                temp.prev = t2;
                if (temp.prev != null)
                    temp = temp.prev;
                else
                    break;

            }

            //if (temp != null)
            //    Console.Write("Temp=" + temp.data);
            //if (temp.prev != null)
            //    Console.Write(" Temp.prev=" + temp.prev.data);
            //else
            //    Console.Write(" Temp.prev=NULL");
            //if (temp.next != null)
            //    Console.Write(" Temp.next=" + temp.next.data);
            //else
            //    Console.Write(" Temp.next=NULL");
            //Console.WriteLine();

            return temp;
        }
    }
}       
    
