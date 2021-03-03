using System;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lets work with files");
            var Date = DateTime.Now;
            string dat = Date.ToString("yyyyMMdd");
            string path = @"/home/hbp16/Documents/files/file"+dat+".txt";
            if(!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("This is first line");
                    sw.WriteLine("This is 2nd line");
                    sw.WriteLine("This is third line");
                }
            }

            using(StreamReader sr = File.OpenText(path))
            {
                string s;
                while((s = sr.ReadLine())!= null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
