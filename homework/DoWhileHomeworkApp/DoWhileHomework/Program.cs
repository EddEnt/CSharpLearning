

string username;
bool programExitCommand = false;

do
{
    Console.Write("Enter your name. To quit out of the program, type 'exit': ");
    username = Console.ReadLine();

    if (username.ToLower() == "tim")
    {
        Console.WriteLine($"Hello Professor {username}");

    }

    if (username.ToLower() != "tim" && username.ToLower() != "exit")
    {
        Console.WriteLine("Hello, Student.");
    }

    if (username.ToLower() == "exit")
    {
        //Environment.Exit(0); 
        Console.WriteLine("Exiting...");
        programExitCommand = true;
    }


} while (programExitCommand == false);

