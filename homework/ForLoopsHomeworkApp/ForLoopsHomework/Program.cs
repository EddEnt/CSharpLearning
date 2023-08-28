

string inputFirstNames;

List<string> firstNames = new();

Console.WriteLine("--- First Names List ---");
Console.WriteLine("Please enter first names into a List seperated by commas. " +
                  "Do not add any spaces around the commas");

inputFirstNames = Console.ReadLine();
firstNames = inputFirstNames.Split(',').ToList();
for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello, {firstNames[i]}");
}


