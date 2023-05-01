using static System.Console;

namespace _7.LinkedLists.Concrete.Documentation.Articles
{
    public class MediumKojinLinkedLists
    {
        private ListNode _node;

        public void CreateLinkedList()
        {
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);

            node1.next = node2;
            node2.next = node3;

            _node = node1;
        }

        public void TraverseLinkedList()
        {
            while (_node != null)
            {
                Write($"{_node.val} ");
                _node = _node.next;
            }
        }

        public void RemoveDuplicates()
        {
            var hashset = new HashSet<int>();
        }
    }
}