

//Null - Lack of value

//Have not asked a user for their age yet

//int age = null; Can not convert null into an integer, must have a value

int ? age = null; //? allows for a variable to be of a nullable value
bool ? birthday = null;
double ? weight = null;
//string firstName = null; //Strings accept null being declared without the ?,
                         //error message will still be displayed, because you
                         //have not declare to the compiler that you may expect
                         //some null value
string ? firstName = null; //<--Better practice

Console.WriteLine("Age: " + age);
Console.WriteLine("Birthday: " + birthday);
Console.WriteLine("Weight: " + weight);
Console.WriteLine("First Name: " + firstName);
Console.WriteLine("-------------------");

