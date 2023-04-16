using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\tGood World");
            Console.WriteLine("Good Day");
            //Console.ReadKey();

            Console.WriteLine("Enter name, course and college");
            string name = Console.ReadLine();
            string course = Console.ReadLine();
            string college = Console.ReadLine();

            Console.WriteLine(name + " you are joined in " + course + " course in " + college + " college");
            //another way
            Console.WriteLine("{0} you are joined in {1} course in {2} college ", name, course, college);
            //String Interpolation
            Console.WriteLine($"{name} you are joined in {course} course in {college} college");
        }
    }
}
