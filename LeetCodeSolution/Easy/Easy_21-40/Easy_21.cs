using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_21_40
{
    internal class Easy_21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }

            ListNode result = new ListNode();
            ListNode p = result, p1 = list1, p2 = list2;

            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    p.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    p.next = p2;
                    p2 = p2.next;
                }
                p = p.next;
            }

            if (p1 != null)
            {
                p.next = p1;
            }

            if (p2 != null)
            {
                p.next = p2;
            }
            return result.next;
        }
    }
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
