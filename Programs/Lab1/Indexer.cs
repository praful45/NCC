using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Students
    {
        private string[] name = new string[5];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }

        }
    }
    internal class Indexer
    {
        static void Main()
        {
            Students students = new Students();

            students[0] = "Praful Shrestha";
            students[1] = "Prabin Gurung";
            students[2] = "Bibek Lamichhane";

            Console.WriteLine(students[0]); 
            Console.WriteLine(students[1]); 
            Console.WriteLine(students[2]); 
        }
    }
}
