using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7.LinkedLists.Concrete
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}