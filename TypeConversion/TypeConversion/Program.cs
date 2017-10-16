using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1; //1 byte
            //int i = b; // 4 bytes
            //Console.WriteLine(i);


            //int i = 1; 
            //byte b = (byte)i; 
            //Console.WriteLine(i);

            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b); // 232 some of the bytes would lost cuz 



        }
    }
}
