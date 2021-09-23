using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class LinkedList<Gtype>where Gtype : IComparable
    {
        public Node<Gtype> head;
        /// <summary>
        /// method to add data by sorting
        /// </summary>
        /// <param name="data"></param>
        public void Add(Gtype data)
        {
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

        /// <summary>
        /// mathod to display linked list elements
        /// </summary>
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

        /// <summary>
        /// method to insert elelment at perticular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// 
        public void Insert(int position,Gtype data)
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

        /// <summary>
        /// method to remove first node from linked list
        /// </summary>
        /// <returns></returns>
        public Node<Gtype> RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        public Node<Gtype> RemoveLastNode()
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

        /// <summary>
        /// method to check particular element in present or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// method to delete user given element
        /// </summary>
        /// <param name="data"></param>
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

        /// <summary>
        /// method to find the size of linked list
        /// </summary>
        /// <returns></returns>
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