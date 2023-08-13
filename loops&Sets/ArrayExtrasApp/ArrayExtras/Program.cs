
string userInput;
int fruitNumbers;
List<string> fruits = new List<string>();
List<int> amount = new List<int>();

Console.WriteLine("Welcome to your fruit list!");
Console.WriteLine("To start with, please enter the fruits you like. Once you have entered all the fruits you like, type 'exit'.");

while (true)
{
    Console.Write("Enter fruits. Type 'exit' to finish: ");
    userInput = Console.ReadLine();

    if (userInput == null || userInput.ToLower() == "exit")
    {
        break;
    }

    fruits.Add(userInput);
}

Console.WriteLine("Now we'll add the amount of each fruit you have.");
Console.WriteLine("Add the number of fruits you have below. ");

foreach (string fruit in fruits)
{
    while (true)
    {
        Console.Write($"Enter a number for '{fruit}': ");
        if (int.TryParse(Console.ReadLine(), out fruitNumbers))
        {
            amount.Add(fruitNumbers);
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
    }
}

Console.WriteLine("Fruits & fruit amount: ");
for (int i = 0; i < fruits.Count; i++)
{
    Console.WriteLine($"{fruits[i]} - {amount[i]}");
}

