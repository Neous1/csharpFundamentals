using System;

namespace Ex1
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Please enter a number between 1-10");

            var userInput = Int32.Parse(Console.ReadLine());
            if (userInput >= 0 && userInput <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
