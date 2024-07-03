
using System;

namespace LinkedList
{
    public class Node
    {
        int data;
        Node next;
        Node previous;
        public int Data 
        {
            get { return data; }
            set { data = value; }
        }
        public Node Next 
        {
            get { return next; }
            set { next = value; }
        }
        public Node Previous 
        {
            get { return previous; }
            set { previous = value; }
        }
        public Node(int value) 
        {
            data = value;
            next = null;
            previous = null;
        }
    }
}
