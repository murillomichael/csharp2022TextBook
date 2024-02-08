namespace BitwiseAndShiftOperators_to_the_Chapter03workspace
{
    public  class Program
    {
        public static void Main(string[] args)
        {

            // bitwise.


            int a = 10; // 00001010 binary number.
            int b = 6; // 00000110 binary number.

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a & b = {a & b}"); // 2 bit column only e.g 00000010
            Console.WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns e.g. 00001100
            Console.WriteLine($"a | b = {a | b}"); // 8, 4, 2-bit columns e.g. 00001110

            // Spacing
            WriteLine();

            // binary shift
            // 01010000 Left-shift a by three columns.
            Console.WriteLine($"a << 3 = {a << 3}");

            // multiply by 8.
            Console.WriteLine($"a * 8 = {a * 8}");

            // 00000011 RIGHT-SHIFT B BY ONE bit column.
            WriteLine($"b >> 1 = {b >> 1}");

            // Spacing.
            WriteLine();

            Console.WriteLine("Outputting integers as binary");
            Console.WriteLine($"a =     {ToBinaryString(a)}");
            Console.WriteLine($"b =     {ToBinaryString(b)}");

            // Bitwise operations.
            Console.WriteLine($"a & b = {ToBinaryString(a & b)}");
            Console.WriteLine($"a | b = {ToBinaryString(a | b)}");
            WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");


            // Spacing.
            WriteLine();

            ///////////////////////////////
            /// Miscellaneous Operators///
            /////////////////////////////

            int age = 50;
            WriteLine($"The {nameof(age)} variable uses {sizeof(int)} bytes of memory.");

            // How many operators in the following statement?
            char firstDigit = age.ToString()[0];
            // There are four operators:
            // = is the assignment operator
            // . is the member access operator
            // () is the invocation operator
            // [] is the indexer access operator

        }

        /// <summary>
        ///  Returns a value in string bianry form.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>binary value</returns>
        private static string ToBinaryString(int value)
        {
            return Convert.ToString(value, toBase: 2).PadLeft(8,'0');
        }
    }
}