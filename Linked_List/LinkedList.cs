using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class LinkedList<Gtype> where Gtype : IComparable
    {
        public Node<Gtype> head;
        public void Add(Gtype data)
        {
            /*Node node = new Node(data);
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
           Console.WriteLine("{0} added to list", node.data);*/

            Node<Gtype> node = new Node<Gtype>(data);
            Node<Gtype> current = head, previous = null;
            while (current != null && current.data.CompareTo(node.data) < 0)
            {
                previous = current;
                current = current.next;
            }
            if (previous == null)
                head = node;
            else
            {
                previous.next = node;
            }
            node.next = current;
        }


        public void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node<Gtype> temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        public void InsertAtPosition(int position,Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<Gtype> temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }

        }

        internal Node<Gtype> RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        internal Node<Gtype> RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<Gtype> newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public bool Search(int value)
        {
            Node<Gtype> temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void Delete(Gtype data)
        {
            Node<Gtype> temp = head, previous = null;
            if (temp != null && temp.data.Equals(data))
            {
                head = temp.next;
                return;
            }
            while (temp != null && !temp.data.Equals(data))
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }
        public int Size()
        {
            int size = 0;
            Node<Gtype> temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

    }
}