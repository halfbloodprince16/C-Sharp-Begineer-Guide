using System;

namespace myapp
{
    class Vehicle
    {
        public virtual void Operate(String name)
        {
            Console.WriteLine("It is Vehicle class "+name);
        }
    }
}
