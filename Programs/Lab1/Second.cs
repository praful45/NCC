using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Second
    {
        static void Main(string[] args)
        {
            string file1 = "c:\\abc\\sem\\dotnet.txt";
            string file2 = "c:/abc/sem/dotnet.txt";
            string file3 = @"c:\abc\sem\dotnet.txt";

            Console.WriteLine(file1);
            Console.WriteLine(file2);
            Console.WriteLine(file3);
        }
    }
}
