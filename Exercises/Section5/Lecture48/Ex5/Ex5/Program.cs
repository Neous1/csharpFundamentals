using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for 5 numbers
            
            // populate an array with users input

            //loop thru array 
            /*set i temp
            if i + 1 > temp 
            set temp to i + 1 
            else do nothing
            if i = array.length
            print temp.
            */

            Console.WriteLine("enter num separated by commas");
            //take users input and separated by commas.
            var input = Console.ReadLine();
            var num = input.Split(',');
            Console.WriteLine(Convert.ToInt32(num));
        }
    }
}
