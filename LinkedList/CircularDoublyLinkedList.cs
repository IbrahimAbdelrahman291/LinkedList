using System;

namespace LinkedList
{
    public class CircularDoublyLinkedList
    {
        Node Head;
        public CircularDoublyLinkedList() 
        {
            Head = null;
        }
        public void Add(int value) 
        {
            Node newNode = new Node(value);
            if (Head == null) 
            {
                Head = newNode;
                newNode.Next = Head;
                newNode.Previous = Head;
            }
            else
            {
                Node last = Head.Previous;

                last.Next = newNode;
                newNode.Previous = last;
                newNode.Next = Head;
                Head.Previous = newNode;
            }
        }
        public void Remove(int value) 
        {
            int test = 0;
            if (Head == null)
            {
                Console.WriteLine("Already Empty");
                return;
            }

            Node Temp1 = Head;
            Node Temp2 ;
            if (Temp1.Data == value)
            {
                if (Temp1.Next == Head)
                {
                    Head = null;
                    Console.WriteLine("Removed");
                }
                else
                {
                    Temp2 = Head.Previous;
                    Head = Head.Next;
                    Head.Previous = Temp2;
                    Temp2.Next = Head;
                    Console.WriteLine("Removed");
                }
                return;
            }
            Temp2 = Head;
            while (Temp1.Next != Head)
            {
                if (Temp1.Data == value)
                {
                    Temp1 = Temp1.Next;
                    Temp2.Next = Temp1;
                    Temp1.Previous = Temp2;
                    Console.WriteLine("Removed");
                    return;
                }
                Temp2 = Temp1;
                Temp1 = Temp1.Next;
            }
            if (test == 0)
            {
                Console.WriteLine("Not Found!");
            }
        }
        public void Search(int value) 
        {
            int test = 0;
            int count = 0;
            if (Head == null)
            {
                Console.WriteLine("List already empty");
            }
            else
            {
                Node Temp1 = Head;
                Node Temp2 = Head.Previous;  
                while (true)
                {
                    count++;
                    if (Temp1.Data == value || Temp2.Data==value)
                    {
                        Console.WriteLine($"Founded in {count} steps");
                        return ;
                    }
                    Temp1 = Temp1.Next;
                    Temp2 = Temp2.Previous;
                    if (Temp1 == Temp2)
                    {
                        break;
                    }
                }
                if (test == 0)
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
        public void Display() 
        {
            if (Head == null)
            {
                Console.WriteLine("List already is empty");
                return;
            }
            else 
            {
                Node Temp = Head;
                if (Temp.Next == Head)
                {
                    Console.WriteLine("______________________________");
                    Console.WriteLine(Temp.Data);
                    Console.WriteLine("______________________________");
                    return;
                }
                Console.WriteLine("______________________________");
                while (true)
                {
                    Console.WriteLine(Temp.Data);
                    Temp = Temp.Next;
                    if (Temp == Head)
                    {
                        break;
                    }
                }
                Console.WriteLine("______________________________");
            }
        }
    }
}
