

//bool isComplete = false;

//if (isComplete)
//{
//    Console.WriteLine("The statement was true");
//}
//else
//{
//    Console.WriteLine("The statement was false");
//}

string? firstName;

Console.Write("What is your first name?: "); ;
firstName = Console.ReadLine();

if (firstName.ToLower() == "edward")
{
    Console.WriteLine("Hello primary user!");
}
else
{
    Console.WriteLine($"Hello other user, {firstName}!");
}

Console.WriteLine("Program ending...");
