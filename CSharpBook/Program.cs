// Imported a name-space (is like a address for a type).
using System.Reflection;
using System;



namespace CSharpBook
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // declare some unused variables using types.
            // In additional assemblies
            System.Data.DataSet dataSet;
            HttpClient client;


            //#error version 
            Console.WriteLine();

            // Code is created by using statements.
            /*
             * This is a multi line comment you start with you must start and end with( /* * /)-> why space? 
             * spaces was added because our code will treat ( * /) like ending.
             * 
             * Here we have 3 statements.
             * First one is creating a variable subtotal and assign the integer 0 to our variable.
             * Second one is creating a variable saleTaxes and assign the integer 0 to our variable.
            */

            // initialize  subtotal variable and assign 0.
            var subtotal = 0;

            // initialize salesTaxes variable and assign 0.
            var saleTaxes = 0;

            // initialize a variable names totalPrices and assign the sum of subtotal and salesTaxes.
            var totalprice = subtotal + saleTaxes;



            // Methods are doing or action words within C#.


            // Outputs the current line terminator string.
            // By default, this is a carriage-return and line feed.
            Console.WriteLine();

            // Just adding spacing.
            Console.WriteLine("");


            // Outputs the greeting and the current line terminator string.
            Console.WriteLine("Hello Michael");

            // Just adding spacing.
            Console.WriteLine("");

            // Outputs a formatted number and date and the current line terminator string.
            Console.WriteLine("Temperature on {0:D} is {1}*C.", DateTime.Today, 23.4);

            // Just adding spacing.
            Console.WriteLine("");

            // Nouns are types, variables , fields and properties.

            // Types are nouns for categorizing things.

            // Fields or properties are nouns that belong to a Type.

            // Variables are nouns referring to a specific object.

            Assembly? myApp = Assembly.GetEntryAssembly();

            // Check if our object is null
            if (myApp == null)
            {
                // If so quit our application.
                return;
            }

            // Loop through the assemblies that my app references.
            foreach (AssemblyName name in myApp.GetReferencedAssemblies())
            {
                // Load the assembly so we can read its details.
                Assembly loadedAssembly = Assembly.Load(name);

                // declare a variable to count the number of assemblies.
                int count = 0;

                // Loop through all the types in the assembly.
                foreach (TypeInfo info in loadedAssembly.DefinedTypes)
                {
                    // add up the counts of methods.
                    count += info.GetMethods().Count();
                }

                // Output the count of types and their methods.
                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: loadedAssembly.DefinedTypes.Count(),
                    arg1: count,
                    arg2: name.Name);

            }

            // Spacing
            Console.WriteLine("");

            // Code of Conduct when Naming things and assigning variables in C#.
            /*  For Local Variables or Private Fields we will use Camel case.
             *  Camel casing means the first letter of the word is lower case and
             *  the next words within our name the first letter is capitalized.
             * 
             * For Types, non-private fields, and other members like methods.
             * We use Pascal case.
             * Pascal case means every first letter of each word is capitalized.
             * 
             */

            // Example of camel casing for variable.
            // This is a literal(1.72meters) number being stored in our notation(format).
            double heightOfMichael = 1.72;
            // Printing to console using name of variable.
            Console.WriteLine($"The variable {nameof(heightOfMichael)} has the measure meant of : {heightOfMichael}m.");

            // Spacing
            Console.WriteLine("");

            // Text is stored as chars (Well the basic text complex characters may take more).
            // Assigning Literal characters.
            char letter = 'A';
            char digit = '0';
            char symbol = '>';
            char userChoice = GetSomeKeystroke();

            // For Text or multiple letters,characters,and numbers (As text).
            // Assigning Literal Strings.
            string firstName = "Michael";
            string lastNAme = "Michael-Murillo";


            // assigning a string returned from the string class constructor.
            //string horizontalLine = new('-', count: 74); // 74 hyphens.
            // assigning a string returned from a fictitious function.
            // string address = GetAddressFromDatabase(id: 563);
            // assigning an emoji by converting from Unicode.
            //string grinningEmoji = char.ConvertFromUtf32(0x1F600);

            // To output emoji at command line on windows (Windows terminal is a must).
            // Setting our console to specific write output. 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Converting our emojis number to a char.
            string grinningEmoji = char.ConvertFromUtf32(0x1F600);
            // Writing Emoji t console.
            Console.WriteLine(grinningEmoji);



            /*
             * 
                • Literal string: Characters enclosed in double-quote characters. They can use escape characters 
                like \t for tab. To represent a backslash, use two: \\.

                • Raw string literal: Characters enclosed in three or more double-quote characters.

                • Verbatim string: A literal string prefixed with @ to disable escape characters so that a backslash 
                is a backslash. It also allows the string value to span multiple lines because the whitespace 
                characters are treated as themselves instead of instructions to the compiler.

                • Interpolated string: A literal string prefixed with $ to enable embedded formatted variables. 
                You will learn more about this later in this chapter.

             */

            // Using backSlash \ to add special effects to your string.
            // For Example \n makes a new line.
            // The Hello before \n will print.
            // Then the next hello will print on new line.
            Console.WriteLine("HEllo \nHEllo Again");

            // Spacing.
            Console.WriteLine("");

            // Well if you wanted to store a path (Location of a certain folder in your file-sysystem AKA OS AKA Computer).
            // You just have to tell it and the backslash will have not effect on your code.

            // Example of not clarifying we want to use a path.
            string badPath = "NAme\newUser\networks";
            Console.WriteLine(badPath);

            // Spacing.
            Console.WriteLine("");

            string notationPath = @"C:\michael\Desktop\Folder";
            Console.WriteLine(notationPath);

            // Spacing.
            Console.WriteLine("");

            // Raw string literals are convenient for entering any arbitrary text.
            // Raw string literals start and end with three or more double-quote characters.
            // Example storing xml.
            string xml = """
                <person age = 50>
                    <first_name>Michael</first_name>
                    </person>
                """;

            // Adding values to Raw string literals.
            var person = new { FirstName = "Michael", Age = 56 };

            // The amount of $ symbols you place infront will tell us how many curly braces are needed to place value.
            string json = $$"""
                {
                    "first_name": "{{person.Age}},
                    "Age": {{person.Age}},
                    "DOSomething": {{9 + 9}}
                }
                """;
            Console.WriteLine(json);

            // Spacing.
            Console.WriteLine("");


            //  unsigned integer means positive whole number or 0.
            uint naturaNumber = 23;

            // Integer means negative or positive whole number or 0.
            int integerNumber = -23;

            // Float means single-precision floating point.
            // F suffix means it a float literal.
            float realNumber = 2.3F;

            // Double means double-precision floating point.
            // Double is the default type of a number value with a decimal.
            double anotherRealNumber = 2.3;

            // Using _ to store different notations.
            // Decimal Notation.
            int decimalNotation = 2_000_000;
            
            // Binary Notation. Start with 0b_
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;

            // Hexadecimal Notation start with 0x_
            int hexadecimalNotation = 0x_001E_8480;


            // Check the three variables to see if they contain the same value;
            Console.WriteLine($"Variables\n  {nameof(hexadecimalNotation)}: {hexadecimalNotation}\n" +
                $"  {nameof(binaryNotation)}: {binaryNotation}\n" +
                $"  {nameof(hexadecimalNotation)}: {hexadecimalNotation}\nThe Same?:" +
                $"{hexadecimalNotation == binaryNotation && binaryNotation == decimalNotation}");

            // Spacing.
            Console.WriteLine("");

            // Sizeof allows to see how much bits a variable is taking up.
            //Also some types have min.Value and Max.Value which can be use to see the smallest and largest amount it can store.
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range  {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range  {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");


            // Spacing.
            Console.WriteLine("");

            // Comparing Double and Decimal types.
            Console.WriteLine("Using Doubles");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals  {0.3}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal {0.3}");
            }

            // Spacing.
            Console.WriteLine("");


            Console.WriteLine("Using decimals:");
            // M is placed at end of number to make decimal .
            // M suffix means a decimal literal value.
            decimal c = 0.1M;
            decimal d = 0.2M;

            if(c + d == 0.3M)
            {
                Console.WriteLine($"{a} + {b} is equal to {0.3M}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal {0.3M}");
            }

            // Booleans
            // Booleans can only store two values True or False.
            bool trueValue = true;
            bool falseValue = false;

            if(trueValue)
            {
                Console.WriteLine("IF the trueValue contains true it makes it true");
            }

            if(!falseValue)
            {
                Console.WriteLine("If the falseValue is not true we are false");
            }



        }
        private static char GetSomeKeystroke()
        {
            Console.WriteLine("Enter Character.. When Done hit enter");
            String character = Console.ReadLine();

            // Spacing
            Console.WriteLine("");

            if (character != null && character.Length == 1)
            {
                return character[0];
            }
            Console.WriteLine("Invalid input");

            return GetSomeKeystroke();
        }
    }
}