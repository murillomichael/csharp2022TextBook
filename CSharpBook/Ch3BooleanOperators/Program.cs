namespace Ch3BooleanOperators
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine($"AND |a        |b");
            WriteLine($"a | {a & a ,- 5 } | {a & b, -5}");
            WriteLine($"b | {b & a,-5}  | {b & b,-5} ");
            WriteLine();

            WriteLine($"OR | a  | b  ");
            WriteLine($"a | {a | a,-5} | {a | b,-5}");
            WriteLine($"b | {b | a,-5} | {b | b,-5}");

            WriteLine();
            WriteLine($"XOR |a  |b  ");
            WriteLine($"a  | {a ^ a,-5} | {a ^ b,-5}");
            WriteLine($"a  |  {b ^ a,-5}  |{b^b,-5}");

            // Spacing
            WriteLine();

            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");

            WriteLine();
            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");



        }

        static bool DoStuff()
        {
            Console.WriteLine("I am doing some stuff");
            return true;
        }
    }
}