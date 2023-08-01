

//Only in .NET 6 +
//DateOnly will ONLY show the date, removes the timestamp
DateOnly birthday = DateOnly.Parse("14/09/1994");
//DateOnly birth = DateOnly.Parse("32/13/0001"); Will not work! FormatException crash
DateOnly birth = DateOnly.Parse("31/12/0001");

Console.WriteLine(birthday.ToString("d MMMM, yyyy"));
Console.WriteLine($"Your birthday is on: {birthday}!");
Console.WriteLine(birth);
Console.WriteLine($"You were born on: {birth}! You are really old.");

