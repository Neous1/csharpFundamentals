using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\users\yvon\dev\csharpFundamentals", "*.sln", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);
        }
    }
}
