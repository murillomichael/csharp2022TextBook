using System.Runtime.CompilerServices;

namespace SelectionStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string password = "ninja";

            if (password.Length < 8)
            {
                WriteLine("Your password is to short. Use at least 8 characters");
            }
            else
            {
                WriteLine("Your password is strong.");
            }

            // Spacing.
            WriteLine();

            // Since theres only one line within the statements scope we don't need the {}
            if (password.Length < 8)
                WriteLine("Your password is too short. Use at least 8 characters.");
            else
                WriteLine("Your password is strong.");
            // Should be avoided. ^^ can introduce skipping statement bug.

            // Spacing
            WriteLine();

            // String object.
            object o = "3";

            // Int object.
            object z = 3;

            // Initiating a integer.
            int j = 4;

            // Should not work since object is string.
            AttemptToMultplyInts(o, j);

            // Spacing 
            WriteLine();

            // This should work since object is int.

            AttemptToMultplyInts(z, j);

            // Spacing.
            WriteLine();

            int number = Random.Shared.Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break; // jumps to end of switch statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3: // multiple case section
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            } // end of switch statement
            WriteLine("After end of switch");
        A_label:
            WriteLine($"After A_label");

            // Spacing.
            WriteLine();

            // Using switch statement to check object type and also patterns within types.l
            Animals?[] animals = new Animals?[]
            {
                new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23),
                legs = 4, IsDomestic= true },
                null,

                new Cat {Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12)},

                new Spider {Name = "Sid Vicious", Born= DateTime.Today, IsPoisonous=true},
                new Spider {Name = "Captain Furry", Born = DateTime.Today }

            };

            foreach ( Animals? animals1 in animals)
            {
                string message;

                switch (animals1)
                {
                    case Cat fourLeggedCat when fourLeggedCat.legs == 4:
                        message = $"The cat named {fourLeggedCat.Name} has four legs";
                        break;
                    case Cat wildCat when wildCat.IsDomestic == false:
                        message = $"This non-domestic cat is named {wildCat.Name}";
                        break;
                    case Cat cat:
                        message = $"This cat is named {cat.Name}";
                        break;
                    default: //default keyword is always evaluted last.
                        message = $"The animal named {animals1.Name} is a {animals1.GetType().Name}.";
                        break;
                    case Spider spider when spider.IsPoisonous:
                        message = $"The {spider.Name} spider is poisonous. RUN!";
                        break;
                    case null:
                        message = "Animal is null" ;
                        break;
                }
                WriteLine($"Switch statement: {message}");

                // Spacing.
                WriteLine();

                message = animals1 switch
                {
                    Cat fourLeggedCat when fourLeggedCat.legs == 4
                        => $"The cat {fourLeggedCat.Name} has four legs.",
                    Cat wildCat when !wildCat.IsDomestic
                        => $"The non-domestic cat is named {wildCat.Name}.",
                    Cat cat
                        => $"The cat is named {cat.Name}.",
                    Spider spider when spider.IsPoisonous
                        => $"The {spider.Name} spider is poisonous. Run!",
                    null
                        => "The animal is null.",
                    _
                        => $"The animal named {((dynamic)animals1).Name} is a {animals1.GetType().Name}."
                };
                Console.WriteLine($"switch expression: {message}");

            }





        }

            private static void AttemptToMultplyInts(object obj, int j)
        {
            // Here instead of calling the object we check if we can store it in a int variable.
            // If its a int it will be successful boolean expression.
            if (obj is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("Parameter is not a integer so it cannot be multiply");
            }
        }
    }
}