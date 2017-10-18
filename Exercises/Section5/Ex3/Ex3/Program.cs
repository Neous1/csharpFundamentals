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
            Console.WriteLine("What's the width of the frame");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the height of the frame");

            var height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("the image is Landscape");
            }
            else
            {
                Console.WriteLine("the image is Portrait");
            }
        }
    }
}
