using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.LinkedList
{
    // https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem
    public class InsertNode
    {
        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {

            var newNode = new SinglyLinkedListNode(data);
            if (llist != null)
            {
                newNode.next = llist;
            }

            return llist;
    }
}
}
