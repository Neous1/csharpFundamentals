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

            int speedLimit = 75;

            Console.WriteLine("How fast were you going");
            var userSpeed = int.Parse(Console.ReadLine());

            if (userSpeed <= speedLimit)
            {
                Console.WriteLine("OK!");
            }else if (userSpeed > speedLimit)
            {
                var demerits = userSpeed - speedLimit;
                Console.WriteLine("You are " + demerits + "km/h above speed limit.");
                if (demerits <= 5)
                {
                    Console.WriteLine("You've incurred 1 demerits points ");
                }else if (demerits <= 10)
                {
                    Console.WriteLine("You've incurred 2 demerits points ");
                }
                else if (demerits > 12)
                {
                    Console.WriteLine("Call your mom, your license is suspended");
                }
            }
        }
    }
}
