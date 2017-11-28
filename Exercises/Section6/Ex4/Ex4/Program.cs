using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    /**
     * 4- Write a program and 
     * ask the user to continuously enter a number or type "Quit" to exit. 
     * The list of numbers may include duplicates. 
     * Display the unique numbers that the user has entered.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            while (input != "quit")
            {
                    if (input != "quit")
                        numbers.Add(Convert.ToInt32(input));
                    else //if (numbers.Count > 0)

                        foreach (var number in numbers)
                            Console.WriteLine(number);
                break;
            }

        }
    }
}
