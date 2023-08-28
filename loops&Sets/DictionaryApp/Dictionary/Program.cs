
//Very useful for specific applications, may not be used for everything 

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");


Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Edward Ed";
employees[28] = "Sue Storm";

Console.WriteLine($"The employee with ID number 28 is {employees[28]}");


Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");