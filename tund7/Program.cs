using System;

namespace tund7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ülesanne 1
            int counter = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
            Console.WriteLine($"Total{counter}");
        }
    }
}