
//5.
//Write a program in C# Sharp to find the string
//which starts and ends with a specific character to find the string which starts
//and ends with a specific character.
//The cities are :
//'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEWDELHI','AMSTERDAM','ABU DHABI','PARIS'
namespace LAB_3
{
    public class Q5StartEndChar
    {

        public static void StartEndChar(string[] cities)
        {
            Console.WriteLine("The list of cities are:");
            foreach(string c in  cities)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();

            Console.Write("Enter a starting character: ");
            char startChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter an ending character: ");
            char endChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // LINQ to find the strings in the array that start and end with the specified characters
            var matchingCities = from city in cities
                                 where city.StartsWith(startChar.ToString().ToUpper()) && city.EndsWith(endChar.ToString().ToUpper())
                                 select city;

            // Print the results
            Console.WriteLine($"Cities starting with '{startChar}' and ending with '{endChar}':");
            foreach (var city in matchingCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
