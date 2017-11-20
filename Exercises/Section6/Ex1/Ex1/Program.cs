using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///create a list
            /// add a name
            /// if count = 1 display name added
            /// if count = 2 diplay name [0] and name [1]
            /// if count > 2 diplay name [0] and name [1] and count



            //prompt user for name
            //display reversed name using array.reverse();

            Console.WriteLine("Please enter you name");
            //var name = new List<string>();
            var name = Console.ReadLine();
            string[] arr;
            arr = name.Split(',');
            //arr = arr.Reverse();
            Console.WriteLine(arr);

            //
            //Console.WriteLine(arr.Reverse());




        }
    }
}
