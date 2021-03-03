using System;

namespace datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lets practice data structures in C#");

            Console.WriteLine("Dictionary");
            Dictionary dic = new Dictionary();
            dic.addPlayers();
            dic.getPlayers();

            Console.WriteLine("List");
            Lists li = new Lists();
            li.addCoach();
            li.getCoach();

            Console.WriteLine("Queue");
            Queue q = new Queue();
            q.enqueue();
            q.peek();
            q.dequeue();
            q.peek();

            Console.WriteLine("Stack");
            Stack s = new Stack();
            s.push();
            s.peek();
            s.pop();
            s.peek();

            Console.WriteLine("Linked List");
            LinkedList l = new LinkedList();
            l.addGround();
            l.getGround();
        }
    }
}
