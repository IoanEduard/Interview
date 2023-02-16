using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LinkedLists.Concrete.LeetCode
{
    public class LinkedListsProblems
    {
        private ListNode _head;
        public LinkedListsProblems(ListNode head)
        {
            _head = head;
        }
        // FAILED ATTEMPT
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var returnList = new ListNode();

            while (list1.next != null && list2.next != null)
            {
                if (list1.val <= list2.val)
                {
                    returnList.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    returnList.next = list2;
                    list2 = list2.next;
                }

                returnList = returnList.next;
            }

            return returnList.next;
        }
         public void TraverseLinkedList()
        {
            while (_head != null)
            {
                Console.WriteLine((char)_head.val);
                _head = _head.next;
            }
        }

        public ListNode TraverseLinkedListRecursive(ListNode head)
        {
            if (head == null)
                return null;

            Console.WriteLine((char)head.val);

            return TraverseLinkedListRecursive(head.next);
        }

        public int GetDecimalValue(ListNode head)
        {
            var stringBuilder = new StringBuilder();

            while (head != null)
            {
                stringBuilder.Append(head.val);
                head = head.next;
            }

            return Convert.ToInt32(stringBuilder.ToString(), 2);
        }

        // https://medium.com/outco/reversing-a-linked-list-easy-as-1-2-3-560fbffe2088
        public ListNode ReverseLinkedList(ListNode head)
        {
            ListNode previous = null;
            var current = head;
            var following = head;

            while (current != null)
            {
                following = following.next;
                current.next = previous;
                previous = current;
                current = following;
            }

            return previous;
        }

        public ListNode MiddleNode(ListNode head)
        {
            var count = 0;

            var current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            var mid = Math.Floor((double)count / 2);

            count = 0;
            while (count <= mid)
            {
                count++;
                head = head.next;
            }

            return head;
        }
    }
}