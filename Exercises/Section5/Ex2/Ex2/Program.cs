using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Give me 2 numbers");

                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("the number " + num1 + " is greater");
                }
                else if (num2 > num1)
                {
                    Console.WriteLine("the number " + num2 + " is greater");
                }
                else
                {
                    Console.WriteLine("There are equal");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
