using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Section2._3Pratice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* create a console app project named Ch02Ex03Numbers that
            outputs the number of bytes in memory that each of the following number types uses and the minimum
            and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float,
            double, and decimal */
            Console.WriteLine($"sbyte has a minimum {sbyte.MinValue} and maximum of {sbyte.MaxValue} ");
            Console.WriteLine($"byte has a minimum {byte.MinValue} and maximum of {byte.MaxValue} ");
            Console.WriteLine($"ushort has a minimum {ushort.MinValue} and maximum of {ushort.MaxValue} ");
            Console.WriteLine($"short has a minimum {short.MinValue} and maximum of {short.MaxValue} ");
            Console.WriteLine($"int has a minimum {int.MinValue} and maximum of {int.MaxValue} ");
            Console.WriteLine($"uint has a minimum {uint.MinValue} and maximum of {uint.MaxValue} ");
            Console.WriteLine($"ulong has a minimum {ulong.MinValue} and maximum of {ulong.MaxValue} ");
            Console.WriteLine($"long has a minimum {long.MinValue} and maximum of {long.MaxValue} ");
            Console.WriteLine($"float has a minimum {float.MinValue} and maximum of {float.MaxValue} ");
            Console.WriteLine($"double has a minimum {double.MinValue} and maximum of {double.MaxValue} ");
            Console.WriteLine($"decimal has a minimum {decimal.MinValue} and maximum of {decimal.MaxValue} ");

            Console.ReadLine();

        }
    }
}