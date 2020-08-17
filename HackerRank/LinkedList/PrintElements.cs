using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.LinkedList
{
    // https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/problem
    public class PrintElements
    {
        static void printLinkedList(SinglyLinkedListNode head)
        {
            Console.WriteLine(head.data);
            if (head.next != null)
            {
                printLinkedList(head.next);
            }

        }
    }
}
