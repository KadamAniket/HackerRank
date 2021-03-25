using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ListCompare
    {
        /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
        static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            bool result = false;

            while (head1 != null || head2 != null)
            {
                if (head1?.data != head2?.data)
                {
                    result = false;
                    break;
                }
                head1 = head1.next;
                head2 = head2.next;
            }

           return result;

        }

        static bool CompareListsOptimize(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            while (head1 != null && head2 != null && head1.data == head2.data)
            {
                head1 = head1.next;
                head2 = head2.next;
            }

            return head1== head2;

        }

        public static void calculate()
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                bool result = CompareLists(llist1.head, llist2.head);

                Console.WriteLine((result ? 1 : 0));

                Console.ReadLine();
            }

        }
    }
}
