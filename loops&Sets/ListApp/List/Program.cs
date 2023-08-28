

//List<T> - T = generic

List<string> firstNames = new List<string>();   //A list of strings, can only hold strings. List<of type string>

firstNames.Add("Ed");
firstNames.Add("Tim");
firstNames.Add("Nick");
firstNames.Add("Sue");
firstNames.Add("Bob");

Console.WriteLine(firstNames[0]);
Console.WriteLine(firstNames[2]);
Console.WriteLine(firstNames.Count); //Returns the number of elements in the List
Console.WriteLine(firstNames[firstNames.Count - 1]); //Counts through the list until the end, and returns the final entry

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);


