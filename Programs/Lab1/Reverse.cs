using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Reverse
    {
        static void Main()
        {
            int[] arr = { 11, 12, 13, 14, 15, 16, 17 };
            Console.WriteLine("Before Reverse");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            int n = arr.Length;
            for(int i  = 0; i < n/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }

            Console.WriteLine("\nAfter Reverse");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
