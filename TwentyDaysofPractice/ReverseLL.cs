using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class ReverseLL
    {
        public static Node Reverse(Node head)
        {
            if (head == null || head.next == null)
                return head;

            var first = head;
            var second = first.next;

            while(second != null)
            {
                var temp = second.next;
                second.next = first;
                first = second;
                second = temp;
            }

            head.next = null;
            head = first;

            return head;

        }
    }
}
