

string data = "Tim,Sue,Bob,Jane";
List<string> firstNames = data.Split(',').ToList();

//Foreach will return entries inside of a list/array
//For allows fine tuning your return, until the bool expression evaluates to true
foreach (string firstName in firstNames) //Can use var to work with a foreach, will be assigned the variable type based on the first entry in the list
{
    Console.WriteLine(firstName);
}
