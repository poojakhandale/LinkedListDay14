using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }

        public class MyLinkList
        {

            public Node head;
            private int Count;

            public void Add(int data)
            {
                Node node = new Node(data);
                Count++;

                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node temp = this.head;

                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} is created", node.data);
            }


            public void insert(int position, int data)
            {
                int current_positon = 1;
                Node previousNode = null;
                Node newnode = new Node(data);
                if (position > this.Count)
                {
                    Console.WriteLine("Position exceed out of range");
                    return;
                }
                Node temp = this.head;
                while (current_positon < position)
                {

                    if (current_positon == position - 1)
                    {
                        previousNode = temp;
                        break;
                    }
                    current_positon++;
                    temp = temp.next;
                }
                newnode.next = previousNode.next;
                previousNode.next = newnode;
                this.Count++;
            }
            public void display()
            {
                Node temp = this.head;

                if (temp == null)
                {
                    System.Console.WriteLine("list is empty");
                    return;
                }

                while (temp != null)
                {

                    Console.WriteLine(temp.data);
                    temp = temp.next;

                }
            }
            public void DeleteFirst()
            {
                if (head == null)
                {
                    Console.WriteLine("list is empty");
                    return;
                }
                head = head.next;

            }
            public void Deletetail()
            {
                if (head == null)
                {
                    System.Console.WriteLine("list is empty");
                }
                if (head.next == null)
                {
                    head = null;
                }
                Node Current = head;
                while (Current.next.next != null)
                {
                    Current = Current.next;
                }
                Current.next = null;
            }
        }
    }
}
    

