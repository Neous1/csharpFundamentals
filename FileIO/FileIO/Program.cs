using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\Users\yvon\dev\CSharpFundamentals\sample.txt", @"c:\Users\yvon\dev\CSharpFundamentals\Files\sample.txt", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //statement
            }
        }
    }
}
