using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /////pick a number between 1 and 10
            ///// prompt user to select a number 
            ///// if user number == computer number ; 
            ///// display sign you won
            ///// else you loose.
            ///// 
            
            Random random = new Random();
            int compNum = random.Next(0, 10);
            Console.WriteLine(compNum);


            int trials = 4;

            for (int i = 0; i < trials; i++)
            {
                Console.WriteLine("Guess a number");
                var userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum == compNum)
                {
                    Console.WriteLine("You won");
                    break;
                }

            }


        }
    }
}
