using System;
using System.CodeDom.Compiler;
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
            

            ///pick a number between 1 and 10
            /// prompt user to select a number 
            /// if user number == computer number ; 
            /// display sign you won
            /// else you loose.
            /// 
            
            Random random = new Random();
            int comp = random.Next(0, 10);

            Console.WriteLine("guess which number");
            Console.ReadLine("")
            Console.WriteLine(comp);


        }
    }
}
