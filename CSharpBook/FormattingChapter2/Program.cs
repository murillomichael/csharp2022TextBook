using System.Globalization;
using System.Xml;

using static System.Console; // By doing this you will not have to specify what library when using methods from it.  Look at line 136

namespace FormattingChapter2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ways to format strings.
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            // Formatting within Console.WriteLine .
            Console.WriteLine(
                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
                );

            // Spacing for when we run.
            Console.WriteLine();

            string formatted = string.Format(

                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
                );

            // Example of a fake method and how we would pass in a formatted string.
            //WriteToFile(formatted); // writes the string into a file.

            // You can name up to 4 args when using string format.
            Console.WriteLine(
                format: "{0} {1} lived in {2}.",
                arg0: "roger",
                arg1: "Cevung",
                arg2: "Stockhom"
                );

            // Spacing for when we run.
            Console.WriteLine();

            // Anything over 3 parameters (args) will have ti be unnamed.
            Console.WriteLine(
                format: "{0} {1} lived in {2}, {3} and worked in the {4} team at {5}.",
                "Roger", "Cevung", "Stockholm", "Sweden", "Education", "Optimizely");

            // Spacing for when we run.
            Console.WriteLine();

            // Using Interpolated strings.
            // Interpolated just fancy way of saying I am inserting a value or expression into a string
            // String must start with $ to be considered a interpolated string.
            Console.WriteLine($"{numberOfApples}  apples cost {pricePerApple * numberOfApples}");

            // Spacing for when we run.
            Console.WriteLine();

            // Before C# 10 you had to combine string by concatenating the strings.
            string str1 = "Hello";
            string str2 = " Xin";

            string str3 = str1 + str2;

            Console.WriteLine(str3);

            // Now on C# 10 you can combine strings by Interpolated strings.
            // This will only work for const strings.
            string str4 = $"{str1} {str2}";

            Console.WriteLine(str4);

            // Spacing for when we run.
            Console.WriteLine();

            // You can alignment with in formatting strings.
            // Negative integer numbers align to the left.
            // Positive integer values align to right.

            // This can be use full for creating tables.

            // N0 -> adds seperatoring for integers depending what the local computer is using


           /* An N0 format string means a number with thousands separators and no decimal places, while a C
            * format string means currency.The currency format will be determined by the current thread.
            * For instance, if you run code that uses the number or currency format on a PC in the UK, you’ll get
            * pounds sterling with commas as the thousands separators, but if you run it on a PC in Germany, you
            * will get euros with dots as the thousands separators. 
            */

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananaCount = 56789;

            Console.WriteLine(
                format: "{0,-10} {1,6}",
                arg0: "Name",
                arg1: "Count"
                );

            Console.WriteLine(
                format: "{0,-10}{1,6:N0}",
                arg0: applesText,
                arg1: applesCount
                );

            Console.WriteLine(
                format: "{0,-10}{1,6:N0}",
                arg0: bananasText,
                arg1 : bananaCount
                );
            
            // Spacing for when we run.
            Console.WriteLine();

            Console.WriteLine("Type your first name");
            // Placing a ? after a string it tell complier we might expect a null.
            // string firstName? = Console.ReadLine();
            string firstName = Console.ReadLine();
            Console.WriteLine("Type your age and press enter");
            // Placing a ! is known as a nail forgiving operator.
            // Tell complier it will not return null.
            // Maker sure to ensure it does not return null.
            // string age! = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine($"HEllo {firstName}, you look good for {age}.");

            // We are using System.Console statically look at line 4.
            WriteLine("Hello We using the write line but statically ");

            // We can grab inputs from user by using ReadKey()method 

            // Here we prompt user to enter any combination of keys.
            // Note we are using Write instead of writeline because we do not want to start on a new line.
            Write("Press Any Key combination: ");
            // Here we are storing the key strokes into a variable called consoleKeyInfo.
            ConsoleKeyInfo consoleKeyInfo= Console.ReadKey();
            WriteLine(); // Done for spacing.
            // Here we display the key , its character and any modification for example Shift to make upper case.
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: consoleKeyInfo.Key,
                arg1: consoleKeyInfo.KeyChar,
                arg2: consoleKeyInfo.Modifiers
                );


        }   
    }
}