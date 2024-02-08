using System.Collections;

namespace IterationStatements_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Basic while loop until number is 10  or greater.
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            // Spacing 
            WriteLine();

            // Basic while loop until number is 10  or greater.
            x = 0;
            while (x < 10)
            {
                Console.WriteLine(x++);
            }

            // Spacing 
            WriteLine();

            // Do while statement checks the boolean expression at end meaning it will always run once.
            string? password;
            int tries = 0;
            do
            {
                if(tries == 10)
                {
                    Console.WriteLine("To many tries");
                    break;
                }
                Write("Enter your password: ");
                password = Console.ReadLine();
                tries++;
            }
            while (password != "password" && tries != 11);

            if(tries != 10)
            {
                WriteLine("Correct!");
            }

            // Spacing 
            WriteLine();

            // For loop is made with 3 optional expressions
            // 1. Initializer eg. int i = 0;
            // 2. Conditional eg. i < 10
            // 3. Iterator eg. i++;
            
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Spacing 
            WriteLine();

            // For each loop 
            // Performs a block of statements on each item with in the sequence.
            // Usually only in read-only format.
            // Example would be like a array or collection.
            string[] names = { "Judith", "Max", "Michael", "Ethan","Mom","Dad" };

            foreach(string name in names) 
            {
                WriteLine($"{name} has {name.Length} characters");
            }

            // Spacing 
            WriteLine();

            IEnumerator e = names.GetEnumerator();

            while (e.MoveNext()) 
            {
                string name = (string)e.Current;
                WriteLine($"{name} has {name.Length} characters.");
            }

            // Spacing 
            WriteLine();

        }
    }
}
