

using System.Xml;

int age = 0;
int ageInTenYears = 0;

age = 28;
ageInTenYears = age + 10;

//int by default is a signed Int32
//Goes from -2,147,483,648 to 2,147,483,647	
//Signed means it has a plus or minus to it
//Unsigned starts at 0 and goes to 4,294,967,295

//Console.WriteLine(age);
Console.WriteLine(age); //Behind the scenes, WriteLine method is wrapping the variable in quotes to display it to the user, essentially using the .ToString() method
Console.WriteLine(ageInTenYears);


