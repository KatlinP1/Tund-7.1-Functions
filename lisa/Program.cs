using System;

namespace lisa
{
    class Program
    {
        static void Main(string[] args)
        {
            //ülesanne 2
            Random rnd= new Random();
            bool gameOver = false;
            int counter = 0;
            int cpuNumber = rnd.Next(1, 11);

            while (!gameOver)
            {
                Console.WriteLine("Enter your number from 1 to 10:");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == cpuNumber)
                {
                    Console.WriteLine("You won!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    counter++;
                }

                if (counter == 4)
                {
                    Console.WriteLine("You lost!");
                }
            }

            Console.ReadLine();
        }
    }
}