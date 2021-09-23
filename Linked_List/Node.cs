using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class Node<Gtype>
    {
        public Gtype data;
        public Node<Gtype> next;
        public Node(Gtype data)
        {
            this.data = data;
        }
    }
}
