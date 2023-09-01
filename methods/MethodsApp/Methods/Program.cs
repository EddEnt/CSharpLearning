//using static Methods.SampleMethods; NOT A GOOD PRACTICE. Always aim for call from a class with the class name for readability
//                                    For situations, may be good, but can lead to ambigious calls where you will not be able
//                                    to easily debug or read the program.
using Methods; //Correct way

//DRY - Don't Repeat Yourself

//Not about completly eliminating repetition, but eliminating repeating code
//Better to have an issue in one area of your code, which will be fixed once, rather than
//code that performs the same task, but split up into multiple classes or methods. That will require 
//multiple fixes to it, which may be missed during debugging.

//Example: Tax software. A calculation is performed, and the tax return is off by .1%. Logic is corrected, but
//due to 2 similar methods being used, one is fixed and the other is not. Now the tax return is only off by .05%.
//Better than it was, but still incorrect. Could lead to legal issues and fines for the company because of poor logic.

//SOLID ( Mnemonic acronym for five design principles)
//S - SRP (Single Responsibility Principle) - Every Class should have only one responsibility. Never does more than it should.

//O - OCP (Open-Closed Principle)           - Software entites should be open for extension, but closed for modification. 
//                                             Like a Parent-Child relationship, parent class is generalized, child is more specialized.

//L - LSP (Liskov Substitution Principle)   - Functions that use pointers or references to base classes, must be able use
//                                             objects of derived classes without knowing it; that is, if S is a subtype of T,
//                                             then objects of type T in a program may be replaced with objects of type S
//                                             without altering any of the desirable properties of that program.

//I - ISP (Interface Segregation Principle) - No code should be forced to depend on methods it does not use. Intended to keep a system
//                                             decoupled and easier to refactor, change and redeploy.

//D - DIP (Dependency Inversion Principle)  - High level modules should not depend on low level modules; both should depend on abstractions.
//                                             Abstractions should not depend on details. Details should depend on abstractions. Everything is
//                                             loosely coupled together, allowing for greater maintainability. When tightly coupled, becomes
//                                             much harder to fix or refactor.

string inputUserFirstName;

inputUserFirstName = SampleConsoleMethods.GetUsersName();

SampleConsoleMethods.SayHello(inputUserFirstName);

//Old style with our void method MathShortcuts.Add(5, 3);
double result = MathShortcuts.Add(5, 3);
Console.WriteLine($"The result is { result }");
//May also be Console.WriteLine($"The result is { MathShortcuts.Add(5, 3) }");

double[] vals = new double[]
{
    2, 5, 6, 21, 52, 98
};
MathShortcuts.AddAll(vals);

SampleConsoleMethods.SayGoodbye(inputUserFirstName);

//string lastName = Console.ReadLine(); Directly capturing the value

