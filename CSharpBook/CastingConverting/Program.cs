using static System.Convert;

namespace CastingConverting
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            double b = a; // An int can be safely cast into a double.
            WriteLine(b);

            //Spacing.
            WriteLine();

            double c = 9.8;
            // int d = c; // Complier gives an error for this line.
            int d = (int)c; 
            WriteLine(d); // Data will be lost losing the .8 .

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            f = (int)e;

            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;

            WriteLine($"e is {e:N0} and f is {f:N0}");

            //Spacing.
            WriteLine();

            double g = 9.8;
            int h = ToInt32(g); // Will round up.
            WriteLine($"g is {g} and h is {h}");  // Casting trims the number but converting rounds the number.

            // Spacing.
            WriteLine();

            double[] doubles = { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach ( double n in doubles)
            {
                WriteLine($"ToInt32({n}) is {ToInt32(n)}");
            }

            // Spacing.
            WriteLine();

            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.UtcNow;
            WriteLine(now.ToString());
            object me = new();
            WriteLine(me.ToString());

            // Spacing.
            WriteLine();

            // Allocate array of 128 bytes.
            byte[] binaryObject = new byte[128];

            // Populate array with random bytes.
            Random.Shared.NextBytes( binaryObject );

            WriteLine("Binary Object as bytes:");
            for(int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X} ");
            }

            // Spacing.
            WriteLine();

            // Convert to base64 string and output as text.
            string encoded = ToBase64String( binaryObject );
            WriteLine($"Binary Object as Base64: {encoded}");

            // Parsing from strings to numbers or dates and times.

            // spacing.     
            WriteLine();

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}."); // Gets date and time.
            WriteLine($"My birthday is {birthday:D}."); // Gets date only.
            
            // Spacing.
            WriteLine();

            Write("How many eggs are there?");
            string? input = ReadLine();

            if(int.TryParse(input, out int count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("Was not able to parse input.");
            }

            // Spacing.
            WriteLine();

        }
    }
}