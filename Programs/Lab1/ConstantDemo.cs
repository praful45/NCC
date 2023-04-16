using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ConstantDemo
    {
        enum Gender
        {
            Female,
            Male
        }
        static void Main()
        {
            Console.WriteLine("hello");
            Gender gen = Gender.Female;

            Console.WriteLine("The selected gender is " + (int)gen);
        }
    }
}
