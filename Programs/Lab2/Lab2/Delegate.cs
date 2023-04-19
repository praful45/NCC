//1.Write a C# program to add two digit using delegates.
using System;

namespace Lab2
{
    public delegate int AddDelegate(int a, int b);
    internal class Delegate
    {
        private static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int num1 = 45;
            int num2 = 50;

            AddDelegate add = new AddDelegate(Add);
            int sum = add(num1, num2);

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
            Console.ReadKey();
        }
    }
}
