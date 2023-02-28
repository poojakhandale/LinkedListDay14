// See https://aka.ms/new-console-template for more information
using LinkedList;
using static LinkedList.Node;

public class Program
{
    public static void Main(string[] args)
    {
    
            MyLinkList linkList = new MyLinkList();
            linkList.Add(56);
            linkList.Add(70);
            linkList.insert(2, 30);
             
        linkList.Search(30);

        linkList.display();
        }
    }


