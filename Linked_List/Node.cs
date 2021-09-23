using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class Node<Gtype> //Generic type
    {
        public Gtype data;
        public Node<Gtype> next;
        public Node(Gtype data) //constuctor
        {
            this.data = data;
        }
    }
}
