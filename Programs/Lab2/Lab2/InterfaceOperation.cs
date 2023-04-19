using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface IArithmetic
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);  
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
       
    }

    public class Arithmetic : IArithmetic
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

    }
    internal class InterfaceOperation
    {
        static void Main()
        {
            IArithmetic arithmetic = new Arithmetic();

            double num1 = 84;
            double num2 = 42;

            Console.WriteLine("Addition: {0}", arithmetic.Add(num1, num2));
            Console.WriteLine("Subtraction: {0}", arithmetic.Subtract(num1, num2));
            Console.WriteLine("Multiplication: {0}", arithmetic.Multiply(num1, num2));
            Console.WriteLine("Division: {0}", arithmetic.Divide(num1, num2));

            // Attempting to divide by zero
            try
            {
                Console.WriteLine(arithmetic.Divide(num1, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
