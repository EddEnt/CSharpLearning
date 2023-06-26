

string firstName = string.Empty; //Industry standard for a string, initialises an empty string, "" is similar, but is a string without any content inside
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Edward"; //Assigning a value to the string
lastName = "Entecott";
//filePath = "C:\Temp\Demo"; //Wont work like this, \ are for escape characters
//filePath = "C:\\Temp\\Demo"; //A second \ will add a \ to the string, will look like one \ when printed
filePath = @"C:\Temp\Demo"; //@ is a string literal character, great to use when not using any escape characters like \n <-(new line)

//Console.WriteLine(firstName); //Using a string
//Console.WriteLine(firstName + " " + lastName ); //Appending strings
//Console.WriteLine($"{firstName} {lastName}"); //String interpolation, treat whatever is in the curly braces as C# code
Console.WriteLine($"Hello {firstName} {lastName}"); //String interpolation, treat whatever is in the curly braces as C# code
Console.WriteLine(filePath);



