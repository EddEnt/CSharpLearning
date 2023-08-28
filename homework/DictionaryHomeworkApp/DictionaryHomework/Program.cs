
int inputEmployeeKey;

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1923] = "Edward";
employees[5021] = "Mark";
employees[1234] = "Juliet";
employees[9217] = "Romeo";

Console.WriteLine("--- Employee Records ---");
Console.Write("Please enter the employee number you wish to find: ");

inputEmployeeKey = Convert.ToInt32(Console.ReadLine());

if (employees.ContainsKey(inputEmployeeKey))
{
    string resultEmployeeName = employees[inputEmployeeKey];
    Console.WriteLine($"Result: {resultEmployeeName}");
}
else
{
    Console.WriteLine("Entry not found...");
}



