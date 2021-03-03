using System;
using System.Collections.Generic;

namespace datastructures
{
    class Lists
    {
        List<string> name = new List<string>();
        public void addCoach()
        {
            name.Add("Rahul Dravid");
            name.Add("Adam Gilchrist");
            name.Add("Sunil Gavaskar");
        }

        public void getCoach()
        {
            foreach(var i in name)
            {
                Console.WriteLine("Coach Name - {0}",i);
            }
        }
    }
}
