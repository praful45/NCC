//2.Write a C# program to display student Id and Name using automatic properties.
using System;

namespace Lab1
{
    internal class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Student
    {
        static void Main()
        {
            StudentInfo st = new StudentInfo
            {
                Id = 1,
                Name = "Praful Shrestha"
            };

            Console.WriteLine($"Id = {st.Id}");
            Console.WriteLine($"Name = {st.Name}");
        }
    }
}
