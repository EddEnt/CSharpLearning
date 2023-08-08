

string? username;

Console.Write("What is your name?: ");
username = Console.ReadLine();

switch (username.ToLower())
{
    case "edward":
        Console.WriteLine("Hello, Edward. Welcome back to your training. ");
        break;
    case "tim":
        Console.WriteLine("Hello, Professor. Welcome back.");
        break;
    case "":
        Console.WriteLine("Empty entry. Please try again");
        break;
    default:
        Console.WriteLine("Hello, Student. Welcome back to your training.");
        break;
}

