

Console.Write("What is your first name?: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name?: ");
string lastName = Console.ReadLine();

if (firstName.ToLower() == "edward" && lastName.ToLower() == "entecott")
{
    Console.WriteLine("Hey doc!");
}
if (firstName.ToLower() == "edward" || lastName.ToLower() == "entecott")
{
    Console.WriteLine("At least one name is correct!");
}
else
{
    Console.WriteLine("...");
}

    //if (firstName.ToLower() == "edward" && lastName.ToLower() == "entecott")
    //{
    //    Console.WriteLine("Hello primary user!");
    //}
    //if (firstName.ToLower() == "edward")
    //{
    //    Console.WriteLine("Hello, nice name!");
    //}
    //if (lastName.ToLower() == "entecott")
    //{
    //    Console.WriteLine("Hello, nice last name!");
    //}
    //else
    //{
    //    Console.WriteLine("Wrong name, apologies :(");
    //}

    //==, ===, >, >=, <, <=, !=
    int age = 0;

if (age >= 100)
{
    Console.WriteLine("You are really old!");
}
if (age < 100)
{
    Console.WriteLine("You are not that old!");
}
if (age >= 40 && age <= 50)
{
    Console.WriteLine("You are in your 40's!");
}
if (age != 40)
{
    Console.WriteLine("You are not a prime age!");
}

