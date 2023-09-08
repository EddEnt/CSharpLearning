

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

//Concatenating
string firstName = "Edward";
string greeting = "Hello";
string message = greeting + ", " + firstName + "!";
Console.WriteLine(message);

//Storing the message into an intermediate variable is not best practice
//Instead, far better to concatenate in a WriteLine
Console.WriteLine(greeting + ", " + firstName + "!");

//String interpolation
Console.WriteLine($"{greeting}, {firstName}!");

int versionNumber = 11;
string updateText = "Update to Windows";
string message2 = $"{updateText} {versionNumber}";
Console.WriteLine(message2);

//Avoiding intermediate variables
Console.WriteLine($"{updateText} {versionNumber}!");

//String formatting challenge
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(@"View English output:
    c:\Exercise\" + projectName + "\\data.txt");
Console.WriteLine(russianMessage + @":
    c:\Exercise\" + projectName + "\\ru-RU\\data.txt");

/* 
Output from .NET Editor

View English output:
    c:\Exercise\ACME\data.txt
Посмотреть русский вывод:
    c:\Exercise\ACME\ru-RU\data.txt
 */

