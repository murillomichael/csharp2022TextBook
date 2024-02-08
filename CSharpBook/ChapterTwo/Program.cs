using System.Xml;

namespace ChapterTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // object types can store any type but can cause poor performance or take up to much memory.
            // Storing double in an object.
            object height = 1.88;
            // Storing string in an object.
            object name = "Michael";
            Console.WriteLine($"{name} is {height} metres tall.");

            // Spacing.
            Console.WriteLine("");


            // Attempt to grab name --> gives a complier error.
            // int length1 = name.Length; 

            // Attempt to grab name --> tell compiler it is a string.
            int length2 = ((string)name).Length;

            Console.WriteLine($"{name} has {length2} characters. ");

            ///
            /// As you can see Objects Need a cast AKA (datatype)objectName
            /// Generics do not need cast because they are told at new instance the type
            ///Dynamics do not need cast also
            ///
            
            // Spacing.
            Console.WriteLine("");

            // Storing a string in a dynamic object.
            // String has a Length property.
            dynamic something = "Michael";

            // int does not have a length property will cause complier error.
             dynamic something2 = 12;
            // An array of any type has a Length property
             dynamic something3 = new[] {3,5,7};
            //this compiles but would throw an exception at runtime
            // if you  Later stored a data type that does not have a property named Length.
            Console.WriteLine( $"Length is {something.Length}");

            //Console.WriteLine($"Length is {something2.Length}"); --> error because method does not exist.

            Console.WriteLine($"Length is {something3.Length}");

            // Specifying the type of variables.
            int population = 67_000_000; // 67 million in UK
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false

            // You can now infer varibles types by using var.

            // With var a literal number is seen as int unless you add
            //  L: Compiler infers long
            // UL: Compiler infers ulong
            // M: Compiler infers decimal
            // D: Compiler infers double
            // F: Compiler infers float

            // Hover mouse to see the type
            var populationInfer = 67_000_000; // 67 million in UK
            var weightInfer2 = 1D; // in kilograms
            var weightInfer3 = 1.88F; // Float
            var weightInfer4 = 1.88D; // Decimal
            var weightInfer5 = 1L;  // Long
            var weightInfer6 = 1UL; // uLong
            var priceInfer = 4.99M; // in pounds sterling
            var fruitInfer = "Apples"; // strings use double-quotes
            var letterInfer = 'Z'; // chars use single-quotes
            var happyInfer = true; // Booleans have value of true or false

            // Importing using System.Xml;

            // Good use of var because it avoids the repeated type.
            // As shown in the more verbose second statement.
            var xml1 = new XmlDocument(); // C#3 and later.
            XmlDocument xml2 = new XmlDocument(); // All C# versions.

            // Bad use of var because we cannot tell the type
            // So we should use a specific type declaration as shown in the second statement.
            var file1 = File.CreateText("Michael.txt"); // would be better if variable mention what it was.
            StreamWriter file2 = File.CreateText("Michael2.txt");

            // If in doubt, spell it out!

            // Using target-typed new to instantiate objects.
            // C#9 you can use new(); instead of renaming object.

            XmlDocument xml3 = new();

            Person person = new(); // Instead of Person person = new Person();
            person.birthDate = new(1998, 01, 21);

            // New can be useful for arrays and collections.
            // Since they can have many objects.
            List<Person> list = new List<Person>()
            {
                new() {FirstName = "Michael"},
                new() {FirstName = "MAx" },
                new() {FirstName = "Judith"}
            };

            // String is reference type .
            // Most primitive types are value types.
            // Reference stores address to value and is defaulted as null.
            // Value types stores the value.

            // Default values.
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

            Console.WriteLine("");

            // Setting then defaulting value.
            // Set number.
            int number = 13;
            Console.WriteLine($"number has been set to: {number}");
            // Set back to default.
            number = default;
            Console.WriteLine($"Number has been set to = {number}");









        }

    }
}