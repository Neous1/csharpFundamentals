using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
                var builder = new StringBuilder("Hello World");
                builder.Append('-', 10);

                Console.WriteLine(builder);
            
        }
    }
}
