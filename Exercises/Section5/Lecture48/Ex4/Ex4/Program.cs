using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /////pick a number between 1 and 10
            Random random = new Random();
            int compNum = random.Next(0, 10);
            //Console.WriteLine(compNum);

            int trials = 4;
            ///// prompt user to select a number 
            Console.WriteLine("Guess a number");

            //cycle thru tries and guess computer's number
            for (int i = 0; i < trials; i++)
            {
                var userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum == compNum)
                {
                    Console.WriteLine("You won");
                    break;
                }
                if ((userNum != compNum) && (i == 3))
                {
                    Console.WriteLine("You lost");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }

            }


        }
    }
}
