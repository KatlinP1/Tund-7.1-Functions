using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace funktions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello kitten!");
            
            //Dry do not repeat yourself

            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine($"Result from main {c}");
            
            Sum(a,b);
            Sum(10,20);
            Hello();
            
            GreetByName("Miu");

        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine($"Result {x+y}");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello{name}");
        }
    }
}