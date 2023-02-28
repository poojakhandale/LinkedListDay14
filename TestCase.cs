using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructure.Node;

namespace LinkedList
{
 public class TestCase
    {
        public void tc8(MyLinkList linkedList, int Search_element, int new_element)
        {
            int position = linkedList.Search(30);
            if (position == 0)
            {
                Console.WriteLine("element is not found");
            }
            else
            {
                linkedList.insert(position + 1, new_element);
                linkedList.display();
                Console.WriteLine("element is found in " + position + "and new element " + new_element + " is inserted");
            }
        }

    }
}

    

