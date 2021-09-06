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

        LinkedList<int> lst = new LinkedList<int>();

        public class DoublyLinkedListNode
        {
             int data;
             DoublyLinkedListNode next;
             DoublyLinkedListNode prev;
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
            return llist;
        }
    }
}       
    
