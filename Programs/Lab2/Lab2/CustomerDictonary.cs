//5.Write a C# program to print CustomerId and CustomerName using Dictionary.
using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class CustomerDictonary
    {
        static void Main()
        {
            Dictionary<int, string> customers = new Dictionary<int, string>
            {
                { 1, "Praful Shrestha" },
                { 2, "Prabin Gurung" },
                { 3, "Bibek lamichhane" },
                { 4, "Prajwal Sapkota" },
                { 5, "Amrit Rijal" }
            };
            //another way of initialization
            //customers.Add(1, "Praful Shrestha");
            //customers.Add(2, "Prabin Gurung");
            //customers.Add(3, "Bibek lamichhane");
            //customers.Add(4, "Prajwal Sapkota");
            //customers.Add(5, "Amrit Rijal");

            foreach(KeyValuePair<int,string> customer in customers)
            {
                Console.WriteLine($"Id: {customer.Key}, Name: {customer.Value}");
            }
        }
    }
}
