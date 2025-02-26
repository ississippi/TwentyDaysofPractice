using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    //
    // Given head, the head of a linked list, determine if the linked list has a cycle in it.
    // There is a cycle in a linked list if there is some node in the list that can be reached again
    // by continuously following the next pointer.Internally, pos is used to denote the index of
    // the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
    // Return true if there is a cycle in the linked list.Otherwise, return false.
    // Input: head = [3,2,0,-4], pos = 1
    // Output: true
    // Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0-indexed).
    // Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
            next = null;
        }
    }
     
    internal class HasCycleLL
    {
        public bool HasCycle(ListNode head)
        {
            var currentNode = head;
            HashSet<ListNode> seen = new HashSet<ListNode>();
            var pos = 0;
            while (currentNode != null)
            {
                if (seen.Contains(currentNode))
                {
                    //Console.WriteLine($"POS: {seen[currentNode]}");
                    return true;
                }
                seen.Add(currentNode);
                //Console.WriteLine($"POS: {seen[currentNode]}");
                currentNode = currentNode.next;
            }
            return false;
        }
    }
}

