using System;

namespace myapp
{
    class MethodOverloading
    {
        public
        int Sum(int a, int b)
        {
            return(a+b);
        }
        double Sum(double a, double b)
        {
            return(a+b);
        }
        public
        void Operate()
        {
            Console.WriteLine(Sum(5,6));
            Console.WriteLine(Sum(6.5,5.6));
        }
    }
}
