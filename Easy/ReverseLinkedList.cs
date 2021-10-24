using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;

            ListNode prev = null;
            while (head != null)
            {
                ListNode nextNode = head.next;
                head.next = prev;
                prev = head;
                head = nextNode;
            }
            return prev;
        }
    }

    
     // Definition for singly-linked list.
     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
     }
     
}
