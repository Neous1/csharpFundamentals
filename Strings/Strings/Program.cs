﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Yvon Joel ";
            Console.WriteLine("trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index +1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: "+ names[0]);
            Console.WriteLine("LastName: "+ names[1]);

            Console.WriteLine(fullName.Replace("Joel", "Jolie"));
            Console.WriteLine();
            //isNullOrEmpty
            if(String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");
            Console.WriteLine();
            //convert
            var str = 42;
            var age = Convert.ToByte(str);// noone canbe 255 yo
            Console.WriteLine(age);
            Console.WriteLine();

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));//"CO argument will round it up to 30 from 29.95



        }
    }
}
