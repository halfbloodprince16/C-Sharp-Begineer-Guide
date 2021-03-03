using System;

namespace myapp
{
    class Car :  Vehicle
    {
        public override void Operate(String name)
        {
            Console.WriteLine("Car Class is called "+name);
        }
    }
}
