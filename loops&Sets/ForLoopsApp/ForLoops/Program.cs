

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"The value of i is {i}");
//}

//string data = "Tim,Sue,Bob,Jane,Frank";

//List<string> firstNames = data.Split(',').ToList();

//for (int i = 0; i < firstNames.Count; i++)
//{
//    Console.WriteLine($"{firstNames[i]} is present");
//}


List<decimal> charges = new(); //Shortcut to saying List<decimal> charges = new List<decimal>();

charges.Add(23.78M);
charges.Add(15.89M);
charges.Add(125.00M);

decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Total charge is {total}");

