

using System.Globalization;

DateTime today = DateTime.Now; //Use computer local time
DateTime utcToday = DateTime.UtcNow; //UTC no offset

DateTime birthday = DateTime.ParseExact("14/09/1994", "d/M/yyyy", CultureInfo.InvariantCulture); //Culture info requires adding System.Globalization,
                                                                                                 //Invariant culture tells the system to disregard culture

Console.WriteLine(today.ToString("F"));
Console.WriteLine(birthday);
Console.WriteLine(today.ToString("MMMM, dd, yyyy, H:m tt zzz"));
Console.WriteLine(utcToday.ToString("MMMM, dd, yyyy, H:m tt zzz"));
