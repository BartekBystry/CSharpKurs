using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            Console.WriteLine("Witaj świecie!");
            //Console.WriteLine("Witaj " + name);
            
            foreach(var item in args)
            {
                Console.WriteLine("Witaj " + item);
            }
        }
    }
}
