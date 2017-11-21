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

            //var files = Directory.GetFiles(@"c:\users\yvon\dev\csharpFundamentals", "*.txt", SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\users\yvon\dev", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists(".....");//specify a path to check if it exist


            var directoryInfo = new DirectoryInfo("......"); // specify path
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();


            var path = @"C:\Users\yvon\dev\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine();

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Diretory Name: " + Path.GetDirectoryName(path));

        }
    }
}
