

//Mini-Project - Student Check App

//Attempt 1 is done with Convert.ToInt32, but no Try Catch for exception checking
//Attempt 2 uses a TryParse to check for valid age

Console.WriteLine("Welcome to the student checker app!");

//string firstName;
//int? userAge, yearsToWait;

//Console.Write("Please enter your first name: ");
//firstName = Console.ReadLine();
//Console.Write("Please enter your age: ");
//userAge = Convert.ToInt32(Console.ReadLine());

//Attempt 1
//if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
//{
//    Console.WriteLine($"Good morning, Professor {firstName}.");
//}
//else
//{
//    Console.WriteLine($"Good morning, {firstName}");
//}

//if (userAge < 21)
//{
//    yearsToWait = 21 - userAge;
//    Console.WriteLine($"You must wait {yearsToWait} more years before you may start this class.");
//}
//else
//{
//    Console.WriteLine("The lesson will start soon...");
//}

//Attempt 2

string firstName, formattedName, userAge;

Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Please enter your age: ");
userAge = Console.ReadLine();

if (int.TryParse(userAge, out int age) == false)
{
    Console.WriteLine("You did not provide a valid age. You must enter a number. The program will now end.");
    return;
}

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}

if (age < 21)
{
    Console.WriteLine($"Apologies {formattedName}, you must wait {21 - age} more years before you may start this class. ");
}
else
{
    Console.WriteLine($"Good morning, {formattedName}, the lesson will start soon...");
}


