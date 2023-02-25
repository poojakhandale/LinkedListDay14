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

        public class LinkList
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
        }
    }
}