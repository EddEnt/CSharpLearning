

//Welcome user to the app
Console.WriteLine("Welcome to the Greeting App, User!");
Console.WriteLine("This app was built by Edward Entecott.");
Console.WriteLine("------------------------------------------");
Console.WriteLine();

//Ask user for their first name
Console.Write("To start, please enter your first name: ");

string? firstName; //? denotes a string as potentially being null
firstName = Console.ReadLine();

//Output greeting user by their first name
Console.WriteLine("Well done " + firstName + ", now you know about capturing user input into variables. :) ");
Console.WriteLine("Thank you for using the application. The app will now exit on a key press.");
Console.ReadKey();

