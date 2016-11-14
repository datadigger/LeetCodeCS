using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var q = new ListNode(-1);
            q.next = head;

            var p = q;

            for (int i = 0; i < n; ++i)
            {
                head = head.next;
            }

            while (head != null)
            {
                head = head.next;
                q = q.next;
            }

            q.next = q.next.next;

            return p.next;
        }
    }
}
