//Write a C# program to sort given name using LINQ.
//a. Ram, Shyam, Hari, Bikash, Mahesh
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class LINQSort
    {
        static void Main()
        {
            List<string> names = new List<string>
            {
                //create a list of names
                "Ram","Shyam","Hari","Bikash","Mahesh"
            };

            //sort the names using LINQ
            var sortedNames = from name in names   
                              orderby name
                              select name;

            //print the sorted names
            foreach(string name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
