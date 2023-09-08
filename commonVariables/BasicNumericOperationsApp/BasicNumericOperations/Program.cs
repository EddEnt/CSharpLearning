
//Addition
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//Mixing data stypes to force implicit type conversions
string firstName = "Edward";
int unitsSold = 7;
Console.WriteLine($"{firstName} sold {unitsSold} units last week.");

//Attempting Addition and Concatenation
Console.WriteLine(firstName + " sold " + unitsSold + 7 + " units last week.");
//Does not work. Compiler treats everything as a concatenation 

//Parentheses to perform addition
Console.WriteLine(firstName + " sold " + (unitsSold + 7) + " units last week.");
//Parentheses becomes another overloaded operator. Parentheses form the "order of operations" operator.
//Parentheses is calculated first, then concatenated
//Avoid in practical code! Point is to help with understanding operators and operands as the compiler does

