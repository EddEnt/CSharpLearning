
string? ageText;
//int? age;
int age;
bool isValidInt;

//Converting Strings
Console.Write("What is your age: ");
ageText = Console.ReadLine();

//Console.WriteLine(ageText + 15); Won't work

//age = int.Parse(ageText); //Can only work with numbers, unhandled exception will ocour with non text represented numbers
isValidInt = int.TryParse(ageText, out age); //out variable cannot be used with potential null entry, "int? age"
Console.WriteLine($"This was a valid number: {isValidInt}. The number entered was {age}.");
//Usually done with an if statement, have not reached that yet in course work

Console.WriteLine(age);
Console.WriteLine(age + 15);

double testDouble = age;
//decimal testDecimal = testDouble; Cannont convert from one precise type to another, lose out on precision for the variable type.
                                    //Must instead cast the variable
decimal castDecimal = (decimal)testDouble; //Casting example
                                           //Casting from a small number to a large number is possible, casting from a class to an interface or another class
                                           //If information may potentially be lost, must cast the variable (decimal to double, base-class to derived class)
                                           //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

