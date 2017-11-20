using System;
using TimeSpan;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new System.TimeSpan(1, 2, 3);

            var timeSpan1 = new System.TimeSpan(1, 0, 0);
            var timeSpan2 = System.TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration :" + duration);


        }
    }
}
