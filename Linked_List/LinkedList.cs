using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} added to list", node.data);

        }


        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        public void InsertAtPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }

        }

        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        internal Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
    }
}