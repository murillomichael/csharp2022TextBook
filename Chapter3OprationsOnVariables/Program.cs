namespace Chapter3OprationsOnVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Examples of binary operators.
            // Means to operands are being used.
            int x = 5;
            int y = 3;
            int resultOfAdding = x + y;
            int resultOfMultiplying = x * y;

            // Examples of unary operators.
            // Meaning they work with one single operands.
            // Can be applyed before or after.
            int z = 5;
            int postfixIncrement = z++;
            int prefixIncrement = ++z;
            Type theTypeofAnInteger= typeof(int);
            string nameOfVariable = nameof(z);
            int howManyBytesInAnInteger = sizeof(int);

            // Examples of ternary operators
            // MEaning they work with three operands.
            int finalTotal = x + y + z;

            ///
            /// Exploring unary  arithmetic operators
            ///

            int a = 3;
            int b = a++; // Will still show has 3 because ++ or -- in front means it executes increment or decrement after assigning.

            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c; // Will be 4 because when you put operator ++ or -- it executes before assigning our variable.

            WriteLine($"c is {c}, d is {d}");

            // ++ and -- is the same as a = a + 1; and a = a - 1;


            // Spacing 
            WriteLine();

            ///
            /// Exploring binary  arithmetic operators
            ///

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            // Spacing
            Console.WriteLine();

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");

            // Spacing
            Console.WriteLine();

            // Assignment operators
            // Most populour is =

            int p = 6;
            p += 3; // equivalent to p = p + 3;
            p -= 3; // equivalent to p = p - 3;
            p *= 3; // equivalent to p = p * 3;
            p /= 3; // equivalent to p = p / 3;



        }
    }
}