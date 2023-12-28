using LessonLibrary.Models;
//On creation of the LessonLibrary, the ClassLibraries project is unable to know about it. It must be added to the Dependencies of ClassLibraries.
//Then, it can be imported by the namespace. Libraries are perfect for sharing code, instead of grouping it all into one project file with many, many folders
//!!!-----> Important to note, User Interfaces reference Libraries, Libraries DO NOT reference User Interfaces <-----!!!

PersonModel person = new ();

person.FirstName = "Dave";
person.LastName = "Chappelle";
Console.WriteLine($"{person.FirstName} {person.LastName}");


