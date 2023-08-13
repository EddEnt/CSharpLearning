

string[] names = new string[3];
string inputUserNumber;
int userNumber;

names[0] = "John Doe";
names[1] = "Jane Doe";
names[2] = "Smithy Smith";

int index = 0;
bool isValidInput = false;

while (!isValidInput) //!isValidInput means "as long as the input is not valid", will keep looping until it becomes True
{
    Console.Write("Enter a number between 1 and 3: ");
    isValidInput = int.TryParse(Console.ReadLine(), out index);

    if (!isValidInput || index < 1 || index > 3)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        isValidInput = false; // Continue the loop
    }
}

string selectedName = names[index - 1];
//Console.WriteLine($"The name at index {index} is: {selectedName}");
Console.WriteLine($"You have selected {selectedName}, which is found at position {index - 1} in our array.");


