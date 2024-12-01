using System;
using System.IO;
using System.Text;

namespace ReadFileUsingFileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile(@"c:\Programming.txt");
        }

        static void ReadFile(string path) //E.g. @"d:\text.txt"
        {
            // Buffers, áreas temporales de la memoria RAM
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var buffer = new byte[fileStream.Length];

            fileStream.Read(buffer);
            var result = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(result);

            fileStream.Flush(); // ensure that any data still in the buffer(bytesArray) is written to the file
            fileStream.Close(); //release any system resources associated with the object
        }
    }
}
