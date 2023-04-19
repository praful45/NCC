//4.Write a C# program to print 1 to 10 using generic list.
using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class GenericList
    {
        static void Main()
        {
            //Create a new generic list of integers
            List<int> numbers = new List<int>();

            //Add the numbers from 1 to 10 to the list
            for(int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
