// See https://aka.ms/new-console-template for more information
using LinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        Node head = new Node(56);
        Node second = new Node(70);
        Node tail = new Node(30);
        head.next = second;
        second.next = tail;

    }
}


