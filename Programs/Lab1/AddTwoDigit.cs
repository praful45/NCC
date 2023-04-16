using System;

namespace Lab1
{
    class AddTwoDigit
    {
        private int a;
        private int b;

        public AddTwoDigit(int c,int d)
        {
            a = c;
            b = d;
        }

        public int AddDigits()
        {
            return a + b;
        }

    }

    class ProgramMain 
    { 
        static void Main()
        {
            int a = 34;
            int b = 43;
            AddTwoDigit d = new AddTwoDigit(a, b);
            int res = d.AddDigits();

            Console.WriteLine($"The sum of {a} and {b} is {res}.");
        }
    }


}
