// See https://aka.ms/new-console-template for more information
using LinkedList;
using static DataStructure.Node;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main(string[] args)
    {
        MyLinkList linkList = new MyLinkList();
        linkList.Add(56);
        linkList.Add(70);
        linkList.insert(2, 30);
        TestCase mycase = new TestCase();
        mycase.tc8(linkList, 30, 40);
    }
}






