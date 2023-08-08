

string firstName = "Edward";
int age = 43;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("Child account detected.");
        break;
    case >= 18 and < 65:
        Console.WriteLine("Regular account detected");
        break;
    case >= 65:
        Console.WriteLine("Senior account detected");
        break;
    default:
        Console.WriteLine("Age was not in expected range!");
        break;
}

//switch (firstName.ToLower())
//{
//    //case "sue": If no code with a break, will fall through to the next case
//    case "edward" or "sue":
//        Console.WriteLine("Hello User");
//        break;
//    case "tom":
//        Console.WriteLine("Oh, it's you...");
//        break;
//    default:
//        Console.WriteLine("Unknown User...");
//        break;
//}

