using System;
using System.Collections.Generic;

namespace datastructures
{
    class Stack
    {
        Stack<string> s = new Stack<string>();
        public void push()
        {
            s.Push("Vighnesh");
            s.Push("Naman");
            s.Push("Bharat");
        }
        public void pop()
        {
            s.Pop();
        }

        public void peek()
        {
            Console.WriteLine("Peek Element is - {0}",s.Peek());
        }
    }
}