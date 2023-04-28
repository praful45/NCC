//3.
//Write a program in C# Sharp to find the number
//of an array and the square of each number using LINQ

namespace LAB_3
{
    public class Q3NumSqr
    {
        public static void CountSquare(int[] nums)
        {
            //number of elements in the array
            int count = nums.Length;

            //LINQ to find the square of each element in the array
            var squares = from n in nums
                          select n * n;

            //results
            Console.WriteLine($"Number of elements in the array: {count}");
            Console.WriteLine($"Given array:");
            foreach(var n in nums)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();

            Console.WriteLine($"Square of each element in the array:");
            foreach(var square in squares)
            {
                Console.Write(square + " ");
            }
        }
    }
}
