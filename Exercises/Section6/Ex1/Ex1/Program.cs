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

            List<string> Names = new List<string>();
            var count = 0;
            string name;

            do
            {
                Console.WriteLine("Enter a name");
                name = Console.ReadLine();
                if(name != "")
                {
                    Names.Add(name);
                    count++;
                }

            } while (name != "");

            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);
            //}

            if(count == 1)
            {
                Console.WriteLine(Names[0]);
                
            }
            else if (count == 2)
            {
                Console.WriteLine(Names[0], Names[0]);
            }
        }
    }
}
