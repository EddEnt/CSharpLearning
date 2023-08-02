

string? userAgeText;
int userAge;
bool userAgeValid;

Console.Write("Please enter your age: ");
userAgeText = Console.ReadLine();

userAgeValid = int.TryParse(userAgeText, out userAge);
Console.WriteLine(userAge);
Console.WriteLine($"You will be {userAge + 25} in 25 years time.");
Console.WriteLine($"25 years ago, you were {userAge - 25}.");

