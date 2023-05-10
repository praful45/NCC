//1.
//Write a C# program using async and wait  for long process.

namespace LAB_3
{
    internal class Program
    {
        public static Task ProcessCheck()
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1000);
            });
        }

        public static async void CallProcess()
        {
            await ProcessCheck();
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
            //Q1
            //CallProcess();
            //Console.WriteLine("Program finished");
            //Console.ReadKey();

            //Q2
            //UpperCaseLINQ.FindUpperCase("Hello Guys How Are You");

            //Q3
            //int[] numbers = { 1, 5, 3, 7, 4 };
            //Q3NumSqr.CountSquare(numbers);

            //Q4
            //Q4CharFrequency.CharFrequency("this is apple");

            //Q5
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEWDELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //Q5StartEndChar.StartEndChar(cities);

            //Q6
            //Q6JoinObjects.JoinObj();

        }
    }
}