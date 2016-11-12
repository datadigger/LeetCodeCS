using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }

        public static ListNode Create(int[] input)
        {
            if (input == null)
            {
                return null;
            }

            ListNode dummy = new ListNode(-1);
            ListNode p = dummy;
            foreach (var i in input)
            {
                p.next = new ListNode(i);
                p = p.next;
            }

            return dummy.next;
        }

        public static void Print(ListNode l)
        {
            while (l != null)
            {
                Console.WriteLine(l.val);
                l = l.next;
            }
        }

        public static bool Equals(ListNode l1, ListNode l2)
        {
            if (l1 == l2)
            {
                return true;
            }

            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                {
                    return false;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            if (l1 != null || l2 != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
