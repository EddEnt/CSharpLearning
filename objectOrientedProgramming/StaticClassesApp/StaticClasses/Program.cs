using StaticClasses;
//Program.cs class file


//Static - something which cannot be instantiated. You cannont create an object of a static class,
//         and cannot access static members using an object. They belong to the class itself. You can
//         access static members using the class name, without nneding to create an instance of the class
//         You can make: Static Fields: (public static int), properties shared among all instances of a class
//                       Static Methods: (public static int Addition() {} ), methods that belong to the class
//                          and are not associated with any specific instance
//                       Static Properties: Properties with a getter and/or setter that are associated with the class itself,
//                          rather than with instances.
//                       Static Constructors: Constructors that are called only once, when the class is first used,
//                          often for first-time initialization of static members or actions that need to be performed only once.
//                          Ex. - Class is using a log file and the constructor is used to write entries to the file
//                              - Enforcing run-time checks on type parameters that cannont be checked at compile time via type parameter constraints
//
//          When you declare something to be static, it lives for the entire lifespan of the application, taking up memory. Typically, you don't want this.
//              If you do, it should be for data that you INTEND to live for the entire lifespan. Otherwise, don't declare it static. Assume you will never
//              store data and prove that you need to when you may need to.

string firstName = RequestData.GetAString("What is your first name?: ");
UserMessages.ApplicationStartMessage(firstName);

double userNumber = RequestData.GetADouble("Please enter your first number: ");
double userNumber2 = RequestData.GetADouble("Please enter your second number: ");

double result = CalculateData.Add(userNumber, userNumber2);

UserMessages.PrintResultMessage($"The sum of {userNumber} and {userNumber2} is {result}.");