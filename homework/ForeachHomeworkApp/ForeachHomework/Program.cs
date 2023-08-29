

string inputFirstName;
bool inputFinished = false;
List<string> firstNames = new();

Console.WriteLine("--- Foreach Loops ---");
Console.WriteLine("Please enter first names. Once done, type 'exit'.");

while (!inputFinished)
{
    Console.Write("First Name: ");
    inputFirstName = Console.ReadLine();

    if (inputFirstName.ToLower() == "exit")
    {
        break;
    }

    firstNames.Add(inputFirstName);

}

foreach (string firstName in firstNames)
{
    Console.WriteLine($"Hello, {firstName}");
}

