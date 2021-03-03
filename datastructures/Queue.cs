using System;
using System.Collections.Generic;

namespace datastructures
{
    class Queue
    {
        Queue<string> q = new Queue<string>();

        public void enqueue()
        {
            q.Enqueue("Vighnesh");
            q.Enqueue("Namam");
            q.Enqueue("Bharat");
        }
        public void dequeue()
        {
            q.Dequeue();
        }

        public void peek()
        {
            Console.WriteLine("Peek element is - {0}",q.Peek());
        }
    }
}