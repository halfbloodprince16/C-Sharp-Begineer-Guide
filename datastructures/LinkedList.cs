using System;
using System.Text;
using System.Collections.Generic;

namespace datastructures
{
    class LinkedList
    {
        LinkedList<string> lin = new LinkedList<string>();
        
        public void addGround()
        {
            lin.AddFirst("Sydney");
            lin.AddFirst("Melbourne");
            LinkedListNode<string> current = lin.Find("Sydney");
            lin.AddBefore(current, "Copenhagem");
        }
        public void getGround()
        {
            Console.WriteLine("First Ground - {0}", lin.First.Value);
            Console.WriteLine("Last Ground - {0}", lin.Last.Value);
        }
    }
}