using System.Text;
using _14.Trees.Concrete;
using _7.LinkedLists.Concrete;

namespace _6.Recursion.Concrete.freeCodeCamp
{
    /// <summary>
    /// https://www.youtube.com/watch?v=IJDJ0kBx2LM
    /// </summary>
    public class FreeCodeCampRecursion
    {
        public string ReverseString(string s)
        {
            if (s == string.Empty)
                return string.Empty;

            return ReverseString(s.Substring(1)) + s[0];
        }

        public bool IsPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1) return true;

            if (s[0] == s[s.Length - 1])
                return IsPalindrome(s.Substring(1, s.Length - 2));

            return false;
        }

        public string DecimalToBinary(int n, StringBuilder result)
        {
            if (n == 0)
                return result.ToString();

            result.Insert(0, n % 2);

            return DecimalToBinary(n / 2, result);
        }

        public int SumOfNaturalNumbers(int n)
        {
            if (n <= 1)
                return n;

            return n + SumOfNaturalNumbers(n - 1);
        }

        public int BinarySearch(int[] numbers, int n, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = left + ((right - left) / 2);

            if (n == numbers[mid])
                return mid;

            if (n < numbers[mid])
                BinarySearch(numbers, n, left, mid - 1);

            return BinarySearch(numbers, n, mid + 1, right);
        }

        public int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }

        // also this question 912. Sort an Array
        public int[] MergeSort(int[] data, int start, int end)
        {
            if (start < end)
            {
                int mid = start + ((end - start) / 2);
                MergeSort(data, start, mid);
                MergeSort(data, mid + 1, end);
                Merge(data, start, mid, end);
            }

            return data;
        }

        private void Merge(int[] data, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];

            int i = start;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= end)
            {
                if (data[i] <= data[j])
                    temp[k++] = data[i++];
                else
                    temp[k++] = data[j++];
            }

            while (i <= mid)
            {
                temp[k++] = data[i++];
            }

            while (j <= end)
            {
                temp[k++] = data[j++];
            }

            for (i = start; i <= end; i++)
            {
                data[i] = temp[i - start];
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return p;
        }

        public ListNode SortedMerge(ListNode a, ListNode b)
        {
            if (a == null) return b;
            if (b == null) return a;

            if (a.val < b.val)
            {
                a.next = SortedMerge(a.next, b);
                return a;
            }
            else
            {
                b.next = SortedMerge(a, b.next);
                return b;
            }
        }

        public TreeNode InsertValueIntoBinarySearch(TreeNode head, int data)
        {
            if (head == null)
            {
                head = new TreeNode();
                head.val = data;
                return head;
            }

            if (head.val < data)
                head.right = InsertValueIntoBinarySearch(head.right, data);
            else
                head.left = InsertValueIntoBinarySearch(head.left, data);

            return head;
        }

        public void PrintAllLeaves(TreeNode root)
        {
            if (root == null)
                return;

            if(root.left == null && root.right == null)
                return;

            if(root.left != null) PrintAllLeaves(root.left);
            if(root.right != null) PrintAllLeaves(root.right);
        }
        
    }
}