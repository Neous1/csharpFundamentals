using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             prompt user for a number
             get number

            while list.count != 5
            foreach num in numbers
            if user input != num
                add num to list
            else
                display Error
                prompt for new number

            if list.count == 5
                do an insertion sort
             */

            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("get a number");
                var num = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(num))
                {
                    Console.WriteLine("Enter another numer other than " + num);
                    continue;
                }
                numbers.Add(num);
            }

            numbers.Sort();
            Console.WriteLine();

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
           
        }
    }
}
