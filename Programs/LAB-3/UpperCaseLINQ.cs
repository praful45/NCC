
//2.
//Write a program to find the upper case letter in
//string using LINQ

namespace LAB_3
{
    public class UpperCaseLINQ
    {
        public static void FindUpperCase(string inputString)
        {
            Console.WriteLine("The given string is : {0}",inputString);
            // LINQ to find all uppercase letters in the string
            var uppercaseLetters = from c in inputString
                                   where char.IsUpper(c)
                                   select c;

            // Print the uppercase letters
            Console.WriteLine("Uppercase letters in the string:");
            foreach (var letter in uppercaseLetters)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
