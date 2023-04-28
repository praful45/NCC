//4. Write a program in C# Sharp to display the
//characters and frequency of character from the string given by the user.

namespace LAB_3
{
    public class Q4CharFrequency
    {
        public static void CharFrequency(string str)
        {
            // LINQ to group the characters in the input string by their value
            var characterGroups = str.GroupBy(c => c);

            // Print the frequency of each character in the input string
            Console.WriteLine("Character frequency:");
            foreach (var group in characterGroups)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
        }
    }
}
