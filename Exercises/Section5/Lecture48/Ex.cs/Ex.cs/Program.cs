using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.cs
{
    class Program
    {

        //static int calculate()
        //{
        //    sum += entry;
        //}
        static  int Main()
        {
            int sum = 0;
            Console.WriteLine("Give me a number");
            if (Console.ReadLine() != "ok")
            {
                var entry = Convert.ToInt32(Console.ReadLine());
                sum = sum + entry;
                Console.WriteLine("the sum is "+ sum);
                return sum;
            }
            
            else if (Console.ReadLine()== "ok")
            {
                return;
            }

        }
    }
}
