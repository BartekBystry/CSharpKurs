using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            //Console.WriteLine("Witaj świecie!");
            //Console.WriteLine("Witaj " + name);

            //foreach(var item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}

            for(; ; )
            {
                string name = greetings();
                age(name);
                settings();
            }

        }

        private static void settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void age(string name)
        {
            Console.Write("podaj swój wiek : ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo " + name + ", możesz pić browara!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek " + name);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Mogę ci " + name + " zaproponować soczek :) ");
            }
        }

        private static string greetings()
        {
            Console.Write("Podaj imię : ");
            string name = Console.ReadLine();
            Console.WriteLine("witaj " + name + "!");
            return name;
        }
    }
}
