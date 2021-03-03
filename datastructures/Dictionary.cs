using System;
using System.Collections.Generic;

namespace datastructures
{
    class Dictionary
    {
        Dictionary<int, string> name = new Dictionary<int, string>();
        
        public void addPlayers()
        {
            name.Add(1,"Vighnesh");
            name.Add(2,"Naman");
            name.Add(3,"Bharat");
        }
        public void getPlayers()
        {
            foreach(KeyValuePair<int, string> i in name)
            {
                Console.WriteLine("Id - {0}, Name - {1}",i.Key,i.Value);
            }
        }
    }
}
