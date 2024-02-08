using System.Windows.Markup;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Can reference  any size array of strings.
            string[] names;

            // Allocating memory for four strings in an array.
            names = new string[4];

            // Storing items with in the arrays index positions.
            names[0] = "Mom";
            names[1] = "Dad";
            names[2] = "Ethan";
            names[3] = "JudithMaxMichelle";

            // Looping through array of names using for loop.
            for (int i = 0; i < names.Length; i++)
            {
                // Output the item at the index position we are current iterating through.
                WriteLine(names[i]);

            }

            // Spacing
            WriteLine();

            // You can also use initializer syntax.
            string[] names2 = {"Mom","Dad","Michelle","Max","Judith","Ethan"};

            // Looping through array of names using for loop.
            for (int i = 0; i < names2.Length; i++)
            {
                // Output the item at the index position we are current iterating through.
                WriteLine(names2[i]);
            }

            // Spacing
            WriteLine();

            string[,] grid1 = // Two dimensions.
            {
                {"Alpha", "Beta", "Gamma", "Delta" },
                { "Anne", "Ben", "Charlie", "Doug" },
                {"Aardvark", "Bear", "Cat", "Dog" }
            };

            WriteLine($"Lower bound of the first dimensions is: {grid1.GetLowerBound(0)}");
            WriteLine($"Lower bound of the first dimensions is: {grid1.GetUpperBound(0)}");
            WriteLine($"Lower bound of the second dimensions is: {grid1.GetLowerBound(1)}");
            WriteLine($"Lower bound of the second dimensions is: {grid1.GetUpperBound(1)}");

            // Spacing
            WriteLine();

            for (int row = 0; row <= grid1.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= grid1.GetUpperBound(1); col++)
                {
                    WriteLine($"Row {row},  Column {col}: {grid1[row, col]}");
                }
            }

            // Spacing
            WriteLine();
            
            // If not able to use array initialization syntax.
            // Due to loading values from database or file.
            // You can declare array dimensions then allocate the memory.

            // Alternative syntax
            
            // Here I declare the dimensions.
            string[,] grid3 = new string[2,4];

            // Then we begin to assign our variables.
            grid3[0, 0] = "Alpha";
            grid3[0, 1] = "Beta";
            grid3[0, 2] = "Charlie";
            grid3[0, 3] = "Delta";
            grid3[1, 0] = "Alpha1";
            grid3[1, 1] = "Beta1";
            grid3[1, 2] = "Charlie1";
            grid3[1, 3] = "Delta1";

            // Spacing
            WriteLine();

            for (int row = 0; row <= grid3.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= grid3.GetUpperBound(1); col++)
                {
                    WriteLine($"Row {row},  Column {col}: {grid3[row, col]}");
                }
            }

            // Spacing
            WriteLine();

            // Jagged arrays of arrays.
            // Main used when you need many dimensions but different amount of items in each dimension.

            // Array of string arrays.
            string[][] jagged = new[]
            {
                new[] {"Aplha","Beta","Gamma" },
                new[] {"Anne","Ben","Charlie","Doug"},
                new[] {"Aardvank","Bear"}
            };

            WriteLine("Upper bound of array of arrays is: {0}",jagged.GetUpperBound(0));

            for(int array = 0; array <= jagged.GetUpperBound(0); array++)
            {
                WriteLine("Upper bound of array {0} is: {1}",
                    arg0: array,
                    arg1: jagged[array].GetUpperBound(0));
            }

            // Spacing
            WriteLine();

            for (int row = 0; row <= jagged.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
                {
                    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
                }
            }


            // Spacing
            WriteLine();

            int[] sequentialNumbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] oneTwoNumbers = new int[] { 1, 2 };
            int[] oneTwoTenNumbers = new int[] { 1, 2, 10 };
            int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 10 };
            int[] primaryNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] fibonaciiNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] emptyNumbers = new int[] { };
            int[] threeNumbers = new int[] { 9, 7, 5 };
            int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10 };

            WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
            WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
            WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
            WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
            WriteLine($"{nameof(primaryNumbers)}: {CheckSwitch(primaryNumbers)}");
            WriteLine($"{nameof(fibonaciiNumbers)}: {CheckSwitch(fibonaciiNumbers)}");
            WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
            WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
            WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");
        }

        public static string CheckSwitch(int[] values) => values switch
        {
            [] => "Empty array",
            [1, 2, _, 10] => "Contains 1, 2, any single number, 10",
            [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10",
            [1, 2] => "Contains 1 then 2",
            [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
            [0, _] => "Starts with 0, then one other number.",
            [0, ..] => "Starts with 0, then any range of numbers.",
            [2, .. int[] others] => $"Start with 2n then {others.Length} more numbers.",
            [..] => "Any items in any order.",
        };
    }
}