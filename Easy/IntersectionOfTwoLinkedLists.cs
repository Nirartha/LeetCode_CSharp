using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class IntersectionOfTwoLinkedLists
    {
        /**
         * 160. Intersection of Two Linked Lists
         * 
         * Runtime: 169 ms, faster than 56.05% of C# online submissions for Intersection of Two Linked Lists.
         * Memory Usage: 45.9 MB, less than 34.30% of C# online submissions for Intersection of Two Linked Lists.
         * 
         * Constraints:
         * The number of nodes of listA is in the m.
         * The number of nodes of listB is in the n.
         * 1 <= m, n <= 3 * 104
         * 1 <= Node.val <= 105
         * 0 <= skipA < m
         * 0 <= skipB < n
         * intersectVal is 0 if listA and listB do not intersect.
         * intersectVal == listA[skipA] == listB[skipB] if listA and listB intersect.
         */
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var n1 = headA;
            var n2 = headB;

            if (n1 == null || n2 == null) return null;

            while (n1 != null && n2 != null && n1 != n2)
            {
                n1 = n1.next;
                n2 = n2.next;

                if (n1 == n2) return n1;

                if (n1 == null) n1 = headB;
                if (n2 == null) n2 = headA;
            }
            return n1;
        }
    }
}
