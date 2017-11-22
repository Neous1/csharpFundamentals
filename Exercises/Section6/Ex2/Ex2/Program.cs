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
            Console.WriteLine("Please enter you name");
            var name = Console.ReadLine();
            var result="";
            if (name != null)
            {
                 result = new string(name.Reverse().ToArray());
            }
            Console.WriteLine(result);
        }
    }
}
