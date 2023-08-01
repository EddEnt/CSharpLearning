

TimeOnly opening = TimeOnly.Parse("8:00 AM");
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
TimeOnly holiday = TimeOnly.Parse("5:00 PM");

Console.WriteLine(opening);
Console.WriteLine(rightNow);
Console.WriteLine(holiday);
Console.WriteLine($"We are opening at {opening}, but will close at {holiday}.");
