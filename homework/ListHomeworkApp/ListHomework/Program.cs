

string inputStudentNames, inputConfirmExit;
bool isValidInput = false;

List<string> studentRoster = new List<string>();

Console.WriteLine("Welcome to the Class Roster Program!");
Console.WriteLine("Please enter the student names who will be in the class.");
Console.WriteLine("Once all names have been entered, type 'exit' or 0 to finalise the roster.");
Console.WriteLine();

while (!isValidInput)
{
    Console.Write("Student name: ");
    inputStudentNames = Console.ReadLine();

    if (inputStudentNames.ToLower() == "exit" || inputStudentNames == "0")
    {
        Console.Write("Are you sure you wish to exit? (y/n) ");
        inputConfirmExit = Console.ReadLine();

        if(inputConfirmExit.ToLower() == "y")
        {
            break;
        }
    }
    else
    {
        studentRoster.Add(inputStudentNames);

    }

}

Console.WriteLine();
Console.WriteLine("---- Student Roster ----");
Console.WriteLine($"Student Count: {studentRoster.Count}");

for (int i = 0; i < studentRoster.Count; i++)
{
    Console.WriteLine($"-{studentRoster[i]}");
}

