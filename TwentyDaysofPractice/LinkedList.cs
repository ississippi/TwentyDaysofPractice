using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    public class Node
    {
        public string value = string.Empty;
        public Node next;
        public Node(string value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class LinkedList
    {
        public Node head = null;
        public LinkedList(string value)
        {
            head = new Node(value);
            head.value = value;
            head.next = null;
        }
        public void Append(string value)
        {
            var newNode = new Node(value);
            var currentNode = this.head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = newNode;
            currentNode.next.next = null;
        }
    }
}



