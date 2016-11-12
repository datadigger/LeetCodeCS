using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var p = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    p.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    p.next = l1;
                    l1 = l1.next;
                }

                p = p.next;
            }

            if (l1 == null)
            {
                p.next = l2;
            }
            else
            {
                p.next = l1;
            }
            
            return head.next;
        }
    }
}
