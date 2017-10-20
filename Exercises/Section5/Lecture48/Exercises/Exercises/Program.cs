using System;
using System.Runtime.InteropServices;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            //    if (args == null) throw new ArgumentNullException(nameof(args));
            //    int count = 0;
            //    for (var i = 0; i <= 100; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("count is :"+count);
            Ex3();
        }

        //public void Ex2()
        //{
        //    while (Console.ReadLine() != "ok")
        //    {
        //        Console.WriteLine();
        //    }
        //}
        /*
        write a program and ask the user to enter a number. 
        Computer the factorial of the nbmer and print it onthe console. 
        For example, if the user enters 5, the program shold calculate 
        5x4x3x2x1 and display it as 5! = 120
        */
        public static int Ex3()
        {
            //int result = 0;
            //Console.WriteLine("Enter a number");
            //Console.ReadLine();
            ////var n = int.Parse(Console.ReadLine());
            //var n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n);

            //while (n >= 1)
            //{
            //     result = n * (n - 1);
            //    n--;
            //}
            //Console.WriteLine(result);

            //*****************************************************
            Console.WriteLine("Enter a number");
            var n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1)
            {
                return 1;
                
            }
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }

            return result;
            Console.WriteLine(result);
        }
        
        



    }
}
