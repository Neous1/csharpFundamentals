using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter a number");
            var input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(input);

            foreach (var item in numbers)
            {
                if (numbers.Distinct)
                {

                }

            }
            

        }
    }
}
