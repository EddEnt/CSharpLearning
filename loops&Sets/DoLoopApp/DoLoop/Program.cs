
bool isValidAge;
int age;

do
{
    Console.WriteLine("If you do not wish to enter your age, type 'exit' to quit...");
    Console.Write("What is your age?: ");
    string ageText = Console.ReadLine();

	isValidAge = int.TryParse(ageText, out age);

    if (ageText.ToLower() == "exit")
    {
        Environment.Exit(0);
    }
    if (isValidAge == false)
	{
		Console.WriteLine("Invalid age!");
	}



} while (isValidAge == false);

do
{
    //Will run the code at least once!
} while (true);

while (true)
{
    //Will run the code zero or more times!
}

