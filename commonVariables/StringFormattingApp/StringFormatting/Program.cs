

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

//Console.WriteLine("Hello " World "!");
//Instead...
Console.WriteLine("Hello \"World\"!");

//Displaying a file path?
//Console.WriteLine("c:\source\repos");
//Will not work, forward slash '\' is reserved error CS1009: Unrecognized escape sequence

//The problem is the sequence \s. The \r doesn't produce an error because it's a valid escape sequence for a carriage return.
//However, you don't want to use a carriage return in this context.
//To solve this problem, you use the \\ to display a single backslash.
Console.WriteLine("c:\\source\\repos");

//Formatting Output with character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//Verbatim string literal
//Use the @ symbol before the literal string
//Will preserve any whitespace
Console.WriteLine(@"    Hello    ,    World!");
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes by default)");
Console.WriteLine(@"c:\invoices");

//Unicode escape characters
//Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
//こんにちは World! Output on .NET Editor https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/2-exercise-character-escape-sequences


