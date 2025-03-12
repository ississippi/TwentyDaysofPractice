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
        public Node? next;
        public Node(string value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class LinkedList
    {
        public Node? head = null;
        public int length = 0;
        public LinkedList(string value)
        {
            head = new Node(value);
            head.value = value;
            head.next = null;
            length++;
        }
        public void PrintLL()
        {
            if (this.head == null)
                Console.WriteLine("Nothing to Print");
            var currentNode = head;
            while (currentNode.next != null)
            {
                Console.WriteLine(currentNode.value);
                currentNode = currentNode.next;
            }
            Console.WriteLine(currentNode.value);

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

        public void PrePend(string value)
        {
            var newNode = new Node(value);
            newNode.next = this.head;
        } 
        public void Insert(int index, string value)
        {
            var newNode = new Node(value);
            var leader = TraverseToIndex(index - 1);
            var holdingPointer = leader.next;
            leader.next = newNode;
            newNode.next = holdingPointer;
        }

        public Node TraverseToIndex(int index)
        {
            var counter = 0;
            var currentNode = this.head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

        public void Remove(int index)
        {

        }
    }
}



