using System;
using System.Collections.Generic;
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


            var count = 0;
            var numbers = new List<int>();
            Console.WriteLine("list is : " + numbers[0]);
            while (count <= 5)
            {
                Console.WriteLine("Please enter a number");
                var num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
                foreach (var item in numbers)
                {
                    if (num != item)
                    {
                        numbers.Add(num);
                        count++;
                    }
                    else
                        Console.WriteLine("Please enter a non existing number");
                }
            }
                
        }
    }
}
