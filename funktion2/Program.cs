using System;

namespace funktion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Color:");
            color = Console.ReadLine();
            KnowMe(name, color);
            
        }

        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello,{name}.Your favorite color is {color}");
        }
    }
}