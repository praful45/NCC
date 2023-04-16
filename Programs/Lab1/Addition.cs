using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Addition
    {
        static void Main()
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a + b;
            //Console.WriteLine(c);
            //int? salary = null;
            //string ename = null;
            //Console.WriteLine("the salary is " + (salary??0));
            //Console.WriteLine("the name is " + (ename ?? "No Name"));

            dynamic a = 10;
            a = "hello";
            Console.WriteLine(a.GetType());
            a = 5 * 10;
            Console.WriteLine(a.GetType()); 

        }
    }
}
