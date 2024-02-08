// Defines must be down on the top of the class.
#define MYSYMBOL
using System.Runtime.CompilerServices;

namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"There are {args.Length} arguments");

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            if (args.Length < 3)
            {
                WriteLine("You must specify two colors and cursor size, e.g.");
                WriteLine("dotnet run red yellow 50");
                return; // stop running
            }

            // Sets our 0 argument to red for the text.
            ForegroundColor = (ConsoleColor)Enum.Parse(
             enumType: typeof(ConsoleColor),
             value: args[0],
             ignoreCase: true);

            // Sets our background color to our first argument which is yellow.
            BackgroundColor = (ConsoleColor)Enum.Parse(
             enumType: typeof(ConsoleColor),
             value: args[1],
             ignoreCase: true);

            try
            {
                //  Grabs our 3rd argument which is 50.
                CursorSize = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException)
            {
                // If this code was ran on macOS we would see out exception.
                WriteLine("The current platform does not support changing the size of the cursor.");
            }

            // Ways to avoid this would be using OperatingSystem class in the System namespace, as shown in the following code.
            if (OperatingSystem.IsWindows())
            {
                WriteLine("This is Windows");
            }
            else if (OperatingSystem.IsWindowsVersionAtLeast(10))
            {
                WriteLine("This windows version is at least 10");
            }
            else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
            {
                WriteLine("execute code that only works on IOS 14.5 or later");
            }
            else if (OperatingSystem.IsBrowser())
            {
                WriteLine("execute code that only works in the browser with Blazer");
            }

            // Another way to handle  different platforms is using conditional compilation.
            // There are 4 predefined preprocessor directives .
            // #if, #elif, #else, and #endif

            // You can also define your own
            // #define MYSYMBOL -> must be done on top of class view line 2.

            #if NET7_0_OR_ANDRIOD
                    // Here statements only for ANDRIOD will run.
            #elif NET7_0_IOS
                  // Here only code for IOS will run
            #else
                        // Code statements for all other platforms will work here.
            #endif 
                        //ends the control conditional compilation

            

        }
    }
}