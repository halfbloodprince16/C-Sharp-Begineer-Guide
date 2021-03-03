using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading m = new MethodOverloading();
            m.Operate();

            Vehicle v = new Vehicle();
            Vehicle c = new Car();
            String veh = Console.ReadLine();
            String mod = Console.ReadLine();
            v.Operate(veh);
            c.Operate(mod);
        }
        
    }
}
