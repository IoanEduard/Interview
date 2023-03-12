using System.Text;
using _7.LinkedLists.Interfaces;

namespace _7.LinkedLists.Concrete.LeetCode
{
    public class LinkedListsProblems : ILinkedListsProblems 
    {
        private ListNode _head;
        public LinkedListsProblems(ListNode head)
        {
            _head = head;
        }

        public LinkedListsProblems()
        {
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

        // BAD
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l1Reversed = ReverseLinkedList(l1);
            var l2Reversed = ReverseLinkedList(l2);
            var n1 = 0;
            var n2 = 0;
            var result = new ListNode();

            while (true)
            {
                n1 = (n1 * 10) + l1Reversed.val;
                if (l1Reversed.next == null) break;
                l1Reversed = l1Reversed.next;
            }

            while (true)
            {
                n2 = (n2 * 10) + l2Reversed.val;
                if (l2Reversed.next == null) break;
                l2Reversed = l2Reversed.next;
            }

            var sum = n1 + n2;

            result.val = sum % 10;
            result = result.next;
            sum /= 10;

            while (sum > 0)
            {
                var temp = sum % 10;
                result = new ListNode(temp);
                result = result.next;
                sum /= 10;
            }

            return result;
        }

        public ListNode AddTwoNumbersGoodSolution(ListNode l1, ListNode l2)
        {
            var remainder = 0;
            var res = new ListNode(0);
            var result = res;

            while (l1 != null || l2 != null || remainder == 1)
            {
                int sum = 0;
                if (l1 != null)
                    sum += l1.val;

                if (l2 != null)
                    sum += l2.val;

                sum += remainder;

                res.next = new ListNode(sum % 10);
                res = res.next;
                remainder = sum / 10;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return result.next;
        }
    }
}