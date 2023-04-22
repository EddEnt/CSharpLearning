internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, from the Main Program!");

        //A type defines the structure and behavior of any data in C#
        //A variable is a label that refers to an instance of a specific type
        //Two types in C#: Value Types and Reference Types
        //Variables of Value type directly contain their data. Variables each have their own copy of the data,
        //and it is not possible for operations on one to affect the other, except for ref and out parameter variables
        //Variables of Reference type store references to their data, latter being know as objects. It is possible for two variables to reference the same object,
        //and for operations on one variable to affect the object referenced by the other variable.

        //An identifier is a variable name. It is a unique series of unicode characters without any whitespace. Variables may be a C# reserved word if it is prefixed by the -> @ <- symbol
        //This could be useful when interacting with other languages.

        //C#'s value types are further divided into simple types, enum types, struct types, nullable value types, and tuple value types.

        //Value Types
        //Simple Types

            //Signed Integral
            sbyte num1;
            short num2;
            int num3;
            long num4;

            //Unsigned Integral
            byte num5;
            ushort num6;
            uint num7;
            ulong num8;

            //Unicode Characters
            char num9;

            //IEEE binary floating-point
            float num10;
            double num11;

            //High-precision decimal floating-point
            //Appropriate when the required degree of precision is determined by the number of digits to the right of the decimal point (Financial Applications, currency amounts)
            //Even numbers that are precise to only one decimal digit are handled more accurately by the decimal
            //More information here: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            //                       https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-7.0
            decimal num12;

            //Boolean
            //True or False, 1 or 0
            bool num13;

        //Enum types

            //User-defined types of the form enum E {...}


        //C#'s reference types are further divided into class types, interface types, array types, and delegate types.
    }
}