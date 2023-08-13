

//string [] firstNames = new string[5];

//firstNames[0] = "Tim";
//firstNames[1] = "Edward";
//firstNames[2] = "Nick";
//firstNames[3] = "Matt";
//firstNames[4] = "Peter";

//Console.WriteLine($"The names in the array are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, " +
//                  $"{firstNames[3]}, {firstNames[4]}.");

//Single quotes identifies a single char(character) More efficient in memory
//Double quotes identifies a string of characters

string data = "Edward, Nick, Alison, Penny, Peter";
string [] firstNames = data.Split(',');
string [] lastNames = new string[] { "En", "Te", "Co", "Tt", "Yy" };
int [] age = new int[] { 2, 3, 4, 5, 6 };

Console.WriteLine(firstNames.Length);
Console.WriteLine(firstNames[1]);
Console.WriteLine(lastNames.Length);
Console.WriteLine(age.Length);
