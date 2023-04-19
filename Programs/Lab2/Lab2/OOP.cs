//2.Write a C# program to Add, Subtract, Multiply, Divide using OOP.
using System;

namespace Lab2
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
    internal class OOP
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());  

            Calculator calculator = new Calculator();

            Console.WriteLine("Sum: " + calculator.Add(num1, num2));
            Console.WriteLine("Difference: " + calculator.Subtract(num1, num2));
            Console.WriteLine("Product: " + calculator.Multiply(num1, num2));
            if(num2 != 0)
            {

                Console.WriteLine("Quotient: " + calculator.Divide(num1, num2));
            }
            else
            {
                Console.WriteLine("Cannot be divided by zero!");
            }
            Console.ReadKey();  
        }
    }
}
